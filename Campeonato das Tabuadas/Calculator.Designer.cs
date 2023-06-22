
using Campeonato_das_Tabuadas.Components;

namespace Campeonato_das_Tabuadas
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            lblDisplay = new System.Windows.Forms.Label();
            tlpToRight = new System.Windows.Forms.TableLayoutPanel();
            btnClear = new RoundedButton();
            btnDelete = new RoundedButton();
            btnPlusMinus = new RoundedButton();
            btnNum7 = new RoundedButton();
            btnNum8 = new RoundedButton();
            btnNum9 = new RoundedButton();
            btnTimes = new RoundedButton();
            btnNum4 = new RoundedButton();
            btnNum5 = new RoundedButton();
            btnNum6 = new RoundedButton();
            btnMinus = new RoundedButton();
            btnNum1 = new RoundedButton();
            btnNum2 = new RoundedButton();
            btnNum3 = new RoundedButton();
            btnPlus = new RoundedButton();
            btnEquals = new RoundedButton();
            btnPeriod = new RoundedButton();
            btnNum0 = new RoundedButton();
            ttOperator = new System.Windows.Forms.ToolTip(components);
            btnDivide = new RoundedButton();
            tlpToRight.SuspendLayout();
            SuspendLayout();
            // 
            // lblDisplay
            // 
            lblDisplay.Anchor = System.Windows.Forms.AnchorStyles.Right;
            lblDisplay.AutoSize = true;
            lblDisplay.Font = new System.Drawing.Font("Segoe UI Semibold", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblDisplay.Location = new System.Drawing.Point(176, 3);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new System.Drawing.Size(39, 46);
            lblDisplay.TabIndex = 0;
            lblDisplay.Text = "0";
            lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            lblDisplay.TextChanged += lblDisplay_TextChanged;
            // 
            // tlpToRight
            // 
            tlpToRight.ColumnCount = 1;
            tlpToRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpToRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpToRight.Controls.Add(lblDisplay, 0, 0);
            tlpToRight.Location = new System.Drawing.Point(12, 12);
            tlpToRight.Name = "tlpToRight";
            tlpToRight.RowCount = 1;
            tlpToRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpToRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpToRight.Size = new System.Drawing.Size(218, 52);
            tlpToRight.TabIndex = 0;
            // 
            // btnClear
            // 
            btnClear.BackColor = System.Drawing.SystemColors.Control;
            btnClear.BackgroundImage = Properties.Resources.clear;
            btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnClear.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            btnClear.BorderRadius = 10;
            btnClear.BorderSize = 0;
            btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClear.ForeColor = System.Drawing.SystemColors.ControlText;
            btnClear.Location = new System.Drawing.Point(12, 82);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(50, 50);
            btnClear.TabIndex = 0;
            ttOperator.SetToolTip(btnClear, "Limpar");
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            btnClear.PreviewKeyDown += ButtonsPreviewKeyDown;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = System.Drawing.SystemColors.Control;
            btnDelete.BackgroundImage = Properties.Resources.delete;
            btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnDelete.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            btnDelete.BorderRadius = 10;
            btnDelete.BorderSize = 0;
            btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            btnDelete.Location = new System.Drawing.Point(68, 82);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(50, 50);
            btnDelete.TabIndex = 1;
            ttOperator.SetToolTip(btnDelete, "Apagar");
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            btnDelete.PreviewKeyDown += ButtonsPreviewKeyDown;
            // 
            // btnPlusMinus
            // 
            btnPlusMinus.BackColor = System.Drawing.SystemColors.Control;
            btnPlusMinus.BackgroundImage = Properties.Resources.plusMinus;
            btnPlusMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnPlusMinus.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            btnPlusMinus.BorderRadius = 10;
            btnPlusMinus.BorderSize = 0;
            btnPlusMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            btnPlusMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPlusMinus.ForeColor = System.Drawing.SystemColors.ControlText;
            btnPlusMinus.Location = new System.Drawing.Point(124, 82);
            btnPlusMinus.Name = "btnPlusMinus";
            btnPlusMinus.Size = new System.Drawing.Size(50, 50);
            btnPlusMinus.TabIndex = 2;
            ttOperator.SetToolTip(btnPlusMinus, "Simétrico");
            btnPlusMinus.UseVisualStyleBackColor = false;
            btnPlusMinus.Click += btnPlusMinus_Click;
            btnPlusMinus.PreviewKeyDown += ButtonsPreviewKeyDown;
            // 
            // btnNum7
            // 
            btnNum7.BackColor = System.Drawing.SystemColors.Control;
            btnNum7.BackgroundImage = Properties.Resources.tabuada7;
            btnNum7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnNum7.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            btnNum7.BorderRadius = 10;
            btnNum7.BorderSize = 0;
            btnNum7.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNum7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNum7.ForeColor = System.Drawing.SystemColors.ControlText;
            btnNum7.Location = new System.Drawing.Point(12, 138);
            btnNum7.Name = "btnNum7";
            btnNum7.Size = new System.Drawing.Size(50, 50);
            btnNum7.TabIndex = 4;
            btnNum7.UseVisualStyleBackColor = false;
            btnNum7.Click += btnNum7_Click;
            btnNum7.PreviewKeyDown += ButtonsPreviewKeyDown;
            // 
            // btnNum8
            // 
            btnNum8.BackColor = System.Drawing.SystemColors.Control;
            btnNum8.BackgroundImage = Properties.Resources.tabuada8;
            btnNum8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnNum8.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            btnNum8.BorderRadius = 10;
            btnNum8.BorderSize = 0;
            btnNum8.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNum8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNum8.ForeColor = System.Drawing.SystemColors.ControlText;
            btnNum8.Location = new System.Drawing.Point(68, 138);
            btnNum8.Name = "btnNum8";
            btnNum8.Size = new System.Drawing.Size(50, 50);
            btnNum8.TabIndex = 5;
            btnNum8.UseVisualStyleBackColor = false;
            btnNum8.Click += btnNum8_Click;
            btnNum8.PreviewKeyDown += ButtonsPreviewKeyDown;
            // 
            // btnNum9
            // 
            btnNum9.BackColor = System.Drawing.SystemColors.Control;
            btnNum9.BackgroundImage = Properties.Resources.tabuada9;
            btnNum9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnNum9.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            btnNum9.BorderRadius = 10;
            btnNum9.BorderSize = 0;
            btnNum9.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNum9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNum9.ForeColor = System.Drawing.SystemColors.ControlText;
            btnNum9.Location = new System.Drawing.Point(124, 138);
            btnNum9.Name = "btnNum9";
            btnNum9.Size = new System.Drawing.Size(50, 50);
            btnNum9.TabIndex = 6;
            btnNum9.UseVisualStyleBackColor = false;
            btnNum9.Click += btnNum9_Click;
            btnNum9.PreviewKeyDown += ButtonsPreviewKeyDown;
            // 
            // btnTimes
            // 
            btnTimes.BackColor = System.Drawing.SystemColors.Control;
            btnTimes.BackgroundImage = Properties.Resources.times;
            btnTimes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnTimes.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            btnTimes.BorderRadius = 10;
            btnTimes.BorderSize = 0;
            btnTimes.Cursor = System.Windows.Forms.Cursors.Hand;
            btnTimes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTimes.ForeColor = System.Drawing.SystemColors.ControlText;
            btnTimes.Location = new System.Drawing.Point(180, 138);
            btnTimes.Name = "btnTimes";
            btnTimes.Size = new System.Drawing.Size(50, 50);
            btnTimes.TabIndex = 7;
            ttOperator.SetToolTip(btnTimes, "Multiplicar");
            btnTimes.UseVisualStyleBackColor = false;
            btnTimes.Click += btnTimes_Click;
            btnTimes.PreviewKeyDown += ButtonsPreviewKeyDown;
            // 
            // btnNum4
            // 
            btnNum4.BackColor = System.Drawing.SystemColors.Control;
            btnNum4.BackgroundImage = Properties.Resources.tabuada4;
            btnNum4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnNum4.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            btnNum4.BorderRadius = 10;
            btnNum4.BorderSize = 0;
            btnNum4.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNum4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNum4.ForeColor = System.Drawing.SystemColors.ControlText;
            btnNum4.Location = new System.Drawing.Point(12, 194);
            btnNum4.Name = "btnNum4";
            btnNum4.Size = new System.Drawing.Size(50, 50);
            btnNum4.TabIndex = 8;
            btnNum4.UseVisualStyleBackColor = false;
            btnNum4.Click += btnNum4_Click;
            btnNum4.PreviewKeyDown += ButtonsPreviewKeyDown;
            // 
            // btnNum5
            // 
            btnNum5.BackColor = System.Drawing.SystemColors.Control;
            btnNum5.BackgroundImage = Properties.Resources.tabuada5;
            btnNum5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnNum5.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            btnNum5.BorderRadius = 10;
            btnNum5.BorderSize = 0;
            btnNum5.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNum5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNum5.ForeColor = System.Drawing.SystemColors.ControlText;
            btnNum5.Location = new System.Drawing.Point(68, 195);
            btnNum5.Name = "btnNum5";
            btnNum5.Size = new System.Drawing.Size(50, 50);
            btnNum5.TabIndex = 9;
            btnNum5.UseVisualStyleBackColor = false;
            btnNum5.Click += btnNum5_Click;
            btnNum5.PreviewKeyDown += ButtonsPreviewKeyDown;
            // 
            // btnNum6
            // 
            btnNum6.BackColor = System.Drawing.SystemColors.Control;
            btnNum6.BackgroundImage = Properties.Resources.tabuada6;
            btnNum6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnNum6.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            btnNum6.BorderRadius = 10;
            btnNum6.BorderSize = 0;
            btnNum6.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNum6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNum6.ForeColor = System.Drawing.SystemColors.ControlText;
            btnNum6.Location = new System.Drawing.Point(124, 194);
            btnNum6.Name = "btnNum6";
            btnNum6.Size = new System.Drawing.Size(50, 50);
            btnNum6.TabIndex = 10;
            btnNum6.UseVisualStyleBackColor = false;
            btnNum6.Click += btnNum6_Click;
            btnNum6.PreviewKeyDown += ButtonsPreviewKeyDown;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = System.Drawing.SystemColors.Control;
            btnMinus.BackgroundImage = Properties.Resources.minus;
            btnMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnMinus.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            btnMinus.BorderRadius = 10;
            btnMinus.BorderSize = 0;
            btnMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMinus.ForeColor = System.Drawing.SystemColors.ControlText;
            btnMinus.Location = new System.Drawing.Point(180, 194);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new System.Drawing.Size(50, 50);
            btnMinus.TabIndex = 11;
            ttOperator.SetToolTip(btnMinus, "Subtrair");
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            btnMinus.PreviewKeyDown += ButtonsPreviewKeyDown;
            // 
            // btnNum1
            // 
            btnNum1.BackColor = System.Drawing.SystemColors.Control;
            btnNum1.BackgroundImage = Properties.Resources.tabuada1;
            btnNum1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnNum1.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            btnNum1.BorderRadius = 10;
            btnNum1.BorderSize = 0;
            btnNum1.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNum1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNum1.ForeColor = System.Drawing.SystemColors.ControlText;
            btnNum1.Location = new System.Drawing.Point(12, 251);
            btnNum1.Name = "btnNum1";
            btnNum1.Size = new System.Drawing.Size(50, 50);
            btnNum1.TabIndex = 12;
            btnNum1.UseVisualStyleBackColor = false;
            btnNum1.Click += btnNum1_Click;
            btnNum1.PreviewKeyDown += ButtonsPreviewKeyDown;
            // 
            // btnNum2
            // 
            btnNum2.BackColor = System.Drawing.SystemColors.Control;
            btnNum2.BackgroundImage = Properties.Resources.tabuada2;
            btnNum2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnNum2.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            btnNum2.BorderRadius = 10;
            btnNum2.BorderSize = 0;
            btnNum2.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNum2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNum2.ForeColor = System.Drawing.SystemColors.ControlText;
            btnNum2.Location = new System.Drawing.Point(68, 251);
            btnNum2.Name = "btnNum2";
            btnNum2.Size = new System.Drawing.Size(50, 50);
            btnNum2.TabIndex = 13;
            btnNum2.UseVisualStyleBackColor = false;
            btnNum2.Click += btnNum2_Click;
            btnNum2.PreviewKeyDown += ButtonsPreviewKeyDown;
            // 
            // btnNum3
            // 
            btnNum3.BackColor = System.Drawing.SystemColors.Control;
            btnNum3.BackgroundImage = Properties.Resources.tabuada3;
            btnNum3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnNum3.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            btnNum3.BorderRadius = 10;
            btnNum3.BorderSize = 0;
            btnNum3.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNum3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNum3.ForeColor = System.Drawing.SystemColors.ControlText;
            btnNum3.Location = new System.Drawing.Point(124, 251);
            btnNum3.Name = "btnNum3";
            btnNum3.Size = new System.Drawing.Size(50, 50);
            btnNum3.TabIndex = 14;
            btnNum3.UseVisualStyleBackColor = false;
            btnNum3.Click += btnNum3_Click;
            btnNum3.PreviewKeyDown += ButtonsPreviewKeyDown;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = System.Drawing.SystemColors.Control;
            btnPlus.BackgroundImage = Properties.Resources.plus;
            btnPlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnPlus.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            btnPlus.BorderRadius = 10;
            btnPlus.BorderSize = 0;
            btnPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPlus.ForeColor = System.Drawing.SystemColors.ControlText;
            btnPlus.Location = new System.Drawing.Point(180, 251);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new System.Drawing.Size(50, 50);
            btnPlus.TabIndex = 15;
            ttOperator.SetToolTip(btnPlus, "Somar");
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            btnPlus.PreviewKeyDown += ButtonsPreviewKeyDown;
            // 
            // btnEquals
            // 
            btnEquals.BackColor = System.Drawing.SystemColors.Control;
            btnEquals.BackgroundImage = Properties.Resources.result;
            btnEquals.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnEquals.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            btnEquals.BorderRadius = 10;
            btnEquals.BorderSize = 0;
            btnEquals.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEquals.ForeColor = System.Drawing.SystemColors.ControlText;
            btnEquals.Location = new System.Drawing.Point(180, 307);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new System.Drawing.Size(50, 50);
            btnEquals.TabIndex = 18;
            ttOperator.SetToolTip(btnEquals, "Igual");
            btnEquals.UseVisualStyleBackColor = false;
            btnEquals.Click += btnEquals_Click;
            btnEquals.PreviewKeyDown += ButtonsPreviewKeyDown;
            // 
            // btnPeriod
            // 
            btnPeriod.BackColor = System.Drawing.SystemColors.Control;
            btnPeriod.BackgroundImage = Properties.Resources.period;
            btnPeriod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnPeriod.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            btnPeriod.BorderRadius = 10;
            btnPeriod.BorderSize = 0;
            btnPeriod.Cursor = System.Windows.Forms.Cursors.Hand;
            btnPeriod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPeriod.ForeColor = System.Drawing.SystemColors.ControlText;
            btnPeriod.Location = new System.Drawing.Point(124, 307);
            btnPeriod.Name = "btnPeriod";
            btnPeriod.Size = new System.Drawing.Size(50, 50);
            btnPeriod.TabIndex = 17;
            btnPeriod.UseVisualStyleBackColor = false;
            btnPeriod.Click += btnPeriod_Click;
            btnPeriod.PreviewKeyDown += ButtonsPreviewKeyDown;
            // 
            // btnNum0
            // 
            btnNum0.BackColor = System.Drawing.SystemColors.Control;
            btnNum0.BackgroundImage = Properties.Resources.btn0;
            btnNum0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnNum0.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            btnNum0.BorderRadius = 10;
            btnNum0.BorderSize = 0;
            btnNum0.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNum0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNum0.ForeColor = System.Drawing.SystemColors.ControlText;
            btnNum0.Location = new System.Drawing.Point(12, 307);
            btnNum0.Name = "btnNum0";
            btnNum0.Size = new System.Drawing.Size(106, 50);
            btnNum0.TabIndex = 16;
            btnNum0.UseVisualStyleBackColor = false;
            btnNum0.Click += btnNum0_Click;
            btnNum0.PreviewKeyDown += ButtonsPreviewKeyDown;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = System.Drawing.SystemColors.Control;
            btnDivide.BackgroundImage = Properties.Resources.divide;
            btnDivide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnDivide.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            btnDivide.BorderRadius = 10;
            btnDivide.BorderSize = 0;
            btnDivide.Cursor = System.Windows.Forms.Cursors.Hand;
            btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDivide.ForeColor = System.Drawing.SystemColors.ControlText;
            btnDivide.Location = new System.Drawing.Point(180, 82);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new System.Drawing.Size(50, 50);
            btnDivide.TabIndex = 3;
            ttOperator.SetToolTip(btnDivide, "Dividir");
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnDivide_Click;
            btnDivide.PreviewKeyDown += ButtonsPreviewKeyDown;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(242, 369);
            Controls.Add(btnDivide);
            Controls.Add(btnNum0);
            Controls.Add(btnPeriod);
            Controls.Add(btnEquals);
            Controls.Add(btnPlus);
            Controls.Add(btnNum3);
            Controls.Add(btnNum2);
            Controls.Add(btnNum1);
            Controls.Add(btnMinus);
            Controls.Add(btnNum6);
            Controls.Add(btnNum5);
            Controls.Add(btnNum4);
            Controls.Add(btnTimes);
            Controls.Add(btnNum9);
            Controls.Add(btnNum8);
            Controls.Add(btnNum7);
            Controls.Add(btnPlusMinus);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(tlpToRight);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Calculator";
            Text = "Calculadora";
            KeyPress += Calculator_KeyPress;
            tlpToRight.ResumeLayout(false);
            tlpToRight.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.TableLayoutPanel tlpToRight;
        private RoundedButton btnClear;
        private RoundedButton btnDelete;
        private RoundedButton btnPlusMinus;
        private RoundedButton btnNum7;
        private RoundedButton btnNum8;
        private RoundedButton btnNum9;
        private RoundedButton btnTimes;
        private RoundedButton btnNum4;
        private RoundedButton btnNum5;
        private RoundedButton btnNum6;
        private RoundedButton btnMinus;
        private RoundedButton btnNum1;
        private RoundedButton btnNum2;
        private RoundedButton btnNum3;
        private RoundedButton btnPlus;
        private RoundedButton btnEquals;
        private RoundedButton btnPeriod;
        private RoundedButton btnNum0;
        private System.Windows.Forms.ToolTip ttOperator;
        private RoundedButton btnDivide;
    }
}