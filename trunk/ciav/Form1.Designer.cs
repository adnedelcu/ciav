namespace ciav
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.inputFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.outputFile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.videoBitrate = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.videoCodec = new System.Windows.Forms.ComboBox();
            this.audioCodec = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.audioBitrate = new System.Windows.Forms.ComboBox();
            this.videoHeight = new System.Windows.Forms.TextBox();
            this.videoWidth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.audioSample = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(255, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Video Files|*.avi;*.mpeg;*.mp4;*.wmv";
            this.openFileDialog1.InitialDirectory = "c:\\";
            this.openFileDialog1.Title = "Open File";
            // 
            // inputFile
            // 
            this.inputFile.Location = new System.Drawing.Point(89, 28);
            this.inputFile.Name = "inputFile";
            this.inputFile.Size = new System.Drawing.Size(161, 20);
            this.inputFile.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Input file";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(255, 51);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // outputFile
            // 
            this.outputFile.Location = new System.Drawing.Point(89, 53);
            this.outputFile.Name = "outputFile";
            this.outputFile.Size = new System.Drawing.Size(160, 20);
            this.outputFile.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Output file";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "AVI File|*.avi|Flash File|*.flv|Mpeg 4 File|*.mp4|WMV File|*.wmv";
            this.saveFileDialog1.Title = "Save File";
            // 
            // videoBitrate
            // 
            this.videoBitrate.FormattingEnabled = true;
            this.videoBitrate.Items.AddRange(new object[] {
            "32",
            "60",
            "64",
            "119",
            "120",
            "128",
            "144",
            "146",
            "160",
            "192",
            "200",
            "224",
            "256",
            "320",
            "400",
            "500",
            "600",
            "750",
            "760",
            "1024",
            "1228",
            "1331"});
            this.videoBitrate.Location = new System.Drawing.Point(89, 81);
            this.videoBitrate.Name = "videoBitrate";
            this.videoBitrate.Size = new System.Drawing.Size(161, 21);
            this.videoBitrate.TabIndex = 10;
            this.videoBitrate.Text = "32";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Video Bitrate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Video Codec";
            // 
            // videoCodec
            // 
            this.videoCodec.FormattingEnabled = true;
            this.videoCodec.Items.AddRange(new object[] {
            ".mp4, MPEG-4",
            ".avi, MPEG-4",
            ".wmv, Windows Media Video 9",
            ".flv, H.263"});
            this.videoCodec.Location = new System.Drawing.Point(89, 108);
            this.videoCodec.Name = "videoCodec";
            this.videoCodec.Size = new System.Drawing.Size(161, 21);
            this.videoCodec.TabIndex = 13;
            this.videoCodec.Text = ".mp4, MPEG-4";
            // 
            // audioCodec
            // 
            this.audioCodec.FormattingEnabled = true;
            this.audioCodec.Items.AddRange(new object[] {
            "AAC",
            "WAV",
            "WMA",
            "MP3"});
            this.audioCodec.Location = new System.Drawing.Point(89, 162);
            this.audioCodec.Name = "audioCodec";
            this.audioCodec.Size = new System.Drawing.Size(161, 21);
            this.audioCodec.TabIndex = 17;
            this.audioCodec.Text = "AAC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Audio Codec";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Audio Bitrate";
            // 
            // audioBitrate
            // 
            this.audioBitrate.FormattingEnabled = true;
            this.audioBitrate.Items.AddRange(new object[] {
            "16",
            "32",
            "44",
            "48",
            "64",
            "80",
            "96",
            "112",
            "128",
            "160",
            "192"});
            this.audioBitrate.Location = new System.Drawing.Point(89, 135);
            this.audioBitrate.Name = "audioBitrate";
            this.audioBitrate.Size = new System.Drawing.Size(161, 21);
            this.audioBitrate.TabIndex = 14;
            this.audioBitrate.Text = "128";
            // 
            // videoHeight
            // 
            this.videoHeight.Location = new System.Drawing.Point(89, 240);
            this.videoHeight.Name = "videoHeight";
            this.videoHeight.Size = new System.Drawing.Size(75, 20);
            this.videoHeight.TabIndex = 18;
            this.videoHeight.Text = "480";
            // 
            // videoWidth
            // 
            this.videoWidth.Location = new System.Drawing.Point(89, 214);
            this.videoWidth.Name = "videoWidth";
            this.videoWidth.Size = new System.Drawing.Size(75, 20);
            this.videoWidth.TabIndex = 19;
            this.videoWidth.Text = "640";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Height";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Width";
            // 
            // audioSample
            // 
            this.audioSample.FormattingEnabled = true;
            this.audioSample.Items.AddRange(new object[] {
            "22050",
            "32000",
            "44100",
            "48000"});
            this.audioSample.Location = new System.Drawing.Point(89, 187);
            this.audioSample.Name = "audioSample";
            this.audioSample.Size = new System.Drawing.Size(161, 21);
            this.audioSample.TabIndex = 23;
            this.audioSample.Text = "22050";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Audio Sample";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(19, 264);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(181, 23);
            this.progressBar1.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 299);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.audioSample);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.videoWidth);
            this.Controls.Add(this.videoHeight);
            this.Controls.Add(this.audioCodec);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.audioBitrate);
            this.Controls.Add(this.videoCodec);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.videoBitrate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.outputFile);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputFile);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "CIAV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox inputFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox outputFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ComboBox videoBitrate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox videoCodec;
        private System.Windows.Forms.ComboBox audioCodec;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox audioBitrate;
        private System.Windows.Forms.TextBox videoHeight;
        private System.Windows.Forms.TextBox videoWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox audioSample;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

