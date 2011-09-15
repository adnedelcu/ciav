using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ciav
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static Process ffmpeg;

        private void button1_Click(object sender, EventArgs e)
        {            
            string videoInput;
            string videoOutput;
            string vCodec = null;

            videoInput = inputFile.Text;
            videoOutput = outputFile.Text;

            ffmpeg = new Process();
            
            if (videoCodec.Text.Contains("mp4"))
            {
                vCodec = "mp4";
                ffmpeg.StartInfo.Arguments = " -i " + videoInput + " -s " + videoWidth.Text + "x" + videoHeight.Text + " -strict experimental -f " + vCodec + " -b " + videoBitrate.Text + "k -ab " + audioBitrate.Text + "k -ar " + audioSample.Text + " " + videoOutput; // arguments !
            }
            if (videoCodec.Text.Contains("avi"))
            {
                vCodec = "avi";
                ffmpeg.StartInfo.Arguments = " -i " + videoInput + " -s " + videoWidth.Text + "x" + videoHeight.Text + " -f " + vCodec + " -b " + videoBitrate.Text + "k -ab " + audioBitrate.Text + "k -ar " + audioSample.Text + " " + videoOutput; // arguments !
            }
            if (videoCodec.Text.Contains("wmv"))
            {
                vCodec = "libxvid";
                ffmpeg.StartInfo.Arguments = " -i " + videoInput + " -s " + videoWidth.Text + "x" + videoHeight.Text + " -vcodec " + vCodec + " -b " + videoBitrate.Text + "k -ab " + audioBitrate.Text + "k -ar " + audioSample.Text + " " + videoOutput; // arguments !
            }
            if (videoCodec.Text.Contains("flv"))
            {
                ffmpeg.StartInfo.Arguments = " -i " + videoInput + " -s " + videoWidth.Text + "x" + videoHeight.Text + " -b " + videoBitrate.Text + "k -ab " + audioBitrate.Text + "k -ar " + audioSample.Text + " " + videoOutput; // arguments !
            }
            ffmpeg.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            ffmpeg.StartInfo.FileName = "ffmpeg.exe";
            ffmpeg.EnableRaisingEvents = true;
            ffmpeg.Exited += new EventHandler(ffmpeg_Exited);
            ffmpeg.Start();
            button1.Enabled = false;
            MessageBox.Show("Please wait, conversion in progress", "Conversion info:");
            ffmpeg.WaitForExit();
            button1.Enabled = true;
        }
        
        private void ffmpeg_Exited(object sender, EventArgs e)
        {
            MessageBox.Show("Conversion Complete", "Conversion Info:");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                inputFile.Text = openFileDialog1.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            outputFile.Text = saveFileDialog1.FileName;
        }
    }
}
