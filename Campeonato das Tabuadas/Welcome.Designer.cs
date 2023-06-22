
using System.Drawing;
using System.Windows.Forms;
using Campeonato_das_Tabuadas.Components;

namespace Campeonato_das_Tabuadas
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
            btnBack = new RoundedButton();
            tcPages.SuspendLayout();
            tpWelcome.SuspendLayout();
            tpMaster.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblWelcome.Location = new Point(7, 9);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(185, 45);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Bem-vindo";
            // 
            // btnAprendiz
            // 
            btnAprendiz.Anchor = AnchorStyles.Top;
            btnAprendiz.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAprendiz.Location = new Point(75, 136);
            btnAprendiz.Name = "btnAprendiz";
            btnAprendiz.Size = new Size(176, 46);
            btnAprendiz.TabIndex = 0;
            btnAprendiz.Text = "Aprendiz";
            btnAprendiz.UseVisualStyleBackColor = true;
            btnAprendiz.Click += btnAprendiz_Click;
            // 
            // btnMestre
            // 
            btnMestre.Anchor = AnchorStyles.Bottom;
            btnMestre.Location = new Point(88, 238);
            btnMestre.Name = "btnMestre";
            btnMestre.Size = new Size(150, 23);
            btnMestre.TabIndex = 1;
            btnMestre.Text = "Mestre";
            btnMestre.UseVisualStyleBackColor = true;
            btnMestre.Click += btnMestre_Click;
            // 
            // lblInfo
            // 
            lblInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblInfo.Location = new Point(12, 63);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(302, 43);
            lblInfo.TabIndex = 3;
            lblInfo.Text = "Bem-vindo ao Campeonato das Tabuadas, selecione uma opção de início de sessão:";
            // 
            // lblBetter
            // 
            lblBetter.Anchor = AnchorStyles.Bottom;
            lblBetter.Location = new Point(113, 218);
            lblBetter.Name = "lblBetter";
            lblBetter.Size = new Size(100, 15);
            lblBetter.TabIndex = 4;
            lblBetter.Text = "Ou ainda melhor:";
            lblBetter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Bottom;
            btnLogin.Location = new Point(88, 238);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(150, 23);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Iniciar Sessão";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(75, 136);
            tbPassword.Name = "tbPassword";
            tbPassword.ShortcutsEnabled = false;
            tbPassword.Size = new Size(176, 23);
            tbPassword.TabIndex = 2;
            tbPassword.UseSystemPasswordChar = true;
            tbPassword.KeyPress += tbPassword_KeyPress;
            // 
            // lblInfoMestre
            // 
            lblInfoMestre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblInfoMestre.AutoSize = true;
            lblInfoMestre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblInfoMestre.Location = new Point(12, 63);
            lblInfoMestre.Name = "lblInfoMestre";
            lblInfoMestre.Size = new Size(276, 21);
            lblInfoMestre.TabIndex = 6;
            lblInfoMestre.Text = "Olá mestre! Insira a sua palavra-passe:";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogin.Location = new Point(7, 9);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(221, 45);
            lblLogin.TabIndex = 6;
            lblLogin.Text = "Iniciar Sessão";
            // 
            // tcPages
            // 
            tcPages.Appearance = TabAppearance.FlatButtons;
            tcPages.Controls.Add(tpWelcome);
            tcPages.Controls.Add(tpMaster);
            tcPages.Dock = DockStyle.Fill;
            tcPages.Location = new Point(0, 0);
            tcPages.Name = "tcPages";
            tcPages.Padding = new Point(0, 0);
            tcPages.SelectedIndex = 0;
            tcPages.Size = new Size(334, 311);
            tcPages.SizeMode = TabSizeMode.Fixed;
            tcPages.TabIndex = 0;
            tcPages.TabStop = false;
            // 
            // tpWelcome
            // 
            tpWelcome.Controls.Add(btnMestre);
            tpWelcome.Controls.Add(lblBetter);
            tpWelcome.Controls.Add(lblWelcome);
            tpWelcome.Controls.Add(lblInfo);
            tpWelcome.Controls.Add(btnAprendiz);
            tpWelcome.Location = new Point(4, 27);
            tpWelcome.Name = "tpWelcome";
            tpWelcome.Padding = new Padding(3);
            tpWelcome.Size = new Size(326, 280);
            tpWelcome.TabIndex = 0;
            tpWelcome.Text = "Bem-vindo";
            tpWelcome.UseVisualStyleBackColor = true;
            // 
            // tpMaster
            // 
            tpMaster.Controls.Add(btnBack);
            tpMaster.Controls.Add(btnLogin);
            tpMaster.Controls.Add(lblLogin);
            tpMaster.Controls.Add(lblInfoMestre);
            tpMaster.Controls.Add(tbPassword);
            tpMaster.Location = new Point(4, 27);
            tpMaster.Name = "tpMaster";
            tpMaster.Padding = new Padding(3);
            tpMaster.Size = new Size(326, 280);
            tpMaster.TabIndex = 1;
            tpMaster.Text = "Mestre";
            tpMaster.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnBack.BackgroundImage = Properties.Resources.back;
            btnBack.BackgroundImageLayout = ImageLayout.Zoom;
            btnBack.BorderSize = 0;
            btnBack.Cursor = Cursors.Hand;
            btnBack.Location = new Point(8, 227);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(45, 45);
            btnBack.Click += btnBack_Click;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 311);
            Controls.Add(tcPages);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Welcome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bem-vindo";
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