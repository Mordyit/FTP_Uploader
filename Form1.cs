using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public string filepath = null;
        public string filename = null;
        public string filePath_down = null;
        public string fileName_down = null;
        public WebClient wc = new WebClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // browas for upload file
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = "C:\\Users\\" + Environment.UserName;
            if (open.ShowDialog() == DialogResult.OK)
            {
                filepath = open.FileName;
                filename = open.SafeFileName;
            }
            txt_file_path.Text = filepath;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //  upload file
            WebClient wc = new WebClient();
            wc.Credentials = new NetworkCredential(txt_ftp_user.Text, txt_ftp_pass.Text);
            wc.UploadFile(txt_ftp_server.Text + "/" + filename, filepath);
        }

    }
}
