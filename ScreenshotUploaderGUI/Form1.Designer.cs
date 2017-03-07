namespace ScreenshotUploaderGUI
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.appid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.TextBox();
            this.path = new System.Windows.Forms.TextBox();
            this.steamids = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.browse = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.checkTagged = new System.Windows.Forms.CheckBox();
            this.output = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Images|*.bmp;*.jpg;*.gif;*.png;*.jpeg";
            // 
            // appid
            // 
            this.appid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.appid.ForeColor = System.Drawing.Color.White;
            this.appid.Location = new System.Drawing.Point(32, 100);
            this.appid.Name = "appid";
            this.appid.Size = new System.Drawing.Size(147, 20);
            this.appid.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "AppID";
            // 
            // location
            // 
            this.location.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.location.ForeColor = System.Drawing.Color.White;
            this.location.Location = new System.Drawing.Point(197, 100);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(228, 20);
            this.location.TabIndex = 3;
            // 
            // path
            // 
            this.path.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.path.ForeColor = System.Drawing.Color.White;
            this.path.Location = new System.Drawing.Point(32, 150);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(312, 20);
            this.path.TabIndex = 4;
            // 
            // steamids
            // 
            this.steamids.AccessibleDescription = "";
            this.steamids.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.steamids.ForeColor = System.Drawing.Color.White;
            this.steamids.Location = new System.Drawing.Point(443, 100);
            this.steamids.Name = "steamids";
            this.steamids.ReadOnly = true;
            this.steamids.Size = new System.Drawing.Size(169, 47);
            this.steamids.TabIndex = 5;
            this.steamids.Text = "One SteamID64 per line";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(194, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Image Path";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(440, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tagged Players";
            // 
            // browse
            // 
            this.browse.BackColor = System.Drawing.Color.Transparent;
            this.browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browse.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.browse.ForeColor = System.Drawing.Color.White;
            this.browse.Location = new System.Drawing.Point(350, 146);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(75, 27);
            this.browse.TabIndex = 9;
            this.browse.Text = "Browse";
            this.browse.UseVisualStyleBackColor = false;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.Transparent;
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start.ForeColor = System.Drawing.Color.White;
            this.start.Location = new System.Drawing.Point(628, 100);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(114, 47);
            this.start.TabIndex = 10;
            this.start.Text = "Upload";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(684, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Made by Umfc";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // checkTagged
            // 
            this.checkTagged.AutoSize = true;
            this.checkTagged.BackColor = System.Drawing.Color.Transparent;
            this.checkTagged.Location = new System.Drawing.Point(540, 83);
            this.checkTagged.Name = "checkTagged";
            this.checkTagged.Size = new System.Drawing.Size(15, 14);
            this.checkTagged.TabIndex = 13;
            this.checkTagged.UseVisualStyleBackColor = false;
            this.checkTagged.CheckStateChanged += new System.EventHandler(this.checkTagged_CheckStateChanged);
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.output.ForeColor = System.Drawing.Color.White;
            this.output.Location = new System.Drawing.Point(491, 153);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(251, 20);
            this.output.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(440, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Output";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(106, -29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(558, 100);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(774, 185);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.output);
            this.Controls.Add(this.checkTagged);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.start);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.steamids);
            this.Controls.Add(this.path);
            this.Controls.Add(this.location);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.appid);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Steam Screenshot Uploader";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox appid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox location;
        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.RichTextBox steamids;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkTagged;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

