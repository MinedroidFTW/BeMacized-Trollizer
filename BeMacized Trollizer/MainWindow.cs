using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace BeMacized_Trollizer
{
    public partial class MainWindow : Form
    {
        WebBrowser wb;
        public MainWindow()
        {
            InitializeComponent();
            this.Text = "BeMacized Trollizer - " + Application.ProductVersion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPwdGen_Click(object sender, EventArgs e)
        {
            try
            {
                txtPwd.Text = Wouter.Main.GenPassword(Convert.ToInt32(txtPwdLgth.Text));
            }
            catch
            {
                MessageBox.Show("fail");
            }
        }

        private void btnMD5gen_Click(object sender, EventArgs e)
        {
            txtMD5output.Text = Wouter.Main.GenMD5(txtMD5input.Text, MD5useweb.Checked);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            wb = new WebBrowser();
            wb.Navigate("skype:Wouto1997?chat");
            wb.Dispose();
        }

        private void mailWouto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            wb = new WebBrowser();
            wb.Navigate("mailto:wouto1997@gmail.com");
            wb.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog d = new FolderBrowserDialog();
            d.ShowDialog();
            txtFilePath.Text = d.SelectedPath;
        }

        private void btnFileCreate_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(txtFilePath.Text + @"\" + txtFileName.Text) && !File.Exists(txtFilePath.Text + @"\" + txtFileName.Text))
            {
                File.CreateText(txtFilePath.Text + @"\" + txtFileName.Text).Close();
            }
            else
            {
                MessageBox.Show("File or directory with that name already exists!");
            }
        }

        private void btnDirCreate_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(txtFilePath.Text + @"\" + txtFileName.Text) && !File.Exists(txtFilePath.Text + @"\" + txtFileName.Text))
            {
                Directory.CreateDirectory(txtFilePath.Text + @"\" + txtFileName.Text);
            }
            else
            {
                MessageBox.Show("File or directory with that name already exists!");
            }
        }
    }
}
