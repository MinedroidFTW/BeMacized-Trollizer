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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
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
            this.button1 = new System.Windows.Forms.Button();
            this.Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.ContactGB = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.skypeWouto = new System.Windows.Forms.LinkLabel();
            this.mailWouto = new System.Windows.Forms.LinkLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ContactGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(643, 432);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.ContactGB);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(635, 406);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(635, 406);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Generators";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(559, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ContactGB
            // 
            this.ContactGB.Controls.Add(this.mailWouto);
            this.ContactGB.Controls.Add(this.skypeWouto);
            this.ContactGB.Controls.Add(this.label1);
            this.ContactGB.Location = new System.Drawing.Point(8, 6);
            this.ContactGB.Name = "ContactGB";
            this.ContactGB.Size = new System.Drawing.Size(105, 92);
            this.ContactGB.TabIndex = 1;
            this.ContactGB.TabStop = false;
            this.ContactGB.Text = "Contact us";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wouter:";
            // 
            // skypeWouto
            // 
            this.skypeWouto.AutoSize = true;
            this.skypeWouto.Location = new System.Drawing.Point(59, 25);
            this.skypeWouto.Name = "skypeWouto";
            this.skypeWouto.Size = new System.Drawing.Size(36, 13);
            this.skypeWouto.TabIndex = 1;
            this.skypeWouto.TabStop = true;
            this.skypeWouto.Text = "Skype";
            this.skypeWouto.VisitedLinkColor = System.Drawing.Color.Blue;
            this.skypeWouto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // mailWouto
            // 
            this.mailWouto.AutoSize = true;
            this.mailWouto.Location = new System.Drawing.Point(59, 42);
            this.mailWouto.Name = "mailWouto";
            this.mailWouto.Size = new System.Drawing.Size(25, 13);
            this.mailWouto.TabIndex = 2;
            this.mailWouto.TabStop = true;
            this.mailWouto.Text = "Mail";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 482);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainWindow";
            this.Text = "BeMacized Trollizer";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ContactGB.ResumeLayout(false);
            this.ContactGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.GroupBox ContactGB;
        private System.Windows.Forms.LinkLabel skypeWouto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel mailWouto;
    }
}

