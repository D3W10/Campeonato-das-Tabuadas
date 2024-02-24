
using Multiplication_Championship.Components;

namespace Multiplication_Championship
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
            resources.ApplyResources(lblDisplay, "lblDisplay");
            lblDisplay.Name = "lblDisplay";
            lblDisplay.TextChanged += lblDisplay_TextChanged;
            // 
            // tlpToRight
            // 
            resources.ApplyResources(tlpToRight, "tlpToRight");
            tlpToRight.Controls.Add(lblDisplay, 0, 0);
            tlpToRight.Name = "tlpToRight";
            // 
            // btnClear
            // 
            resources.ApplyResources(btnClear, "btnClear");
            btnClear.BackColor = System.Drawing.SystemColors.Control;
            btnClear.BackgroundImage = Properties.Resources.clear;
            btnClear.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            btnClear.BorderRadius = 10;
            btnClear.BorderSize = 0;
            btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            btnClear.ForeColor = System.Drawing.SystemColors.ControlText;
            btnClear.Name = "btnClear";
            ttOperator.SetToolTip(btnClear, resources.GetString("btnClear.ToolTip"));
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            btnClear.PreviewKeyDown += ButtonsPreviewKeyDown;
            // 
            // btnDelete
            // 
            resources.ApplyResources(btnDelete, "btnDelete");
            btnDelete.BackColor = System.Drawing.SystemColors.Control;
            btnDelete.BackgroundImage = Properties.Resources.delete;
            btnDelete.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            btnDelete.BorderRadius = 10;
            btnDelete.BorderSize = 0;
            btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            btnDelete.Name = "btnDelete";
            ttOperator.SetToolTip(btnDelete, resources.GetString("btnDelete.ToolTip"));
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            btnDelete.PreviewKeyDown += ButtonsPreviewKeyDown;
            // 
            // btnPlusMinus
            // 
            resources.ApplyResources(btnPlusMinus, "btnPlusMinus");
            btnPlusMinus.BackColor = System.Drawing.SystemColors.Control;
            btnPlusMinus.BackgroundImage = Properties.Resources.plusMinus;
            btnPlusMinus.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            btnPlusMinus.BorderRadius = 10;
            btnPlusMinus.BorderSize = 0;
            btnPlusMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            btnPlusMinus.ForeColor = System.Drawing.SystemColors.ControlText;
            btnPlusMinus.Name = "btnPlusMinus";
            ttOperator.SetToolTip(btnPlusMinus, resources.GetString("btnPlusMinus.ToolTip"));
            btnPlusMinus.UseVisualStyleBackColor = false;
            btnPlusMinus.Click += btnPlusMinus_Click;
            btnPlusMinus.PreviewKeyDown += ButtonsPreviewKeyDown;
            // 
            // btnNum7
            // 
            resources.ApplyResources(btnNum7, "btnNum7");
            btnNum7.BackColor = System.Drawing.SystemColors.Control;
            btnNum7.BackgroundImage = Properties.Resources.tabuada7;
            btnNum7.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            btnNum7.BorderRadius = 10;
            btnNum7.BorderSize = 0;
            btnNum7.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNum7.ForeColor = System.Drawing.SystemColors.ControlText;
            btnNum7.Name = "btnNum7";
            btnNum7.UseVisualStyleBackColor = false;
            btnNum7.Click += btnNum7_Click;
            btnNum7.PreviewKeyDown += ButtonsPreviewKeyDown;
            // 
            // btnNum8
            // 
            resources.ApplyResources(btnNum8, "btnNum8");
            btnNum8.BackColor = System.Drawing.SystemColors.Control;
            btnNum8.BackgroundImage = Properties.Resources.tabuada8;
            btnNum8.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            btnNum8.BorderRadius = 10;
            btnNum8.BorderSize = 0;
            btnNum8.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNum8.ForeColor = System.Drawing.SystemColors.ControlText;
            btnNum8.Name = "btnNum8";
            btnNum8.UseVisualStyleBackColor = false;
            btnNum8.Click += btnNum8_Click;
            btnNum8.PreviewKeyDown += ButtonsPreviewKeyDown;
            // 
            // btnNum9
            // 
            resources.ApplyResources(btnNum9, "btnNum9");
            btnNum9.BackColor = System.Drawing.SystemColors.Control;
            btnNum9.BackgroundImage = Properties.Resources.tabuada9;
            btnNum9.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            btnNum9.BorderRadius = 10;
            btnNum9.BorderSize = 0;
            btnNum9.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNum9.ForeColor = System.Drawing.SystemColors.ControlText;
            btnNum9.Name = "btnNum9";
            btnNum9.UseVisualStyleBackColor = false;
            btnNum9.Click += btnNum9_Click;
            btnNum9.PreviewKeyDown += ButtonsPreviewKeyDown;
            // 
            // btnTimes
            // 
            resources.ApplyResources(btnTimes, "btnTimes");
            btnTimes.BackColor = System.Drawing.SystemColors.Control;
            btnTimes.BackgroundImage = Properties.Resources.times;
            btnTimes.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            btnTimes.BorderRadius = 10;
            btnTimes.BorderSize = 0;
            btnTimes.Cursor = System.Windows.Forms.Cursors.Hand;
            btnTimes.ForeColor = System.Drawing.SystemColors.ControlText;
            btnTimes.Name = "btnTimes";
            ttOperator.SetToolTip(btnTimes, resources.GetString("btnTimes.ToolTip"));
            btnTimes.UseVisualStyleBackColor = false;
            btnTimes.Click += btnTimes_Click;
            btnTimes.PreviewKeyDown += ButtonsPreviewKeyDown;
            // 
            // btnNum4
            // 
            resources.ApplyResources(btnNum4, "btnNum4");
            btnNum4.BackColor = System.Drawing.SystemColors.Control;
            btnNum4.BackgroundImage = Properties.Resources.tabuada4;
            btnNum4.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            btnNum4.BorderRadius = 10;
            btnNum4.BorderSize = 0;
            btnNum4.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNum4.ForeColor = System.Drawing.SystemColors.ControlText;
            btnNum4.Name = "btnNum4";
            btnNum4.UseVisualStyleBackColor = false;
            btnNum4.Click += btnNum4_Click;
            btnNum4.PreviewKeyDown += ButtonsPreviewKeyDown;
            // 
            // btnNum5
            // 
            resources.ApplyResources(btnNum5, "btnNum5");
            btnNum5.BackColor = System.Drawing.SystemColors.Control;
            btnNum5.BackgroundImage = Properties.Resources.tabuada5;
            btnNum5.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            btnNum5.BorderRadius = 10;
            btnNum5.BorderSize = 0;
            btnNum5.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNum5.ForeColor = System.Drawing.SystemColors.ControlText;
            btnNum5.Name = "btnNum5";
            btnNum5.UseVisualStyleBackColor = false;
            btnNum5.Click += btnNum5_Click;
            btnNum5.PreviewKeyDown += ButtonsPreviewKeyDown;
            // 
            // btnNum6
            // 
            resources.ApplyResources(btnNum6, "btnNum6");
            btnNum6.BackColor = System.Drawing.SystemColors.Control;
            btnNum6.BackgroundImage = Properties.Resources.tabuada6;
            btnNum6.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            btnNum6.BorderRadius = 10;
            btnNum6.BorderSize = 0;
            btnNum6.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNum6.ForeColor = System.Drawing.SystemColors.ControlText;
            btnNum6.Name = "btnNum6";
            btnNum6.UseVisualStyleBackColor = false;
            btnNum6.Click += btnNum6_Click;
            btnNum6.PreviewKeyDown += ButtonsPreviewKeyDown;
            // 
            // btnMinus
            // 
            resources.ApplyResources(btnMinus, "btnMinus");
            btnMinus.BackColor = System.Drawing.SystemColors.Control;
            btnMinus.BackgroundImage = Properties.Resources.minus;
            btnMinus.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            btnMinus.BorderRadius = 10;
            btnMinus.BorderSize = 0;
            btnMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            btnMinus.ForeColor = System.Drawing.SystemColors.ControlText;
            btnMinus.Name = "btnMinus";
            ttOperator.SetToolTip(btnMinus, resources.GetString("btnMinus.ToolTip"));
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            btnMinus.PreviewKeyDown += ButtonsPreviewKeyDown;
            // 
            // btnNum1
            // 
            resources.ApplyResources(btnNum1, "btnNum1");
            btnNum1.BackColor = System.Drawing.SystemColors.Control;
            btnNum1.BackgroundImage = Properties.Resources.tabuada1;
            btnNum1.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            btnNum1.BorderRadius = 10;
            btnNum1.BorderSize = 0;
            btnNum1.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNum1.ForeColor = System.Drawing.SystemColors.ControlText;
            btnNum1.Name = "btnNum1";
            btnNum1.UseVisualStyleBackColor = false;
            btnNum1.Click += btnNum1_Click;
            btnNum1.PreviewKeyDown += ButtonsPreviewKeyDown;
            // 
            // btnNum2
            // 
            resources.ApplyResources(btnNum2, "btnNum2");
            btnNum2.BackColor = System.Drawing.SystemColors.Control;
            btnNum2.BackgroundImage = Properties.Resources.tabuada2;
            btnNum2.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            btnNum2.BorderRadius = 10;
            btnNum2.BorderSize = 0;
            btnNum2.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNum2.ForeColor = System.Drawing.SystemColors.ControlText;
            btnNum2.Name = "btnNum2";
            btnNum2.UseVisualStyleBackColor = false;
            btnNum2.Click += btnNum2_Click;
            btnNum2.PreviewKeyDown += ButtonsPreviewKeyDown;
            // 
            // btnNum3
            // 
            resources.ApplyResources(btnNum3, "btnNum3");
            btnNum3.BackColor = System.Drawing.SystemColors.Control;
            btnNum3.BackgroundImage = Properties.Resources.tabuada3;
            btnNum3.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            btnNum3.BorderRadius = 10;
            btnNum3.BorderSize = 0;
            btnNum3.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNum3.ForeColor = System.Drawing.SystemColors.ControlText;
            btnNum3.Name = "btnNum3";
            btnNum3.UseVisualStyleBackColor = false;
            btnNum3.Click += btnNum3_Click;
            btnNum3.PreviewKeyDown += ButtonsPreviewKeyDown;
            // 
            // btnPlus
            // 
            resources.ApplyResources(btnPlus, "btnPlus");
            btnPlus.BackColor = System.Drawing.SystemColors.Control;
            btnPlus.BackgroundImage = Properties.Resources.plus;
            btnPlus.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            btnPlus.BorderRadius = 10;
            btnPlus.BorderSize = 0;
            btnPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            btnPlus.ForeColor = System.Drawing.SystemColors.ControlText;
            btnPlus.Name = "btnPlus";
            ttOperator.SetToolTip(btnPlus, resources.GetString("btnPlus.ToolTip"));
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            btnPlus.PreviewKeyDown += ButtonsPreviewKeyDown;
            // 
            // btnEquals
            // 
            resources.ApplyResources(btnEquals, "btnEquals");
            btnEquals.BackColor = System.Drawing.SystemColors.Control;
            btnEquals.BackgroundImage = Properties.Resources.result;
            btnEquals.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            btnEquals.BorderRadius = 10;
            btnEquals.BorderSize = 0;
            btnEquals.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEquals.ForeColor = System.Drawing.SystemColors.ControlText;
            btnEquals.Name = "btnEquals";
            ttOperator.SetToolTip(btnEquals, resources.GetString("btnEquals.ToolTip"));
            btnEquals.UseVisualStyleBackColor = false;
            btnEquals.Click += btnEquals_Click;
            btnEquals.PreviewKeyDown += ButtonsPreviewKeyDown;
            // 
            // btnPeriod
            // 
            resources.ApplyResources(btnPeriod, "btnPeriod");
            btnPeriod.BackColor = System.Drawing.SystemColors.Control;
            btnPeriod.BackgroundImage = Properties.Resources.period;
            btnPeriod.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            btnPeriod.BorderRadius = 10;
            btnPeriod.BorderSize = 0;
            btnPeriod.Cursor = System.Windows.Forms.Cursors.Hand;
            btnPeriod.ForeColor = System.Drawing.SystemColors.ControlText;
            btnPeriod.Name = "btnPeriod";
            btnPeriod.UseVisualStyleBackColor = false;
            btnPeriod.Click += btnPeriod_Click;
            btnPeriod.PreviewKeyDown += ButtonsPreviewKeyDown;
            // 
            // btnNum0
            // 
            resources.ApplyResources(btnNum0, "btnNum0");
            btnNum0.BackColor = System.Drawing.SystemColors.Control;
            btnNum0.BackgroundImage = Properties.Resources.btn0;
            btnNum0.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            btnNum0.BorderRadius = 10;
            btnNum0.BorderSize = 0;
            btnNum0.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNum0.ForeColor = System.Drawing.SystemColors.ControlText;
            btnNum0.Name = "btnNum0";
            btnNum0.UseVisualStyleBackColor = false;
            btnNum0.Click += btnNum0_Click;
            btnNum0.PreviewKeyDown += ButtonsPreviewKeyDown;
            // 
            // btnDivide
            // 
            resources.ApplyResources(btnDivide, "btnDivide");
            btnDivide.BackColor = System.Drawing.SystemColors.Control;
            btnDivide.BackgroundImage = Properties.Resources.divide;
            btnDivide.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            btnDivide.BorderRadius = 10;
            btnDivide.BorderSize = 0;
            btnDivide.Cursor = System.Windows.Forms.Cursors.Hand;
            btnDivide.ForeColor = System.Drawing.SystemColors.ControlText;
            btnDivide.Name = "btnDivide";
            ttOperator.SetToolTip(btnDivide, resources.GetString("btnDivide.ToolTip"));
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnDivide_Click;
            btnDivide.PreviewKeyDown += ButtonsPreviewKeyDown;
            // 
            // Calculator
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Calculator";
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