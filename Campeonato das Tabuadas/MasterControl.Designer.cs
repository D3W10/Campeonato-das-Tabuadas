
using Campeonato_das_Tabuadas.Components;

namespace Campeonato_das_Tabuadas
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
            btnPoints.Location = new System.Drawing.Point(12, 65);
            btnPoints.Name = "btnPoints";
            btnPoints.Size = new System.Drawing.Size(280, 50);
            btnPoints.TabIndex = 0;
            btnPoints.Text = "Reiniciar registo de corretas/erradas";
            ttExplain.SetToolTip(btnPoints, "Reinicia as contagens de perguntas corretas e erradas");
            btnPoints.UseVisualStyleBackColor = true;
            btnPoints.Click += btnPoints_Click;
            // 
            // btnAwards
            // 
            btnAwards.Location = new System.Drawing.Point(12, 121);
            btnAwards.Name = "btnAwards";
            btnAwards.Size = new System.Drawing.Size(280, 50);
            btnAwards.TabIndex = 1;
            btnAwards.Text = "Remover todas as medalhas";
            ttExplain.SetToolTip(btnAwards, "Remove todas as medalhas obtidas");
            btnAwards.UseVisualStyleBackColor = true;
            btnAwards.Click += btnAwards_Click;
            // 
            // btnShuffle
            // 
            btnShuffle.Location = new System.Drawing.Point(12, 177);
            btnShuffle.Name = "btnShuffle";
            btnShuffle.Size = new System.Drawing.Size(280, 50);
            btnShuffle.TabIndex = 2;
            btnShuffle.Text = "Sempre aleatório";
            ttExplain.SetToolTip(btnShuffle, "Força todos os jogos a usarem a opção aleatório");
            btnShuffle.UseVisualStyleBackColor = true;
            btnShuffle.Click += btnShuffle_Click;
            // 
            // btnComutative
            // 
            btnComutative.Location = new System.Drawing.Point(12, 233);
            btnComutative.Name = "btnComutative";
            btnComutative.Size = new System.Drawing.Size(280, 50);
            btnComutative.TabIndex = 3;
            btnComutative.Text = "Sempre comutativa";
            ttExplain.SetToolTip(btnComutative, "Força todos os jogos a usarem a opção comutativa");
            btnComutative.UseVisualStyleBackColor = true;
            btnComutative.Click += btnComutative_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitle.Location = new System.Drawing.Point(7, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(266, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Controlo Mestre";
            // 
            // btnDestroy
            // 
            btnDestroy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnDestroy.ForeColor = System.Drawing.Color.Red;
            btnDestroy.Location = new System.Drawing.Point(12, 289);
            btnDestroy.Name = "btnDestroy";
            btnDestroy.Size = new System.Drawing.Size(280, 50);
            btnDestroy.TabIndex = 4;
            btnDestroy.Text = "Remover completamente o registo!";
            ttExplain.SetToolTip(btnDestroy, "Remove todos os dados e configurações da aplicação");
            btnDestroy.UseVisualStyleBackColor = true;
            btnDestroy.Click += btnDestroy_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnBack.BackColor = System.Drawing.SystemColors.Control;
            btnBack.BackgroundImage = Properties.Resources.back;
            btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnBack.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            btnBack.BorderRadius = 10;
            btnBack.BorderSize = 0;
            btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBack.ForeColor = System.Drawing.SystemColors.ControlText;
            btnBack.Location = new System.Drawing.Point(6, 360);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(45, 45);
            btnBack.TabIndex = 5;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // MasterControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(304, 411);
            Controls.Add(btnBack);
            Controls.Add(btnDestroy);
            Controls.Add(lblTitle);
            Controls.Add(btnComutative);
            Controls.Add(btnShuffle);
            Controls.Add(btnAwards);
            Controls.Add(btnPoints);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MasterControl";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Controlo Mestre";
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