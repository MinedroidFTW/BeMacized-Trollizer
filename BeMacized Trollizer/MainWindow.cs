using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;  

namespace BeMacized_Trollizer
{
    public partial class MainWindow : Form
    {
        WebBrowser wb;
        public MainWindow()
        {
            InitializeComponent();
            this.Text = "BeMacized Trollizer - " + Application.ProductVersion;
            txtPST.BackColor = SystemColors.Control;
            txtPST.ForeColor = SystemColors.Control;
            txtPST.Text = "Succes!";
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
            // skype autochat: skype:username?chat
            // skype autocall: skype:username?call
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

        private void btnSpamStart_Click(object sender, EventArgs e)
        {
            int times = 0;
            try
            {
                times = Convert.ToInt32(txtspamrepeat.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Just use a number at repeat option...");
            }
            if (times != 0)
            {
                MessageBox.Show("Focus in a textfield and wait 5 seconds after pressing ok!", "Prepare!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                StartSpamTimer(txtspamtext.Text, times, chckSpam.Checked);
            }
        }
        public void StartSpamTimer(string spamtext, int times, bool use)
        {
            System.Timers.Timer Clock = new System.Timers.Timer(5000);
            Clock.Elapsed += delegate { Wouter.Main.StartSpam(spamtext, times, use); Clock.Dispose(); };
            Clock.Start();
        }

        private void Tooltip_Popup(object sender, PopupEventArgs e)
        {
            Tooltip.IsBalloon = true;
        }

        private void btnPrintScreen_Click(object sender, EventArgs e)
        {
            if (Settings.canuseprintscreen)
            {
                Settings.canuseprintscreen = false;
                MessageBox.Show("Please focus where you want to take an image, and press ok!", "Get ready!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.WindowState = FormWindowState.Minimized;
                this.Opacity = 0;
                PrintScreen();
                this.Opacity = 100;
            }
            else
            {
                MessageBox.Show("Print screen is cooling down ;)");
            }
        }
        public void PrintScreen()
        {
            SendKeys.SendWait("{PRTSC}");
            BeMacized_Trollizer.MainWindow.ActiveForm.Opacity = 100;
            txtPST.BackColor = Color.DarkGreen;
            RestorePST();
        }
        public void RestorePST()
        {
            System.Timers.Timer Clock = new System.Timers.Timer(3000);
            Clock.Elapsed += delegate
            {
                Settings.canuseprintscreen = true;
                txtPST.BackColor = SystemColors.Control;
                Clock.Dispose();
            };
            Clock.Start();
        }
    }
}
