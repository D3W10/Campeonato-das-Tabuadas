
namespace Campeonato_das_Tabuadas
{
    partial class WonAward
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WonAward));
            lblTitle = new System.Windows.Forms.Label();
            btnGood = new System.Windows.Forms.Button();
            pbIcon = new System.Windows.Forms.PictureBox();
            lblText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pbIcon).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitle.Location = new System.Drawing.Point(99, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(78, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Parabéns!";
            // 
            // btnGood
            // 
            btnGood.Location = new System.Drawing.Point(367, 59);
            btnGood.Name = "btnGood";
            btnGood.Size = new System.Drawing.Size(75, 23);
            btnGood.TabIndex = 1;
            btnGood.Text = "Boa!";
            btnGood.UseVisualStyleBackColor = true;
            btnGood.Click += btnGood_Click;
            // 
            // pbIcon
            // 
            pbIcon.Location = new System.Drawing.Point(22, 22);
            pbIcon.Name = "pbIcon";
            pbIcon.Size = new System.Drawing.Size(60, 60);
            pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbIcon.TabIndex = 2;
            pbIcon.TabStop = false;
            // 
            // lblText
            // 
            lblText.Location = new System.Drawing.Point(100, 50);
            lblText.Name = "lblText";
            lblText.Size = new System.Drawing.Size(236, 30);
            lblText.TabIndex = 3;
            lblText.Text = "Parabéns, ganhas-te uma medalha! Podes vê-la mais tarde no menu medalhas.";
            // 
            // WonAward
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(460, 102);
            Controls.Add(lblText);
            Controls.Add(pbIcon);
            Controls.Add(btnGood);
            Controls.Add(lblTitle);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "WonAward";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Parabéns!";
            ((System.ComponentModel.ISupportInitialize)pbIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnGood;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Label lblText;
    }
}