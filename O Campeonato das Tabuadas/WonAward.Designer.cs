
namespace O_Campeonato_das_Tabuadas
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnGood = new System.Windows.Forms.Button();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.lblText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(99, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(78, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Parabéns!";
            // 
            // btnGood
            // 
            this.btnGood.Location = new System.Drawing.Point(367, 59);
            this.btnGood.Name = "btnGood";
            this.btnGood.Size = new System.Drawing.Size(75, 23);
            this.btnGood.TabIndex = 1;
            this.btnGood.Text = "Boa!";
            this.btnGood.UseVisualStyleBackColor = true;
            this.btnGood.Click += new System.EventHandler(this.btnGood_Click);
            // 
            // pbIcon
            // 
            this.pbIcon.Location = new System.Drawing.Point(22, 22);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(60, 60);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIcon.TabIndex = 2;
            this.pbIcon.TabStop = false;
            // 
            // lblText
            // 
            this.lblText.Location = new System.Drawing.Point(100, 50);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(236, 30);
            this.lblText.TabIndex = 3;
            this.lblText.Text = "Parabéns, ganhas-te uma medalha! Podes vê-la mais tarde no menu medalhas.";
            // 
            // WonAward
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 102);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.pbIcon);
            this.Controls.Add(this.btnGood);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WonAward";
            this.Text = "Parabéns!";
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnGood;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Label lblText;
    }
}