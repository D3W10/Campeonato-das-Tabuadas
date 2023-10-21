
namespace Multiplication_Championship
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
            resources.ApplyResources(lblTitle, "lblTitle");
            lblTitle.Name = "lblTitle";
            // 
            // btnGood
            // 
            resources.ApplyResources(btnGood, "btnGood");
            btnGood.Name = "btnGood";
            btnGood.UseVisualStyleBackColor = true;
            btnGood.Click += btnGood_Click;
            // 
            // pbIcon
            // 
            resources.ApplyResources(pbIcon, "pbIcon");
            pbIcon.Name = "pbIcon";
            pbIcon.TabStop = false;
            // 
            // lblText
            // 
            resources.ApplyResources(lblText, "lblText");
            lblText.Name = "lblText";
            // 
            // WonAward
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(lblText);
            Controls.Add(pbIcon);
            Controls.Add(btnGood);
            Controls.Add(lblTitle);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "WonAward";
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