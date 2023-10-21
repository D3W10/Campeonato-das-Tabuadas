
using System.Drawing;
using System.Windows.Forms;
using Multiplication_Championship.Components;

namespace Multiplication_Championship
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            lblWelcome = new Label();
            btnAprendiz = new Button();
            btnMestre = new Button();
            lblInfo = new Label();
            lblBetter = new Label();
            btnLogin = new Button();
            tbPassword = new TextBox();
            lblInfoMestre = new Label();
            lblLogin = new Label();
            tcPages = new TabControl();
            tpWelcome = new TabPage();
            tpMaster = new TabPage();
            tcPages.SuspendLayout();
            tpWelcome.SuspendLayout();
            tpMaster.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            resources.ApplyResources(lblWelcome, "lblWelcome");
            lblWelcome.Name = "lblWelcome";
            // 
            // btnAprendiz
            // 
            resources.ApplyResources(btnAprendiz, "btnAprendiz");
            btnAprendiz.Name = "btnAprendiz";
            btnAprendiz.UseVisualStyleBackColor = true;
            btnAprendiz.Click += btnAprendiz_Click;
            // 
            // btnMestre
            // 
            resources.ApplyResources(btnMestre, "btnMestre");
            btnMestre.Name = "btnMestre";
            btnMestre.UseVisualStyleBackColor = true;
            btnMestre.Click += btnMestre_Click;
            // 
            // lblInfo
            // 
            resources.ApplyResources(lblInfo, "lblInfo");
            lblInfo.Name = "lblInfo";
            // 
            // lblBetter
            // 
            resources.ApplyResources(lblBetter, "lblBetter");
            lblBetter.Name = "lblBetter";
            // 
            // btnLogin
            // 
            resources.ApplyResources(btnLogin, "btnLogin");
            btnLogin.Name = "btnLogin";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // tbPassword
            // 
            resources.ApplyResources(tbPassword, "tbPassword");
            tbPassword.Name = "tbPassword";
            tbPassword.ShortcutsEnabled = false;
            tbPassword.UseSystemPasswordChar = true;
            tbPassword.KeyPress += tbPassword_KeyPress;
            // 
            // lblInfoMestre
            // 
            resources.ApplyResources(lblInfoMestre, "lblInfoMestre");
            lblInfoMestre.Name = "lblInfoMestre";
            // 
            // lblLogin
            // 
            resources.ApplyResources(lblLogin, "lblLogin");
            lblLogin.Name = "lblLogin";
            // 
            // tcPages
            // 
            resources.ApplyResources(tcPages, "tcPages");
            tcPages.Controls.Add(tpWelcome);
            tcPages.Controls.Add(tpMaster);
            tcPages.Name = "tcPages";
            tcPages.SelectedIndex = 0;
            tcPages.SizeMode = TabSizeMode.Fixed;
            tcPages.TabStop = false;
            // 
            // tpWelcome
            // 
            resources.ApplyResources(tpWelcome, "tpWelcome");
            tpWelcome.Controls.Add(btnMestre);
            tpWelcome.Controls.Add(lblBetter);
            tpWelcome.Controls.Add(lblWelcome);
            tpWelcome.Controls.Add(lblInfo);
            tpWelcome.Controls.Add(btnAprendiz);
            tpWelcome.Name = "tpWelcome";
            tpWelcome.UseVisualStyleBackColor = true;
            // 
            // tpMaster
            // 
            resources.ApplyResources(tpMaster, "tpMaster");
            tpMaster.Controls.Add(btnLogin);
            tpMaster.Controls.Add(lblLogin);
            tpMaster.Controls.Add(lblInfoMestre);
            tpMaster.Controls.Add(tbPassword);
            tpMaster.Name = "tpMaster";
            tpMaster.UseVisualStyleBackColor = true;
            // 
            // Welcome
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tcPages);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Welcome";
            tcPages.ResumeLayout(false);
            tpWelcome.ResumeLayout(false);
            tpWelcome.PerformLayout();
            tpMaster.ResumeLayout(false);
            tpMaster.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblWelcome;
        private Button btnAprendiz;
        private Button btnMestre;
        private Label lblInfo;
        private Label lblBetter;
        private Button btnLogin;
        private TextBox tbPassword;
        private Label lblInfoMestre;
        private Label lblLogin;
        private TabControl tcPages;
        private TabPage tpWelcome;
        private TabPage tpMaster;
        private RoundedButton btnBack;
    }
}