namespace BeMacized_Trollizer
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.webControl1 = new Awesomium.Windows.Forms.WebControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.DirCreateGB = new System.Windows.Forms.GroupBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.lblFilename = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnFileCreate = new System.Windows.Forms.Button();
            this.btnDirCreate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MD5useweb = new System.Windows.Forms.CheckBox();
            this.lblMD52 = new System.Windows.Forms.Label();
            this.lblMD51 = new System.Windows.Forms.Label();
            this.btnMD5gen = new System.Windows.Forms.Button();
            this.txtMD5output = new System.Windows.Forms.TextBox();
            this.txtMD5input = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPwd = new System.Windows.Forms.RichTextBox();
            this.txtPwdLgth = new System.Windows.Forms.TextBox();
            this.Pwdlabel = new System.Windows.Forms.Label();
            this.btnPwdGen = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtPST = new System.Windows.Forms.TextBox();
            this.btnPrintScreen = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chckSpam = new System.Windows.Forms.CheckBox();
            this.btnSpamStart = new System.Windows.Forms.Button();
            this.lblspamrepeat = new System.Windows.Forms.Label();
            this.txtspamrepeat = new System.Windows.Forms.TextBox();
            this.txtspamtext = new System.Windows.Forms.TextBox();
            this.lblspamtext = new System.Windows.Forms.Label();
            this.btnEXIT = new System.Windows.Forms.Button();
            this.Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.DirCreateGB.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(643, 432);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.webBrowser1);
            this.tabPage1.Controls.Add(this.webControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(635, 406);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            // 
            // webControl1
            // 
            this.webControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webControl1.Location = new System.Drawing.Point(3, 3);
            this.webControl1.Name = "webControl1";
            this.webControl1.Size = new System.Drawing.Size(629, 400);
            this.webControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.DirCreateGB);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(635, 406);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Generators";
            // 
            // DirCreateGB
            // 
            this.DirCreateGB.Controls.Add(this.txtFileName);
            this.DirCreateGB.Controls.Add(this.lblFilePath);
            this.DirCreateGB.Controls.Add(this.lblFilename);
            this.DirCreateGB.Controls.Add(this.txtFilePath);
            this.DirCreateGB.Controls.Add(this.btnBrowse);
            this.DirCreateGB.Controls.Add(this.btnFileCreate);
            this.DirCreateGB.Controls.Add(this.btnDirCreate);
            this.DirCreateGB.Location = new System.Drawing.Point(218, 113);
            this.DirCreateGB.Name = "DirCreateGB";
            this.DirCreateGB.Size = new System.Drawing.Size(411, 100);
            this.DirCreateGB.TabIndex = 7;
            this.DirCreateGB.TabStop = false;
            this.DirCreateGB.Text = "Create textfiles and directories with any name!";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(45, 54);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(250, 20);
            this.txtFileName.TabIndex = 7;
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(6, 18);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(29, 13);
            this.lblFilePath.TabIndex = 6;
            this.lblFilePath.Text = "Path";
            // 
            // lblFilename
            // 
            this.lblFilename.AutoSize = true;
            this.lblFilename.Location = new System.Drawing.Point(5, 57);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(34, 13);
            this.lblFilename.TabIndex = 5;
            this.lblFilename.Text = "Name";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(41, 15);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(254, 20);
            this.txtFilePath.TabIndex = 4;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(301, 13);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(104, 23);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnFileCreate
            // 
            this.btnFileCreate.Location = new System.Drawing.Point(301, 42);
            this.btnFileCreate.Name = "btnFileCreate";
            this.btnFileCreate.Size = new System.Drawing.Size(104, 23);
            this.btnFileCreate.TabIndex = 2;
            this.btnFileCreate.Text = "Create Textfile";
            this.btnFileCreate.UseVisualStyleBackColor = true;
            this.btnFileCreate.Click += new System.EventHandler(this.btnFileCreate_Click);
            // 
            // btnDirCreate
            // 
            this.btnDirCreate.Location = new System.Drawing.Point(301, 71);
            this.btnDirCreate.Name = "btnDirCreate";
            this.btnDirCreate.Size = new System.Drawing.Size(104, 23);
            this.btnDirCreate.TabIndex = 1;
            this.btnDirCreate.Text = "Create Directory";
            this.btnDirCreate.UseVisualStyleBackColor = true;
            this.btnDirCreate.Click += new System.EventHandler(this.btnDirCreate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MD5useweb);
            this.groupBox2.Controls.Add(this.lblMD52);
            this.groupBox2.Controls.Add(this.lblMD51);
            this.groupBox2.Controls.Add(this.btnMD5gen);
            this.groupBox2.Controls.Add(this.txtMD5output);
            this.groupBox2.Controls.Add(this.txtMD5input);
            this.groupBox2.Location = new System.Drawing.Point(218, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MD5 Generator";
            // 
            // MD5useweb
            // 
            this.MD5useweb.AutoSize = true;
            this.MD5useweb.Location = new System.Drawing.Point(11, 48);
            this.MD5useweb.Name = "MD5useweb";
            this.MD5useweb.Size = new System.Drawing.Size(102, 17);
            this.MD5useweb.TabIndex = 9;
            this.MD5useweb.Text = "Use webversion";
            this.Tooltip.SetToolTip(this.MD5useweb, "Enable this if you want to use a webpage to create \r\nthe MD5 hash instead of the " +
                    "program.");
            this.MD5useweb.UseVisualStyleBackColor = true;
            // 
            // lblMD52
            // 
            this.lblMD52.AutoSize = true;
            this.lblMD52.Location = new System.Drawing.Point(6, 76);
            this.lblMD52.Name = "lblMD52";
            this.lblMD52.Size = new System.Drawing.Size(41, 13);
            this.lblMD52.TabIndex = 8;
            this.lblMD52.Text = "Output";
            // 
            // lblMD51
            // 
            this.lblMD51.AutoSize = true;
            this.lblMD51.Location = new System.Drawing.Point(6, 21);
            this.lblMD51.Name = "lblMD51";
            this.lblMD51.Size = new System.Drawing.Size(33, 13);
            this.lblMD51.TabIndex = 7;
            this.lblMD51.Text = "Input";
            // 
            // btnMD5gen
            // 
            this.btnMD5gen.Location = new System.Drawing.Point(119, 44);
            this.btnMD5gen.Name = "btnMD5gen";
            this.btnMD5gen.Size = new System.Drawing.Size(94, 23);
            this.btnMD5gen.TabIndex = 2;
            this.btnMD5gen.Text = "Generate";
            this.btnMD5gen.UseVisualStyleBackColor = true;
            this.btnMD5gen.Click += new System.EventHandler(this.btnMD5gen_Click);
            // 
            // txtMD5output
            // 
            this.txtMD5output.Location = new System.Drawing.Point(59, 73);
            this.txtMD5output.Name = "txtMD5output";
            this.txtMD5output.Size = new System.Drawing.Size(157, 20);
            this.txtMD5output.TabIndex = 1;
            // 
            // txtMD5input
            // 
            this.txtMD5input.Location = new System.Drawing.Point(62, 18);
            this.txtMD5input.Name = "txtMD5input";
            this.txtMD5input.Size = new System.Drawing.Size(152, 20);
            this.txtMD5input.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPwd);
            this.groupBox1.Controls.Add(this.txtPwdLgth);
            this.groupBox1.Controls.Add(this.Pwdlabel);
            this.groupBox1.Controls.Add(this.btnPwdGen);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Password Generator";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(6, 19);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(194, 74);
            this.txtPwd.TabIndex = 5;
            this.txtPwd.Text = "";
            // 
            // txtPwdLgth
            // 
            this.txtPwdLgth.Location = new System.Drawing.Point(70, 99);
            this.txtPwdLgth.Name = "txtPwdLgth";
            this.txtPwdLgth.Size = new System.Drawing.Size(64, 20);
            this.txtPwdLgth.TabIndex = 4;
            this.txtPwdLgth.Text = "100";
            // 
            // Pwdlabel
            // 
            this.Pwdlabel.AutoSize = true;
            this.Pwdlabel.Location = new System.Drawing.Point(6, 102);
            this.Pwdlabel.Name = "Pwdlabel";
            this.Pwdlabel.Size = new System.Drawing.Size(58, 13);
            this.Pwdlabel.TabIndex = 3;
            this.Pwdlabel.Text = "characters";
            // 
            // btnPwdGen
            // 
            this.btnPwdGen.Location = new System.Drawing.Point(140, 97);
            this.btnPwdGen.Name = "btnPwdGen";
            this.btnPwdGen.Size = new System.Drawing.Size(60, 23);
            this.btnPwdGen.TabIndex = 0;
            this.btnPwdGen.Text = "Generate";
            this.btnPwdGen.UseVisualStyleBackColor = true;
            this.btnPwdGen.Click += new System.EventHandler(this.btnPwdGen_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Controls.Add(this.groupBox3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(635, 406);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Misc";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtPST);
            this.groupBox4.Controls.Add(this.btnPrintScreen);
            this.groupBox4.Location = new System.Drawing.Point(287, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(129, 68);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Print Screen";
            // 
            // txtPST
            // 
            this.txtPST.Location = new System.Drawing.Point(6, 44);
            this.txtPST.Name = "txtPST";
            this.txtPST.ReadOnly = true;
            this.txtPST.Size = new System.Drawing.Size(117, 20);
            this.txtPST.TabIndex = 1;
            this.txtPST.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPrintScreen
            // 
            this.btnPrintScreen.Location = new System.Drawing.Point(6, 19);
            this.btnPrintScreen.Name = "btnPrintScreen";
            this.btnPrintScreen.Size = new System.Drawing.Size(117, 23);
            this.btnPrintScreen.TabIndex = 0;
            this.btnPrintScreen.Text = "Print Screen";
            this.Tooltip.SetToolTip(this.btnPrintScreen, "This copies your current screen to your clipboard\r\nas image. When you press okay " +
                    "the form will hide and\r\ntake the screenshot! so be prepared :)");
            this.btnPrintScreen.UseVisualStyleBackColor = true;
            this.btnPrintScreen.Click += new System.EventHandler(this.btnPrintScreen_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chckSpam);
            this.groupBox3.Controls.Add(this.btnSpamStart);
            this.groupBox3.Controls.Add(this.lblspamrepeat);
            this.groupBox3.Controls.Add(this.txtspamrepeat);
            this.groupBox3.Controls.Add(this.txtspamtext);
            this.groupBox3.Controls.Add(this.lblspamtext);
            this.groupBox3.Location = new System.Drawing.Point(3, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(278, 100);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Spamtool";
            // 
            // chckSpam
            // 
            this.chckSpam.AutoSize = true;
            this.chckSpam.Checked = true;
            this.chckSpam.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chckSpam.Location = new System.Drawing.Point(6, 75);
            this.chckSpam.Name = "chckSpam";
            this.chckSpam.Size = new System.Drawing.Size(102, 17);
            this.chckSpam.TabIndex = 5;
            this.chckSpam.Text = "Use fast sender";
            this.Tooltip.SetToolTip(this.chckSpam, resources.GetString("chckSpam.ToolTip"));
            this.chckSpam.UseVisualStyleBackColor = true;
            // 
            // btnSpamStart
            // 
            this.btnSpamStart.Location = new System.Drawing.Point(175, 71);
            this.btnSpamStart.Name = "btnSpamStart";
            this.btnSpamStart.Size = new System.Drawing.Size(97, 23);
            this.btnSpamStart.TabIndex = 4;
            this.btnSpamStart.Text = "Start";
            this.btnSpamStart.UseVisualStyleBackColor = true;
            this.btnSpamStart.Click += new System.EventHandler(this.btnSpamStart_Click);
            // 
            // lblspamrepeat
            // 
            this.lblspamrepeat.AutoSize = true;
            this.lblspamrepeat.Location = new System.Drawing.Point(6, 51);
            this.lblspamrepeat.Name = "lblspamrepeat";
            this.lblspamrepeat.Size = new System.Drawing.Size(42, 13);
            this.lblspamrepeat.TabIndex = 3;
            this.lblspamrepeat.Text = "Repeat";
            // 
            // txtspamrepeat
            // 
            this.txtspamrepeat.Location = new System.Drawing.Point(68, 48);
            this.txtspamrepeat.Name = "txtspamrepeat";
            this.txtspamrepeat.Size = new System.Drawing.Size(204, 20);
            this.txtspamrepeat.TabIndex = 2;
            this.txtspamrepeat.Text = "10";
            // 
            // txtspamtext
            // 
            this.txtspamtext.Location = new System.Drawing.Point(68, 22);
            this.txtspamtext.Name = "txtspamtext";
            this.txtspamtext.Size = new System.Drawing.Size(204, 20);
            this.txtspamtext.TabIndex = 1;
            this.txtspamtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblspamtext
            // 
            this.lblspamtext.AutoSize = true;
            this.lblspamtext.Location = new System.Drawing.Point(6, 25);
            this.lblspamtext.Name = "lblspamtext";
            this.lblspamtext.Size = new System.Drawing.Size(56, 13);
            this.lblspamtext.TabIndex = 0;
            this.lblspamtext.Text = "Spam text";
            // 
            // btnEXIT
            // 
            this.btnEXIT.Location = new System.Drawing.Point(559, 447);
            this.btnEXIT.Name = "btnEXIT";
            this.btnEXIT.Size = new System.Drawing.Size(75, 23);
            this.btnEXIT.TabIndex = 0;
            this.btnEXIT.Text = "Exit";
            this.btnEXIT.UseVisualStyleBackColor = true;
            this.btnEXIT.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tooltip
            // 
            this.Tooltip.IsBalloon = true;
            this.Tooltip.Popup += new System.Windows.Forms.PopupEventHandler(this.Tooltip_Popup);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(629, 400);
            this.webBrowser1.TabIndex = 1;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(638, 482);
            this.Controls.Add(this.btnEXIT);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "BeMacized Trollizer";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.DirCreateGB.ResumeLayout(false);
            this.DirCreateGB.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnEXIT;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPwdGen;
        private System.Windows.Forms.Label Pwdlabel;
        private System.Windows.Forms.TextBox txtPwdLgth;
        private System.Windows.Forms.RichTextBox txtPwd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblMD52;
        private System.Windows.Forms.Label lblMD51;
        private System.Windows.Forms.Button btnMD5gen;
        private System.Windows.Forms.TextBox txtMD5output;
        private System.Windows.Forms.TextBox txtMD5input;
        private System.Windows.Forms.CheckBox MD5useweb;
        private System.Windows.Forms.ToolTip Tooltip;
        private System.Windows.Forms.GroupBox DirCreateGB;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnFileCreate;
        private System.Windows.Forms.Button btnDirCreate;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtspamtext;
        private System.Windows.Forms.Label lblspamtext;
        private System.Windows.Forms.Label lblspamrepeat;
        private System.Windows.Forms.TextBox txtspamrepeat;
        private System.Windows.Forms.Button btnSpamStart;
        private System.Windows.Forms.CheckBox chckSpam;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnPrintScreen;
        private System.Windows.Forms.TextBox txtPST;
        private Awesomium.Windows.Forms.WebControl webControl1;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

