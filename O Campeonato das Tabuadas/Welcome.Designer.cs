
namespace O_Campeonato_das_Tabuadas
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnAprendiz = new System.Windows.Forms.Button();
            this.btnMestre = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblBetter = new System.Windows.Forms.Label();
            this.pWelcome = new System.Windows.Forms.Panel();
            this.pLogin = new System.Windows.Forms.Panel();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblInfoMestre = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.pWelcome.SuspendLayout();
            this.pLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.Location = new System.Drawing.Point(7, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(185, 45);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Bem-vindo";
            // 
            // btnAprendiz
            // 
            this.btnAprendiz.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAprendiz.Location = new System.Drawing.Point(80, 136);
            this.btnAprendiz.Name = "btnAprendiz";
            this.btnAprendiz.Size = new System.Drawing.Size(175, 46);
            this.btnAprendiz.TabIndex = 1;
            this.btnAprendiz.Text = "Aprendiz";
            this.btnAprendiz.UseVisualStyleBackColor = true;
            this.btnAprendiz.Click += new System.EventHandler(this.btnAprendiz_Click);
            // 
            // btnMestre
            // 
            this.btnMestre.Location = new System.Drawing.Point(95, 259);
            this.btnMestre.Name = "btnMestre";
            this.btnMestre.Size = new System.Drawing.Size(150, 23);
            this.btnMestre.TabIndex = 2;
            this.btnMestre.Text = "Mestre";
            this.btnMestre.UseVisualStyleBackColor = true;
            this.btnMestre.Click += new System.EventHandler(this.btnMestre_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInfo.Location = new System.Drawing.Point(12, 63);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(310, 43);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "Bem-vindo ao Campeonato das Tabuadas, selecione uma opção de início de sessão:";
            // 
            // lblBetter
            // 
            this.lblBetter.AutoSize = true;
            this.lblBetter.Location = new System.Drawing.Point(120, 232);
            this.lblBetter.Name = "lblBetter";
            this.lblBetter.Size = new System.Drawing.Size(99, 15);
            this.lblBetter.TabIndex = 4;
            this.lblBetter.Text = "Ou ainda melhor:";
            // 
            // pWelcome
            // 
            this.pWelcome.Controls.Add(this.lblWelcome);
            this.pWelcome.Controls.Add(this.btnMestre);
            this.pWelcome.Controls.Add(this.lblBetter);
            this.pWelcome.Controls.Add(this.lblInfo);
            this.pWelcome.Controls.Add(this.btnAprendiz);
            this.pWelcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pWelcome.Location = new System.Drawing.Point(0, 0);
            this.pWelcome.Name = "pWelcome";
            this.pWelcome.Size = new System.Drawing.Size(334, 311);
            this.pWelcome.TabIndex = 5;
            // 
            // pLogin
            // 
            this.pLogin.Controls.Add(this.pbBack);
            this.pLogin.Controls.Add(this.btnLogin);
            this.pLogin.Controls.Add(this.tbPassword);
            this.pLogin.Controls.Add(this.lblInfoMestre);
            this.pLogin.Controls.Add(this.lblLogin);
            this.pLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pLogin.Location = new System.Drawing.Point(0, 0);
            this.pLogin.Name = "pLogin";
            this.pLogin.Size = new System.Drawing.Size(334, 311);
            this.pLogin.TabIndex = 5;
            // 
            // pbBack
            // 
            this.pbBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBack.Image = global::O_Campeonato_das_Tabuadas.Properties.Resources.back;
            this.pbBack.Location = new System.Drawing.Point(7, 254);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(50, 50);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBack.TabIndex = 9;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(95, 259);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(150, 23);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Iniciar Sessão";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(80, 136);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.ShortcutsEnabled = false;
            this.tbPassword.Size = new System.Drawing.Size(175, 23);
            this.tbPassword.TabIndex = 7;
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPassword_KeyPress);
            // 
            // lblInfoMestre
            // 
            this.lblInfoMestre.AutoSize = true;
            this.lblInfoMestre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInfoMestre.Location = new System.Drawing.Point(12, 63);
            this.lblInfoMestre.Name = "lblInfoMestre";
            this.lblInfoMestre.Size = new System.Drawing.Size(274, 21);
            this.lblInfoMestre.TabIndex = 6;
            this.lblInfoMestre.Text = "Olá mestre! Insira a sua Palavra-Passe:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogin.Location = new System.Drawing.Point(7, 9);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(221, 45);
            this.lblLogin.TabIndex = 6;
            this.lblLogin.Text = "Iniciar Sessão";
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.pWelcome);
            this.Controls.Add(this.pLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bem-vindo";
            this.pWelcome.ResumeLayout(false);
            this.pWelcome.PerformLayout();
            this.pLogin.ResumeLayout(false);
            this.pLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnAprendiz;
        private System.Windows.Forms.Button btnMestre;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblBetter;
        private System.Windows.Forms.Panel pWelcome;
        private System.Windows.Forms.Panel pLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblInfoMestre;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.PictureBox pbBack;
    }
}