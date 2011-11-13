using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using BeMacized_Trollizer.Wouter;

namespace BeMacized_Trollizer
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Text = "BeMacized Trollizer - " + Application.ProductVersion; 
            webBrowser1.Navigate("http://data.bemacizedgaming.com/bmgtroller.php?cv=" + Application.ProductVersion);
            txtPST.BackColor = SystemColors.Control;
            txtPST.ForeColor = SystemColors.Control;
            txtPST.Text = "Succes!";
            if (!Settings.CheckUpdate()) { MessageBox.Show("You need to update!"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPwdGen_Click(object sender, EventArgs e)
        {
            try
            {
                txtPwd.Text = Main.GenPassword(Convert.ToInt32(txtPwdLgth.Text));
            }
            catch
            {
                MessageBox.Show("Failed!");
            }
        }

        private void btnMD5gen_Click(object sender, EventArgs e)
        {
            txtMD5output.Text = Wouter.Main.GenMD5(txtMD5input.Text, MD5useweb.Checked);
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

        private void button1_Click_1(object sender, EventArgs e)
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
                StartSpamTimer(".", times, chckSpam.Checked);
            }
        }
    }
}
