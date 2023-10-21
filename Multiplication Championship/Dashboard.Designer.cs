
using Multiplication_Championship.Components;

namespace Multiplication_Championship
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            cbbTabuada = new System.Windows.Forms.ComboBox();
            pSide = new System.Windows.Forms.Panel();
            tlpConfig = new System.Windows.Forms.TableLayoutPanel();
            pConfig = new System.Windows.Forms.Panel();
            lblMin = new System.Windows.Forms.Label();
            nudMin = new System.Windows.Forms.NumericUpDown();
            pbNTabuada = new System.Windows.Forms.PictureBox();
            cbShuffle = new System.Windows.Forms.CheckBox();
            lblTabuada = new System.Windows.Forms.Label();
            tbTabuada = new System.Windows.Forms.TextBox();
            cbComutative = new System.Windows.Forms.CheckBox();
            nudQtd = new System.Windows.Forms.NumericUpDown();
            lblMax = new System.Windows.Forms.Label();
            nudMax = new System.Windows.Forms.NumericUpDown();
            lblQtd = new System.Windows.Forms.Label();
            btnStart = new System.Windows.Forms.Button();
            btnNotebook = new RoundedButton();
            btnCalculator = new RoundedButton();
            btnAwards = new RoundedButton();
            btnBack = new RoundedButton();
            tcPages = new System.Windows.Forms.TabControl();
            tpSetup = new System.Windows.Forms.TabPage();
            tlpSetup = new System.Windows.Forms.TableLayoutPanel();
            pbWinLose = new System.Windows.Forms.PictureBox();
            lblNoGameInfo = new System.Windows.Forms.Label();
            tpGame = new System.Windows.Forms.TabPage();
            pCounters = new System.Windows.Forms.Panel();
            pbWrong = new System.Windows.Forms.PictureBox();
            lblWrong = new System.Windows.Forms.Label();
            lblCorrect = new System.Windows.Forms.Label();
            pbCorrect = new System.Windows.Forms.PictureBox();
            tlpProblem = new System.Windows.Forms.TableLayoutPanel();
            lblProblem = new System.Windows.Forms.Label();
            tbAnswer = new System.Windows.Forms.TextBox();
            lblProblemN = new System.Windows.Forms.Label();
            lblTime = new System.Windows.Forms.Label();
            pgbCompletition = new System.Windows.Forms.ProgressBar();
            tpAwards = new System.Windows.Forms.TabPage();
            lblAwardsCnt = new System.Windows.Forms.Label();
            lvwAwards = new System.Windows.Forms.ListView();
            chIcon = new System.Windows.Forms.ColumnHeader();
            chName = new System.Windows.Forms.ColumnHeader();
            chState = new System.Windows.Forms.ColumnHeader();
            ilAwards = new System.Windows.Forms.ImageList(components);
            lblTextAwards = new System.Windows.Forms.Label();
            lblAwards = new System.Windows.Forms.Label();
            tTime = new System.Windows.Forms.Timer(components);
            pSide.SuspendLayout();
            tlpConfig.SuspendLayout();
            pConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbNTabuada).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQtd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMax).BeginInit();
            tcPages.SuspendLayout();
            tpSetup.SuspendLayout();
            tlpSetup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbWinLose).BeginInit();
            tpGame.SuspendLayout();
            pCounters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbWrong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCorrect).BeginInit();
            tlpProblem.SuspendLayout();
            tpAwards.SuspendLayout();
            SuspendLayout();
            // 
            // cbbTabuada
            // 
            cbbTabuada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbbTabuada.FormattingEnabled = true;
            cbbTabuada.Items.AddRange(new object[] { resources.GetString("cbbTabuada.Items"), resources.GetString("cbbTabuada.Items1"), resources.GetString("cbbTabuada.Items2"), resources.GetString("cbbTabuada.Items3"), resources.GetString("cbbTabuada.Items4"), resources.GetString("cbbTabuada.Items5"), resources.GetString("cbbTabuada.Items6"), resources.GetString("cbbTabuada.Items7"), resources.GetString("cbbTabuada.Items8"), resources.GetString("cbbTabuada.Items9"), resources.GetString("cbbTabuada.Items10") });
            resources.ApplyResources(cbbTabuada, "cbbTabuada");
            cbbTabuada.Name = "cbbTabuada";
            cbbTabuada.SelectedIndexChanged += cbbTabuada_SelectedIndexChanged;
            // 
            // pSide
            // 
            resources.ApplyResources(pSide, "pSide");
            pSide.BackColor = System.Drawing.SystemColors.ControlLight;
            pSide.Controls.Add(tlpConfig);
            pSide.Controls.Add(btnNotebook);
            pSide.Controls.Add(btnCalculator);
            pSide.Controls.Add(btnAwards);
            pSide.Controls.Add(btnBack);
            pSide.Name = "pSide";
            // 
            // tlpConfig
            // 
            resources.ApplyResources(tlpConfig, "tlpConfig");
            tlpConfig.Controls.Add(pConfig, 0, 0);
            tlpConfig.Name = "tlpConfig";
            // 
            // pConfig
            // 
            resources.ApplyResources(pConfig, "pConfig");
            pConfig.Controls.Add(lblMin);
            pConfig.Controls.Add(nudMin);
            pConfig.Controls.Add(pbNTabuada);
            pConfig.Controls.Add(cbShuffle);
            pConfig.Controls.Add(cbbTabuada);
            pConfig.Controls.Add(lblTabuada);
            pConfig.Controls.Add(tbTabuada);
            pConfig.Controls.Add(cbComutative);
            pConfig.Controls.Add(nudQtd);
            pConfig.Controls.Add(lblMax);
            pConfig.Controls.Add(nudMax);
            pConfig.Controls.Add(lblQtd);
            pConfig.Controls.Add(btnStart);
            pConfig.Name = "pConfig";
            // 
            // lblMin
            // 
            resources.ApplyResources(lblMin, "lblMin");
            lblMin.Name = "lblMin";
            // 
            // nudMin
            // 
            resources.ApplyResources(nudMin, "nudMin");
            nudMin.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            nudMin.Name = "nudMin";
            nudMin.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // pbNTabuada
            // 
            pbNTabuada.Image = Properties.Resources.tabuadaX;
            resources.ApplyResources(pbNTabuada, "pbNTabuada");
            pbNTabuada.Name = "pbNTabuada";
            pbNTabuada.TabStop = false;
            // 
            // cbShuffle
            // 
            resources.ApplyResources(cbShuffle, "cbShuffle");
            cbShuffle.Name = "cbShuffle";
            cbShuffle.UseVisualStyleBackColor = true;
            // 
            // lblTabuada
            // 
            resources.ApplyResources(lblTabuada, "lblTabuada");
            lblTabuada.Name = "lblTabuada";
            // 
            // tbTabuada
            // 
            resources.ApplyResources(tbTabuada, "tbTabuada");
            tbTabuada.Name = "tbTabuada";
            tbTabuada.KeyPress += tbTabuada_KeyPress;
            // 
            // cbComutative
            // 
            resources.ApplyResources(cbComutative, "cbComutative");
            cbComutative.Name = "cbComutative";
            cbComutative.UseVisualStyleBackColor = true;
            // 
            // nudQtd
            // 
            resources.ApplyResources(nudQtd, "nudQtd");
            nudQtd.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            nudQtd.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            nudQtd.Name = "nudQtd";
            nudQtd.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // lblMax
            // 
            resources.ApplyResources(lblMax, "lblMax");
            lblMax.Name = "lblMax";
            // 
            // nudMax
            // 
            resources.ApplyResources(nudMax, "nudMax");
            nudMax.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            nudMax.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            nudMax.Name = "nudMax";
            nudMax.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // lblQtd
            // 
            resources.ApplyResources(lblQtd, "lblQtd");
            lblQtd.Name = "lblQtd";
            // 
            // btnStart
            // 
            resources.ApplyResources(btnStart, "btnStart");
            btnStart.Name = "btnStart";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnNotebook
            // 
            resources.ApplyResources(btnNotebook, "btnNotebook");
            btnNotebook.BackColor = System.Drawing.SystemColors.ControlLight;
            btnNotebook.BackgroundImage = Properties.Resources.book;
            btnNotebook.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            btnNotebook.BorderRadius = 10;
            btnNotebook.BorderSize = 0;
            btnNotebook.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNotebook.ForeColor = System.Drawing.SystemColors.ControlText;
            btnNotebook.Name = "btnNotebook";
            btnNotebook.UseVisualStyleBackColor = false;
            btnNotebook.Click += btnNotebook_Click;
            // 
            // btnCalculator
            // 
            resources.ApplyResources(btnCalculator, "btnCalculator");
            btnCalculator.BackColor = System.Drawing.SystemColors.ControlLight;
            btnCalculator.BackgroundImage = Properties.Resources.calculator;
            btnCalculator.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            btnCalculator.BorderRadius = 10;
            btnCalculator.BorderSize = 0;
            btnCalculator.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCalculator.ForeColor = System.Drawing.SystemColors.ControlText;
            btnCalculator.Name = "btnCalculator";
            btnCalculator.UseVisualStyleBackColor = false;
            btnCalculator.Click += btnCalculator_Click;
            // 
            // btnAwards
            // 
            btnAwards.BackColor = System.Drawing.SystemColors.ControlLight;
            btnAwards.BackgroundImage = Properties.Resources.awards;
            resources.ApplyResources(btnAwards, "btnAwards");
            btnAwards.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            btnAwards.BorderRadius = 10;
            btnAwards.BorderSize = 0;
            btnAwards.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAwards.ForeColor = System.Drawing.SystemColors.ControlText;
            btnAwards.Name = "btnAwards";
            btnAwards.UseVisualStyleBackColor = false;
            btnAwards.Click += btnAwards_Click;
            // 
            // btnBack
            // 
            resources.ApplyResources(btnBack, "btnBack");
            btnBack.BackColor = System.Drawing.SystemColors.ControlLight;
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
            // tcPages
            // 
            resources.ApplyResources(tcPages, "tcPages");
            tcPages.Controls.Add(tpSetup);
            tcPages.Controls.Add(tpGame);
            tcPages.Controls.Add(tpAwards);
            tcPages.Name = "tcPages";
            tcPages.SelectedIndex = 0;
            tcPages.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            tcPages.TabStop = false;
            // 
            // tpSetup
            // 
            tpSetup.Controls.Add(tlpSetup);
            resources.ApplyResources(tpSetup, "tpSetup");
            tpSetup.Name = "tpSetup";
            tpSetup.UseVisualStyleBackColor = true;
            // 
            // tlpSetup
            // 
            resources.ApplyResources(tlpSetup, "tlpSetup");
            tlpSetup.Controls.Add(pbWinLose, 0, 0);
            tlpSetup.Controls.Add(lblNoGameInfo, 0, 2);
            tlpSetup.Name = "tlpSetup";
            // 
            // pbWinLose
            // 
            resources.ApplyResources(pbWinLose, "pbWinLose");
            pbWinLose.Image = Properties.Resources.settings;
            pbWinLose.Name = "pbWinLose";
            pbWinLose.TabStop = false;
            // 
            // lblNoGameInfo
            // 
            resources.ApplyResources(lblNoGameInfo, "lblNoGameInfo");
            lblNoGameInfo.Name = "lblNoGameInfo";
            // 
            // tpGame
            // 
            tpGame.Controls.Add(pCounters);
            tpGame.Controls.Add(tlpProblem);
            tpGame.Controls.Add(lblProblemN);
            tpGame.Controls.Add(lblTime);
            tpGame.Controls.Add(pgbCompletition);
            resources.ApplyResources(tpGame, "tpGame");
            tpGame.Name = "tpGame";
            tpGame.UseVisualStyleBackColor = true;
            // 
            // pCounters
            // 
            resources.ApplyResources(pCounters, "pCounters");
            pCounters.Controls.Add(pbWrong);
            pCounters.Controls.Add(lblWrong);
            pCounters.Controls.Add(lblCorrect);
            pCounters.Controls.Add(pbCorrect);
            pCounters.Name = "pCounters";
            // 
            // pbWrong
            // 
            resources.ApplyResources(pbWrong, "pbWrong");
            pbWrong.Image = Properties.Resources.wrong;
            pbWrong.Name = "pbWrong";
            pbWrong.TabStop = false;
            // 
            // lblWrong
            // 
            resources.ApplyResources(lblWrong, "lblWrong");
            lblWrong.ForeColor = System.Drawing.Color.FromArgb(232, 42, 57);
            lblWrong.Name = "lblWrong";
            // 
            // lblCorrect
            // 
            resources.ApplyResources(lblCorrect, "lblCorrect");
            lblCorrect.ForeColor = System.Drawing.Color.FromArgb(34, 185, 119);
            lblCorrect.Name = "lblCorrect";
            // 
            // pbCorrect
            // 
            resources.ApplyResources(pbCorrect, "pbCorrect");
            pbCorrect.Image = Properties.Resources.correct;
            pbCorrect.Name = "pbCorrect";
            pbCorrect.TabStop = false;
            // 
            // tlpProblem
            // 
            resources.ApplyResources(tlpProblem, "tlpProblem");
            tlpProblem.Controls.Add(lblProblem, 0, 0);
            tlpProblem.Controls.Add(tbAnswer, 0, 2);
            tlpProblem.Name = "tlpProblem";
            // 
            // lblProblem
            // 
            resources.ApplyResources(lblProblem, "lblProblem");
            lblProblem.Name = "lblProblem";
            // 
            // tbAnswer
            // 
            resources.ApplyResources(tbAnswer, "tbAnswer");
            tbAnswer.Name = "tbAnswer";
            tbAnswer.KeyPress += tbAnswer_KeyPress;
            // 
            // lblProblemN
            // 
            resources.ApplyResources(lblProblemN, "lblProblemN");
            lblProblemN.Name = "lblProblemN";
            // 
            // lblTime
            // 
            resources.ApplyResources(lblTime, "lblTime");
            lblTime.Name = "lblTime";
            // 
            // pgbCompletition
            // 
            resources.ApplyResources(pgbCompletition, "pgbCompletition");
            pgbCompletition.Name = "pgbCompletition";
            // 
            // tpAwards
            // 
            tpAwards.Controls.Add(lblAwardsCnt);
            tpAwards.Controls.Add(lvwAwards);
            tpAwards.Controls.Add(lblTextAwards);
            tpAwards.Controls.Add(lblAwards);
            resources.ApplyResources(tpAwards, "tpAwards");
            tpAwards.Name = "tpAwards";
            tpAwards.UseVisualStyleBackColor = true;
            // 
            // lblAwardsCnt
            // 
            resources.ApplyResources(lblAwardsCnt, "lblAwardsCnt");
            lblAwardsCnt.Name = "lblAwardsCnt";
            // 
            // lvwAwards
            // 
            resources.ApplyResources(lvwAwards, "lvwAwards");
            lvwAwards.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { chIcon, chName, chState });
            lvwAwards.FullRowSelect = true;
            lvwAwards.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            lvwAwards.MultiSelect = false;
            lvwAwards.Name = "lvwAwards";
            lvwAwards.SmallImageList = ilAwards;
            lvwAwards.UseCompatibleStateImageBehavior = false;
            lvwAwards.View = System.Windows.Forms.View.Details;
            lvwAwards.ColumnWidthChanging += lvwAwards_ColumnWidthChanging;
            lvwAwards.Click += lvwAwards_Click;
            lvwAwards.KeyPress += lvwAwards_KeyPress;
            // 
            // chIcon
            // 
            resources.ApplyResources(chIcon, "chIcon");
            // 
            // chName
            // 
            resources.ApplyResources(chName, "chName");
            // 
            // chState
            // 
            resources.ApplyResources(chState, "chState");
            // 
            // ilAwards
            // 
            ilAwards.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            ilAwards.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("ilAwards.ImageStream");
            ilAwards.TransparentColor = System.Drawing.Color.Transparent;
            ilAwards.Images.SetKeyName(0, "A1.png");
            ilAwards.Images.SetKeyName(1, "A1G.png");
            ilAwards.Images.SetKeyName(2, "A1R.png");
            ilAwards.Images.SetKeyName(3, "A2.png");
            ilAwards.Images.SetKeyName(4, "A2G.png");
            ilAwards.Images.SetKeyName(5, "A2R.png");
            ilAwards.Images.SetKeyName(6, "A3.png");
            ilAwards.Images.SetKeyName(7, "A3G.png");
            ilAwards.Images.SetKeyName(8, "A3R.png");
            ilAwards.Images.SetKeyName(9, "A4.png");
            ilAwards.Images.SetKeyName(10, "A4G.png");
            ilAwards.Images.SetKeyName(11, "A4R.png");
            ilAwards.Images.SetKeyName(12, "A5.png");
            ilAwards.Images.SetKeyName(13, "A5G.png");
            ilAwards.Images.SetKeyName(14, "A5R.png");
            ilAwards.Images.SetKeyName(15, "A6.png");
            ilAwards.Images.SetKeyName(16, "A6G.png");
            ilAwards.Images.SetKeyName(17, "A6R.png");
            ilAwards.Images.SetKeyName(18, "A7.png");
            ilAwards.Images.SetKeyName(19, "A7G.png");
            ilAwards.Images.SetKeyName(20, "A7R.png");
            ilAwards.Images.SetKeyName(21, "A8.png");
            ilAwards.Images.SetKeyName(22, "A8G.png");
            ilAwards.Images.SetKeyName(23, "A8R.png");
            ilAwards.Images.SetKeyName(24, "A9.png");
            ilAwards.Images.SetKeyName(25, "A9G.png");
            ilAwards.Images.SetKeyName(26, "A9R.png");
            ilAwards.Images.SetKeyName(27, "AX.png");
            ilAwards.Images.SetKeyName(28, "AXG.png");
            ilAwards.Images.SetKeyName(29, "AXR.png");
            ilAwards.Images.SetKeyName(30, "C100.png");
            ilAwards.Images.SetKeyName(31, "C300.png");
            ilAwards.Images.SetKeyName(32, "C1000.png");
            ilAwards.Images.SetKeyName(33, "T30.png");
            ilAwards.Images.SetKeyName(34, "T10.png");
            ilAwards.Images.SetKeyName(35, "F1.png");
            ilAwards.Images.SetKeyName(36, "F2.png");
            ilAwards.Images.SetKeyName(37, "F3.png");
            ilAwards.Images.SetKeyName(38, "F4.png");
            // 
            // lblTextAwards
            // 
            resources.ApplyResources(lblTextAwards, "lblTextAwards");
            lblTextAwards.Name = "lblTextAwards";
            // 
            // lblAwards
            // 
            resources.ApplyResources(lblAwards, "lblAwards");
            lblAwards.Name = "lblAwards";
            // 
            // tTime
            // 
            tTime.Tick += tTime_Tick;
            // 
            // Dashboard
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(tcPages);
            Controls.Add(pSide);
            Name = "Dashboard";
            FormClosing += Dashboard_FormClosing;
            Load += Dashboard_Load;
            pSide.ResumeLayout(false);
            tlpConfig.ResumeLayout(false);
            pConfig.ResumeLayout(false);
            pConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbNTabuada).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQtd).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMax).EndInit();
            tcPages.ResumeLayout(false);
            tpSetup.ResumeLayout(false);
            tlpSetup.ResumeLayout(false);
            tlpSetup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbWinLose).EndInit();
            tpGame.ResumeLayout(false);
            tpGame.PerformLayout();
            pCounters.ResumeLayout(false);
            pCounters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbWrong).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCorrect).EndInit();
            tlpProblem.ResumeLayout(false);
            tlpProblem.PerformLayout();
            tpAwards.ResumeLayout(false);
            tpAwards.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ComboBox cbbTabuada;
        private System.Windows.Forms.Panel pSide;
        private System.Windows.Forms.Label lblTabuada;
        private System.Windows.Forms.CheckBox cbShuffle;
        private System.Windows.Forms.PictureBox pbNTabuada;
        private System.Windows.Forms.NumericUpDown nudMax;
        private System.Windows.Forms.NumericUpDown nudQtd;
        private System.Windows.Forms.TextBox tbTabuada;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ProgressBar pgbCompletition;
        private System.Windows.Forms.PictureBox pbCorrect;
        private System.Windows.Forms.PictureBox pbWrong;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Label lblWrong;
        private System.Windows.Forms.Label lblProblemN;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblProblem;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.TableLayoutPanel tlpProblem;
        private System.Windows.Forms.CheckBox cbComutative;
        private System.Windows.Forms.Timer tTime;
        private System.Windows.Forms.Label lblAwards;
        private System.Windows.Forms.Label lblTextAwards;
        private System.Windows.Forms.ListView lvwAwards;
        private System.Windows.Forms.ImageList ilAwards;
        private System.Windows.Forms.ColumnHeader chIcon;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chState;
        private RoundedButton btnBack;
        private System.Windows.Forms.TabControl tcPages;
        private System.Windows.Forms.TabPage tpGame;
        private System.Windows.Forms.TabPage tpAwards;
        private RoundedButton btnNotebook;
        private RoundedButton btnCalculator;
        private RoundedButton btnAwards;
        private System.Windows.Forms.TabPage tpSetup;
        private System.Windows.Forms.PictureBox pbWinLose;
        private System.Windows.Forms.Label lblNoGameInfo;
        private System.Windows.Forms.Panel pCounters;
        private System.Windows.Forms.TableLayoutPanel tlpSetup;
        private System.Windows.Forms.Label lblAwardsCnt;
        private System.Windows.Forms.Panel pConfig;
        private System.Windows.Forms.TableLayoutPanel tlpConfig;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.NumericUpDown nudMin;
    }
}

