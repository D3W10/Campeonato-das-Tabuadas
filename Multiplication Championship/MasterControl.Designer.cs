
using Multiplication_Championship.Components;

namespace Multiplication_Championship
{
    partial class MasterControl
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterControl));
            btnPoints = new System.Windows.Forms.Button();
            btnAwards = new System.Windows.Forms.Button();
            btnShuffle = new System.Windows.Forms.Button();
            btnComutative = new System.Windows.Forms.Button();
            lblTitle = new System.Windows.Forms.Label();
            btnDestroy = new System.Windows.Forms.Button();
            ttExplain = new System.Windows.Forms.ToolTip(components);
            btnBack = new RoundedButton();
            SuspendLayout();
            // 
            // btnPoints
            // 
            resources.ApplyResources(btnPoints, "btnPoints");
            btnPoints.Name = "btnPoints";
            ttExplain.SetToolTip(btnPoints, resources.GetString("btnPoints.ToolTip"));
            btnPoints.UseVisualStyleBackColor = true;
            btnPoints.Click += btnPoints_Click;
            // 
            // btnAwards
            // 
            resources.ApplyResources(btnAwards, "btnAwards");
            btnAwards.Name = "btnAwards";
            ttExplain.SetToolTip(btnAwards, resources.GetString("btnAwards.ToolTip"));
            btnAwards.UseVisualStyleBackColor = true;
            btnAwards.Click += btnAwards_Click;
            // 
            // btnShuffle
            // 
            resources.ApplyResources(btnShuffle, "btnShuffle");
            btnShuffle.Name = "btnShuffle";
            ttExplain.SetToolTip(btnShuffle, resources.GetString("btnShuffle.ToolTip"));
            btnShuffle.UseVisualStyleBackColor = true;
            btnShuffle.Click += btnShuffle_Click;
            // 
            // btnComutative
            // 
            resources.ApplyResources(btnComutative, "btnComutative");
            btnComutative.Name = "btnComutative";
            ttExplain.SetToolTip(btnComutative, resources.GetString("btnComutative.ToolTip"));
            btnComutative.UseVisualStyleBackColor = true;
            btnComutative.Click += btnComutative_Click;
            // 
            // lblTitle
            // 
            resources.ApplyResources(lblTitle, "lblTitle");
            lblTitle.Name = "lblTitle";
            // 
            // btnDestroy
            // 
            resources.ApplyResources(btnDestroy, "btnDestroy");
            btnDestroy.ForeColor = System.Drawing.Color.Red;
            btnDestroy.Name = "btnDestroy";
            ttExplain.SetToolTip(btnDestroy, resources.GetString("btnDestroy.ToolTip"));
            btnDestroy.UseVisualStyleBackColor = true;
            btnDestroy.Click += btnDestroy_Click;
            // 
            // btnBack
            // 
            resources.ApplyResources(btnBack, "btnBack");
            btnBack.BackColor = System.Drawing.SystemColors.Control;
            btnBack.BackgroundImage = Properties.Resources.back;
            btnBack.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            btnBack.BorderRadius = 10;
            btnBack.BorderSize = 0;
            btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            btnBack.ForeColor = System.Drawing.SystemColors.ControlText;
            btnBack.Name = "btnBack";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // MasterControl
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(btnBack);
            Controls.Add(btnDestroy);
            Controls.Add(lblTitle);
            Controls.Add(btnComutative);
            Controls.Add(btnShuffle);
            Controls.Add(btnAwards);
            Controls.Add(btnPoints);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MasterControl";
            Load += MasterControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnPoints;
        private System.Windows.Forms.Button btnAwards;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Button btnComutative;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDestroy;
        private System.Windows.Forms.ToolTip ttExplain;
        private RoundedButton btnBack;
    }
}