
using Campeonato_das_Tabuadas.Components;

namespace Campeonato_das_Tabuadas
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
            cbbTabuada.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "Outra", "Todas" });
            cbbTabuada.Location = new System.Drawing.Point(71, 48);
            cbbTabuada.Name = "cbbTabuada";
            cbbTabuada.Size = new System.Drawing.Size(73, 23);
            cbbTabuada.TabIndex = 0;
            cbbTabuada.SelectedIndexChanged += cbbTabuada_SelectedIndexChanged;
            // 
            // pSide
            // 
            pSide.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            pSide.BackColor = System.Drawing.SystemColors.ControlLight;
            pSide.Controls.Add(tlpConfig);
            pSide.Controls.Add(btnNotebook);
            pSide.Controls.Add(btnCalculator);
            pSide.Controls.Add(btnAwards);
            pSide.Controls.Add(btnBack);
            pSide.Location = new System.Drawing.Point(0, 0);
            pSide.Name = "pSide";
            pSide.Size = new System.Drawing.Size(250, 461);
            pSide.TabIndex = 1;
            // 
            // tlpConfig
            // 
            tlpConfig.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tlpConfig.ColumnCount = 1;
            tlpConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpConfig.Controls.Add(pConfig, 0, 0);
            tlpConfig.Location = new System.Drawing.Point(12, 59);
            tlpConfig.Name = "tlpConfig";
            tlpConfig.RowCount = 1;
            tlpConfig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpConfig.Size = new System.Drawing.Size(224, 343);
            tlpConfig.TabIndex = 13;
            // 
            // pConfig
            // 
            pConfig.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            pConfig.Location = new System.Drawing.Point(3, 16);
            pConfig.Name = "pConfig";
            pConfig.Size = new System.Drawing.Size(218, 310);
            pConfig.TabIndex = 12;
            // 
            // lblMin
            // 
            lblMin.AutoSize = true;
            lblMin.Location = new System.Drawing.Point(22, 137);
            lblMin.Name = "lblMin";
            lblMin.Size = new System.Drawing.Size(81, 15);
            lblMin.TabIndex = 13;
            lblMin.Text = "Valor Mínimo:";
            // 
            // nudMin
            // 
            nudMin.Location = new System.Drawing.Point(150, 135);
            nudMin.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            nudMin.Name = "nudMin";
            nudMin.Size = new System.Drawing.Size(47, 23);
            nudMin.TabIndex = 12;
            nudMin.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // pbNTabuada
            // 
            pbNTabuada.Image = Properties.Resources.tabuadaX;
            pbNTabuada.Location = new System.Drawing.Point(22, 30);
            pbNTabuada.Name = "pbNTabuada";
            pbNTabuada.Size = new System.Drawing.Size(40, 40);
            pbNTabuada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbNTabuada.TabIndex = 5;
            pbNTabuada.TabStop = false;
            // 
            // cbShuffle
            // 
            cbShuffle.AutoSize = true;
            cbShuffle.Location = new System.Drawing.Point(23, 215);
            cbShuffle.Name = "cbShuffle";
            cbShuffle.Size = new System.Drawing.Size(74, 19);
            cbShuffle.TabIndex = 4;
            cbShuffle.Text = "Aleatório";
            cbShuffle.UseVisualStyleBackColor = true;
            // 
            // lblTabuada
            // 
            lblTabuada.AutoSize = true;
            lblTabuada.Location = new System.Drawing.Point(68, 30);
            lblTabuada.Name = "lblTabuada";
            lblTabuada.Size = new System.Drawing.Size(54, 15);
            lblTabuada.TabIndex = 4;
            lblTabuada.Text = "Tabuada:";
            // 
            // tbTabuada
            // 
            tbTabuada.Location = new System.Drawing.Point(150, 48);
            tbTabuada.MaxLength = 3;
            tbTabuada.Name = "tbTabuada";
            tbTabuada.Size = new System.Drawing.Size(47, 23);
            tbTabuada.TabIndex = 1;
            tbTabuada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            tbTabuada.KeyPress += tbTabuada_KeyPress;
            // 
            // cbComutative
            // 
            cbComutative.AutoSize = true;
            cbComutative.Location = new System.Drawing.Point(109, 215);
            cbComutative.Name = "cbComutative";
            cbComutative.Size = new System.Drawing.Size(88, 19);
            cbComutative.TabIndex = 5;
            cbComutative.Text = "Comutativa";
            cbComutative.UseVisualStyleBackColor = true;
            // 
            // nudQtd
            // 
            nudQtd.Location = new System.Drawing.Point(150, 100);
            nudQtd.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            nudQtd.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            nudQtd.Name = "nudQtd";
            nudQtd.Size = new System.Drawing.Size(47, 23);
            nudQtd.TabIndex = 2;
            nudQtd.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // lblMax
            // 
            lblMax.AutoSize = true;
            lblMax.Location = new System.Drawing.Point(22, 172);
            lblMax.Name = "lblMax";
            lblMax.Size = new System.Drawing.Size(83, 15);
            lblMax.TabIndex = 11;
            lblMax.Text = "Valor Máximo:";
            // 
            // nudMax
            // 
            nudMax.Location = new System.Drawing.Point(150, 170);
            nudMax.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            nudMax.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            nudMax.Name = "nudMax";
            nudMax.Size = new System.Drawing.Size(47, 23);
            nudMax.TabIndex = 3;
            nudMax.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // lblQtd
            // 
            lblQtd.AutoSize = true;
            lblQtd.Location = new System.Drawing.Point(22, 102);
            lblQtd.Name = "lblQtd";
            lblQtd.Size = new System.Drawing.Size(105, 15);
            lblQtd.TabIndex = 10;
            lblQtd.Text = "Qtd. de Perguntas:";
            // 
            // btnStart
            // 
            btnStart.Location = new System.Drawing.Point(69, 260);
            btnStart.Name = "btnStart";
            btnStart.Size = new System.Drawing.Size(75, 23);
            btnStart.TabIndex = 6;
            btnStart.Text = "Começar";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnNotebook
            // 
            btnNotebook.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnNotebook.BackColor = System.Drawing.SystemColors.ControlLight;
            btnNotebook.BackgroundImage = Properties.Resources.book;
            btnNotebook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnNotebook.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            btnNotebook.BorderRadius = 10;
            btnNotebook.BorderSize = 0;
            btnNotebook.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNotebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNotebook.ForeColor = System.Drawing.SystemColors.ControlText;
            btnNotebook.Location = new System.Drawing.Point(198, 408);
            btnNotebook.Name = "btnNotebook";
            btnNotebook.Size = new System.Drawing.Size(45, 45);
            btnNotebook.TabIndex = 10;
            btnNotebook.UseVisualStyleBackColor = false;
            btnNotebook.Click += btnNotebook_Click;
            // 
            // btnCalculator
            // 
            btnCalculator.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnCalculator.BackColor = System.Drawing.SystemColors.ControlLight;
            btnCalculator.BackgroundImage = Properties.Resources.calculator;
            btnCalculator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnCalculator.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            btnCalculator.BorderRadius = 10;
            btnCalculator.BorderSize = 0;
            btnCalculator.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCalculator.ForeColor = System.Drawing.SystemColors.ControlText;
            btnCalculator.Location = new System.Drawing.Point(198, 8);
            btnCalculator.Name = "btnCalculator";
            btnCalculator.Size = new System.Drawing.Size(45, 45);
            btnCalculator.TabIndex = 9;
            btnCalculator.UseVisualStyleBackColor = false;
            btnCalculator.Click += btnCalculator_Click;
            // 
            // btnAwards
            // 
            btnAwards.BackColor = System.Drawing.SystemColors.ControlLight;
            btnAwards.BackgroundImage = Properties.Resources.awards;
            btnAwards.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnAwards.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            btnAwards.BorderRadius = 10;
            btnAwards.BorderSize = 0;
            btnAwards.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAwards.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAwards.ForeColor = System.Drawing.SystemColors.ControlText;
            btnAwards.Location = new System.Drawing.Point(8, 8);
            btnAwards.Name = "btnAwards";
            btnAwards.Size = new System.Drawing.Size(45, 45);
            btnAwards.TabIndex = 8;
            btnAwards.UseVisualStyleBackColor = false;
            btnAwards.Click += btnAwards_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnBack.BackColor = System.Drawing.SystemColors.ControlLight;
            btnBack.BackgroundImage = Properties.Resources.back;
            btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnBack.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            btnBack.BorderRadius = 10;
            btnBack.BorderSize = 0;
            btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBack.ForeColor = System.Drawing.SystemColors.ControlText;
            btnBack.Location = new System.Drawing.Point(8, 408);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(45, 45);
            btnBack.TabIndex = 7;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // tcPages
            // 
            tcPages.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tcPages.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            tcPages.Controls.Add(tpSetup);
            tcPages.Controls.Add(tpGame);
            tcPages.Controls.Add(tpAwards);
            tcPages.Location = new System.Drawing.Point(250, 0);
            tcPages.Name = "tcPages";
            tcPages.Padding = new System.Drawing.Point(0, 0);
            tcPages.SelectedIndex = 0;
            tcPages.Size = new System.Drawing.Size(584, 461);
            tcPages.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            tcPages.TabIndex = 0;
            tcPages.TabStop = false;
            // 
            // tpSetup
            // 
            tpSetup.Controls.Add(tlpSetup);
            tpSetup.Location = new System.Drawing.Point(4, 27);
            tpSetup.Name = "tpSetup";
            tpSetup.Size = new System.Drawing.Size(576, 430);
            tpSetup.TabIndex = 2;
            tpSetup.Text = "Configurar";
            tpSetup.UseVisualStyleBackColor = true;
            // 
            // tlpSetup
            // 
            tlpSetup.ColumnCount = 1;
            tlpSetup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpSetup.Controls.Add(pbWinLose, 0, 0);
            tlpSetup.Controls.Add(lblNoGameInfo, 0, 2);
            tlpSetup.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpSetup.Location = new System.Drawing.Point(0, 0);
            tlpSetup.Name = "tlpSetup";
            tlpSetup.RowCount = 3;
            tlpSetup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            tlpSetup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tlpSetup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            tlpSetup.Size = new System.Drawing.Size(576, 430);
            tlpSetup.TabIndex = 0;
            // 
            // pbWinLose
            // 
            pbWinLose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            pbWinLose.Image = Properties.Resources.settings;
            pbWinLose.Location = new System.Drawing.Point(228, 123);
            pbWinLose.Name = "pbWinLose";
            pbWinLose.Size = new System.Drawing.Size(120, 120);
            pbWinLose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbWinLose.TabIndex = 1;
            pbWinLose.TabStop = false;
            // 
            // lblNoGameInfo
            // 
            lblNoGameInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            lblNoGameInfo.AutoSize = true;
            lblNoGameInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblNoGameInfo.Location = new System.Drawing.Point(72, 266);
            lblNoGameInfo.Name = "lblNoGameInfo";
            lblNoGameInfo.Size = new System.Drawing.Size(431, 21);
            lblNoGameInfo.TabIndex = 0;
            lblNoGameInfo.Text = "Configure e inicie um jogo através das configurações ao lado";
            lblNoGameInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpGame
            // 
            tpGame.Controls.Add(pCounters);
            tpGame.Controls.Add(tlpProblem);
            tpGame.Controls.Add(lblProblemN);
            tpGame.Controls.Add(lblTime);
            tpGame.Controls.Add(pgbCompletition);
            tpGame.Location = new System.Drawing.Point(4, 27);
            tpGame.Name = "tpGame";
            tpGame.Padding = new System.Windows.Forms.Padding(3);
            tpGame.Size = new System.Drawing.Size(576, 430);
            tpGame.TabIndex = 0;
            tpGame.Text = "Jogo";
            tpGame.UseVisualStyleBackColor = true;
            // 
            // pCounters
            // 
            pCounters.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            pCounters.AutoSize = true;
            pCounters.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            pCounters.Controls.Add(pbWrong);
            pCounters.Controls.Add(lblWrong);
            pCounters.Controls.Add(lblCorrect);
            pCounters.Controls.Add(pbCorrect);
            pCounters.Location = new System.Drawing.Point(10, 396);
            pCounters.Name = "pCounters";
            pCounters.Size = new System.Drawing.Size(144, 24);
            pCounters.TabIndex = 14;
            // 
            // pbWrong
            // 
            pbWrong.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            pbWrong.Image = Properties.Resources.wrong;
            pbWrong.Location = new System.Drawing.Point(81, 1);
            pbWrong.Name = "pbWrong";
            pbWrong.Size = new System.Drawing.Size(23, 23);
            pbWrong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbWrong.TabIndex = 4;
            pbWrong.TabStop = false;
            // 
            // lblWrong
            // 
            lblWrong.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblWrong.AutoSize = true;
            lblWrong.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblWrong.ForeColor = System.Drawing.Color.FromArgb(232, 42, 57);
            lblWrong.Location = new System.Drawing.Point(108, 3);
            lblWrong.Name = "lblWrong";
            lblWrong.Size = new System.Drawing.Size(33, 19);
            lblWrong.TabIndex = 7;
            lblWrong.Text = "null";
            lblWrong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCorrect
            // 
            lblCorrect.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblCorrect.AutoSize = true;
            lblCorrect.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblCorrect.ForeColor = System.Drawing.Color.FromArgb(34, 185, 119);
            lblCorrect.Location = new System.Drawing.Point(27, 3);
            lblCorrect.Name = "lblCorrect";
            lblCorrect.Size = new System.Drawing.Size(33, 19);
            lblCorrect.TabIndex = 5;
            lblCorrect.Text = "null";
            lblCorrect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbCorrect
            // 
            pbCorrect.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            pbCorrect.Image = Properties.Resources.correct;
            pbCorrect.Location = new System.Drawing.Point(0, 1);
            pbCorrect.Name = "pbCorrect";
            pbCorrect.Size = new System.Drawing.Size(23, 23);
            pbCorrect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbCorrect.TabIndex = 3;
            pbCorrect.TabStop = false;
            // 
            // tlpProblem
            // 
            tlpProblem.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tlpProblem.ColumnCount = 1;
            tlpProblem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpProblem.Controls.Add(lblProblem, 0, 0);
            tlpProblem.Controls.Add(tbAnswer, 0, 2);
            tlpProblem.Location = new System.Drawing.Point(88, 93);
            tlpProblem.Name = "tlpProblem";
            tlpProblem.RowCount = 3;
            tlpProblem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpProblem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tlpProblem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpProblem.Size = new System.Drawing.Size(400, 237);
            tlpProblem.TabIndex = 13;
            // 
            // lblProblem
            // 
            lblProblem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            lblProblem.AutoSize = true;
            lblProblem.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblProblem.Location = new System.Drawing.Point(58, 0);
            lblProblem.Name = "lblProblem";
            lblProblem.Size = new System.Drawing.Size(284, 108);
            lblProblem.TabIndex = 10;
            lblProblem.Text = "0 × 0";
            lblProblem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbAnswer
            // 
            tbAnswer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            tbAnswer.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            tbAnswer.Location = new System.Drawing.Point(125, 131);
            tbAnswer.MaxLength = 6;
            tbAnswer.Name = "tbAnswer";
            tbAnswer.PlaceholderText = "0";
            tbAnswer.Size = new System.Drawing.Size(150, 61);
            tbAnswer.TabIndex = 12;
            tbAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            tbAnswer.KeyPress += tbAnswer_KeyPress;
            // 
            // lblProblemN
            // 
            lblProblemN.AutoSize = true;
            lblProblemN.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblProblemN.Location = new System.Drawing.Point(9, 7);
            lblProblemN.Name = "lblProblemN";
            lblProblemN.Size = new System.Drawing.Size(66, 32);
            lblProblemN.TabIndex = 8;
            lblProblemN.Text = "0 / X";
            lblProblemN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            lblTime.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblTime.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTime.Location = new System.Drawing.Point(492, 7);
            lblTime.Name = "lblTime";
            lblTime.Size = new System.Drawing.Size(75, 32);
            lblTime.TabIndex = 9;
            lblTime.Text = "00:00";
            lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pgbCompletition
            // 
            pgbCompletition.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            pgbCompletition.Location = new System.Drawing.Point(416, 397);
            pgbCompletition.Name = "pgbCompletition";
            pgbCompletition.Size = new System.Drawing.Size(150, 23);
            pgbCompletition.TabIndex = 2;
            // 
            // tpAwards
            // 
            tpAwards.Controls.Add(lblAwardsCnt);
            tpAwards.Controls.Add(lvwAwards);
            tpAwards.Controls.Add(lblTextAwards);
            tpAwards.Controls.Add(lblAwards);
            tpAwards.Location = new System.Drawing.Point(4, 27);
            tpAwards.Name = "tpAwards";
            tpAwards.Padding = new System.Windows.Forms.Padding(3);
            tpAwards.Size = new System.Drawing.Size(576, 430);
            tpAwards.TabIndex = 1;
            tpAwards.Text = "Medalhas";
            tpAwards.UseVisualStyleBackColor = true;
            // 
            // lblAwardsCnt
            // 
            lblAwardsCnt.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblAwardsCnt.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblAwardsCnt.Location = new System.Drawing.Point(447, 7);
            lblAwardsCnt.Name = "lblAwardsCnt";
            lblAwardsCnt.Size = new System.Drawing.Size(120, 32);
            lblAwardsCnt.TabIndex = 0;
            lblAwardsCnt.Text = "X / X";
            lblAwardsCnt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lvwAwards
            // 
            lvwAwards.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lvwAwards.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { chIcon, chName, chState });
            lvwAwards.FullRowSelect = true;
            lvwAwards.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            lvwAwards.Location = new System.Drawing.Point(15, 87);
            lvwAwards.MultiSelect = false;
            lvwAwards.Name = "lvwAwards";
            lvwAwards.Size = new System.Drawing.Size(546, 330);
            lvwAwards.SmallImageList = ilAwards;
            lvwAwards.TabIndex = 11;
            lvwAwards.UseCompatibleStateImageBehavior = false;
            lvwAwards.View = System.Windows.Forms.View.Details;
            lvwAwards.ColumnWidthChanging += lvwAwards_ColumnWidthChanging;
            lvwAwards.Click += lvwAwards_Click;
            lvwAwards.KeyPress += lvwAwards_KeyPress;
            // 
            // chIcon
            // 
            chIcon.Text = "";
            chIcon.Width = 84;
            // 
            // chName
            // 
            chName.Text = "Nome";
            chName.Width = 380;
            // 
            // chState
            // 
            chState.Text = "Estado";
            chState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            lblTextAwards.AutoSize = true;
            lblTextAwards.Location = new System.Drawing.Point(15, 61);
            lblTextAwards.Name = "lblTextAwards";
            lblTextAwards.Size = new System.Drawing.Size(307, 15);
            lblTextAwards.TabIndex = 0;
            lblTextAwards.Text = "Aqui estão todas as medalhas que conseguiste até agora:";
            // 
            // lblAwards
            // 
            lblAwards.AutoSize = true;
            lblAwards.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblAwards.Location = new System.Drawing.Point(6, 9);
            lblAwards.Name = "lblAwards";
            lblAwards.Size = new System.Drawing.Size(164, 45);
            lblAwards.TabIndex = 0;
            lblAwards.Text = "Medalhas";
            // 
            // tTime
            // 
            tTime.Tick += tTime_Tick;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(834, 461);
            Controls.Add(tcPages);
            Controls.Add(pSide);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MinimumSize = new System.Drawing.Size(850, 500);
            Name = "Dashboard";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Campeonato das Tabuadas";
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

