namespace BeMacized_Trollizer
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPwdGen = new System.Windows.Forms.Button();
            this.Pwdlabel = new System.Windows.Forms.Label();
            this.txtPwdLgth = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(635, 406);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(635, 406);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Misc";
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
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(635, 406);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Generators";
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
            // Pwdlabel
            // 
            this.Pwdlabel.AutoSize = true;
            this.Pwdlabel.Location = new System.Drawing.Point(6, 102);
            this.Pwdlabel.Name = "Pwdlabel";
            this.Pwdlabel.Size = new System.Drawing.Size(58, 13);
            this.Pwdlabel.TabIndex = 3;
            this.Pwdlabel.Text = "characters";
            // 
            // txtPwdLgth
            // 
            this.txtPwdLgth.Location = new System.Drawing.Point(70, 99);
            this.txtPwdLgth.Name = "txtPwdLgth";
            this.txtPwdLgth.Size = new System.Drawing.Size(64, 20);
            this.txtPwdLgth.TabIndex = 4;
            this.txtPwdLgth.Text = "100";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(6, 19);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(194, 74);
            this.txtPwd.TabIndex = 5;
            this.txtPwd.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 482);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "BeMacized Trollizer";
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPwdGen;
        private System.Windows.Forms.Label Pwdlabel;
        private System.Windows.Forms.TextBox txtPwdLgth;
        private System.Windows.Forms.RichTextBox txtPwd;
    }
}

