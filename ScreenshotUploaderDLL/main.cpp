#include "windows.h"
#include <iostream>
#include "wx/wx.h"
#include <\Steamworks\SteamclientAPI.h>
#include <\Steamworks\SteamAPI.h>
using namespace std;
#define DLL_FUNC extern "C" __declspec(dllexport) int

CSteamID CreateCSteamID(uint64 id){
	CSteamID user;
	user.Set(id, k_EUniversePublic, k_EAccountTypeIndividual);
	user.SetFromUint64(id);
	return user;
}

DLL_FUNC ScreenUpload(int appid, char* path, char* place, int tagCount, uint64 steamIDs[]){
	wstring lappid = to_wstring(appid);
	SetEnvironmentVariable(TEXT("SteamAppId"), lappid.c_str());
	///////////
	wxPNGHandler* pngH = new wxPNGHandler();
	wxImage::AddHandler(pngH);
	wxGIFHandler* gifH = new wxGIFHandler();
	wxImage::AddHandler(gifH);
	wxJPEGHandler* jpegH = new wxJPEGHandler();
	wxImage::AddHandler(jpegH);
	wxBMPHandler* bmpH = new wxBMPHandler();
	wxImage::AddHandler(bmpH);
	//////////
	CSteamAPILoader loader;
	auto *client = (ISteamClient012 *)loader.GetSteam3Factory()(STEAMCLIENT_INTERFACE_VERSION_012, NULL);
	if (!client)
	{
		return 2;
	}
	HSteamPipe pipe = client->CreateSteamPipe();
	if (!pipe)
	{
		return 2;
	}
	HSteamUser user = client->ConnectToGlobalUser(pipe);
	if (!user)
	{
		client->BReleaseSteamPipe(pipe);
		client->BShutdownIfAllPipesClosed();
		return 3;
	}
	//////////
	wxImage image(path);
	auto screenShots = (ISteamScreenshots001*)client->GetISteamScreenshots(user, pipe, STEAMSCREENSHOTS_INTERFACE_VERSION_001);
	ScreenshotHandle ScreenShot = screenShots->WriteScreenshot(image.GetData(), image.GetWidth() * image.GetHeight() * 3, image.GetWidth(), image.GetHeight());
	/////////
	if (!ScreenShot){
		return 4;
	}
	/////////
	if (place){
		screenShots->SetLocation(ScreenShot, place);
	}
	if (tagCount){
		for (int i = 0; i < tagCount; i++){
			CSteamID userObject = CreateCSteamID(steamIDs[i]);
			screenShots->TagUser(ScreenShot, userObject);
		}
	}
	client->ReleaseUser(pipe, user);
	client->BReleaseSteamPipe(pipe);
	client->BShutdownIfAllPipesClosed();
	return 1;
}
