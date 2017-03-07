using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenshotUploaderGUI
{
    public partial class Form1 : Form
    {
        [DllImport("main.dll")]
        private static extern int ScreenUpload(int Dappid, char[] Dpath, char[] Dplace, int DtagCount, UInt64[] DsteamIDs);
        public Form1()
        {
            InitializeComponent();
        }

        private void checkTagged_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkTagged.Checked)
            {
                steamids.ReadOnly = false;
            }
            else
            {
                steamids.ReadOnly = true;
            }
        }

        private void browse_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                path.Text = openFileDialog1.FileName;
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            int tagCount = 0;
            UInt64[] steamIDs = null;
            if (appid.Text == ""){
                output.Text = "Specify AppID";
                return;
            }
            if (path.Text == "")
            {
                output.Text = "Specify Image Path";
                return;
            }
            if (checkTagged.Checked)
            {
                tagCount = steamids.Lines.Length;
                if (tagCount != 0) {
                    string[] steamids_arr = steamids.Text.Split('\n');
                    steamIDs = new UInt64[tagCount];
                    for (int a = 0; a < tagCount; a++)
                    {
                        steamIDs[a] = Convert.ToUInt64(steamids_arr[a]);
                    }
                }
            }
            int sUpload = ScreenUpload(Int32.Parse(appid.Text), (path.Text).ToCharArray(), (location.Text).ToCharArray(), tagCount, steamIDs);
            switch (sUpload)
            {
                case 1:
                    output.Text = "Success";
                    break;
                case 2:
                    output.Text = "Unable to init SteamAPI";
                    break;
                case 3:
                    output.Text = "Unable to init client. AppID may be incorrect.";
                    break;
                case 4:
                    output.Text = "Failed to upload screenshot";
                    break;
                default:
                    output.Text = "Unknown Error";
                    break;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://steamcommunity.com/profiles/76561198097216965");
        }
    }
}
