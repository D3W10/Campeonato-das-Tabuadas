
namespace O_Campeonato_das_Tabuadas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterControl));
            this.btnPoints = new System.Windows.Forms.Button();
            this.btnAwards = new System.Windows.Forms.Button();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.btnComutative = new System.Windows.Forms.Button();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDestroy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPoints
            // 
            this.btnPoints.Location = new System.Drawing.Point(12, 65);
            this.btnPoints.Name = "btnPoints";
            this.btnPoints.Size = new System.Drawing.Size(280, 50);
            this.btnPoints.TabIndex = 0;
            this.btnPoints.Text = "Reiniciar registo de Corretas/Erradas";
            this.btnPoints.UseVisualStyleBackColor = true;
            this.btnPoints.Click += new System.EventHandler(this.btnPoints_Click);
            // 
            // btnAwards
            // 
            this.btnAwards.Location = new System.Drawing.Point(12, 121);
            this.btnAwards.Name = "btnAwards";
            this.btnAwards.Size = new System.Drawing.Size(280, 50);
            this.btnAwards.TabIndex = 1;
            this.btnAwards.Text = "Remover todas as medalhas";
            this.btnAwards.UseVisualStyleBackColor = true;
            this.btnAwards.Click += new System.EventHandler(this.btnAwards_Click);
            // 
            // btnShuffle
            // 
            this.btnShuffle.Location = new System.Drawing.Point(12, 177);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(280, 50);
            this.btnShuffle.TabIndex = 2;
            this.btnShuffle.Text = "Sempre Aleatório";
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnComutative
            // 
            this.btnComutative.Location = new System.Drawing.Point(12, 233);
            this.btnComutative.Name = "btnComutative";
            this.btnComutative.Size = new System.Drawing.Size(280, 50);
            this.btnComutative.TabIndex = 3;
            this.btnComutative.Text = "Sempre Comutativa";
            this.btnComutative.UseVisualStyleBackColor = true;
            this.btnComutative.Click += new System.EventHandler(this.btnComutative_Click);
            // 
            // pbBack
            // 
            this.pbBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBack.Image = global::O_Campeonato_das_Tabuadas.Properties.Resources.back;
            this.pbBack.Location = new System.Drawing.Point(6, 355);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(50, 50);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBack.TabIndex = 7;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(6, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(266, 45);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Controlo Mestre";
            // 
            // btnDestroy
            // 
            this.btnDestroy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDestroy.ForeColor = System.Drawing.Color.Red;
            this.btnDestroy.Location = new System.Drawing.Point(12, 289);
            this.btnDestroy.Name = "btnDestroy";
            this.btnDestroy.Size = new System.Drawing.Size(280, 50);
            this.btnDestroy.TabIndex = 10;
            this.btnDestroy.Text = "Remover completamente o registo!";
            this.btnDestroy.UseVisualStyleBackColor = true;
            this.btnDestroy.Click += new System.EventHandler(this.btnDestroy_Click);
            // 
            // MasterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 411);
            this.Controls.Add(this.btnDestroy);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.btnComutative);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.btnAwards);
            this.Controls.Add(this.btnPoints);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MasterControl";
            this.Text = "Controlo Mestre";
            this.Load += new System.EventHandler(this.MasterControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPoints;
        private System.Windows.Forms.Button btnAwards;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Button btnComutative;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDestroy;
    }
}