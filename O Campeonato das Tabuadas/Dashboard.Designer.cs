
namespace O_Campeonato_das_Tabuadas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.cbbTabuada = new System.Windows.Forms.ComboBox();
            this.pSide = new System.Windows.Forms.Panel();
            this.cbComutative = new System.Windows.Forms.CheckBox();
            this.pbAwards = new System.Windows.Forms.PictureBox();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblQtd = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.nudMax = new System.Windows.Forms.NumericUpDown();
            this.nudQtd = new System.Windows.Forms.NumericUpDown();
            this.tbTabuada = new System.Windows.Forms.TextBox();
            this.pbNTabuada = new System.Windows.Forms.PictureBox();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.lblTabuada = new System.Windows.Forms.Label();
            this.pbCalculator = new System.Windows.Forms.PictureBox();
            this.cbShuffle = new System.Windows.Forms.CheckBox();
            this.pgbCompletition = new System.Windows.Forms.ProgressBar();
            this.pbCorrect = new System.Windows.Forms.PictureBox();
            this.pbWrong = new System.Windows.Forms.PictureBox();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.lblWrong = new System.Windows.Forms.Label();
            this.lblProblemN = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblProblem = new System.Windows.Forms.Label();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.pGame = new System.Windows.Forms.Panel();
            this.tlpProblem = new System.Windows.Forms.TableLayoutPanel();
            this.tlpNoGameInfo = new System.Windows.Forms.TableLayoutPanel();
            this.pbWinLose = new System.Windows.Forms.PictureBox();
            this.lblNoGameInfo = new System.Windows.Forms.Label();
            this.pAwards = new System.Windows.Forms.Panel();
            this.lvwAwards = new System.Windows.Forms.ListView();
            this.ilAwards = new System.Windows.Forms.ImageList(this.components);
            this.lblTextAwards = new System.Windows.Forms.Label();
            this.lblAwards = new System.Windows.Forms.Label();
            this.tTime = new System.Windows.Forms.Timer(this.components);
            this.pbNotebook = new System.Windows.Forms.PictureBox();
            this.pSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAwards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNTabuada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCalculator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWrong)).BeginInit();
            this.pGame.SuspendLayout();
            this.tlpProblem.SuspendLayout();
            this.tlpNoGameInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWinLose)).BeginInit();
            this.pAwards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotebook)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbTabuada
            // 
            this.cbbTabuada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTabuada.FormattingEnabled = true;
            this.cbbTabuada.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "Outra",
            "Todas"});
            this.cbbTabuada.Location = new System.Drawing.Point(83, 132);
            this.cbbTabuada.Name = "cbbTabuada";
            this.cbbTabuada.Size = new System.Drawing.Size(73, 23);
            this.cbbTabuada.TabIndex = 0;
            this.cbbTabuada.SelectedIndexChanged += new System.EventHandler(this.cbbTabuada_SelectedIndexChanged);
            // 
            // pSide
            // 
            this.pSide.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pSide.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pSide.Controls.Add(this.pbNotebook);
            this.pSide.Controls.Add(this.cbComutative);
            this.pSide.Controls.Add(this.pbAwards);
            this.pSide.Controls.Add(this.lblMax);
            this.pSide.Controls.Add(this.lblQtd);
            this.pSide.Controls.Add(this.btnStart);
            this.pSide.Controls.Add(this.nudMax);
            this.pSide.Controls.Add(this.nudQtd);
            this.pSide.Controls.Add(this.tbTabuada);
            this.pSide.Controls.Add(this.pbNTabuada);
            this.pSide.Controls.Add(this.pbBack);
            this.pSide.Controls.Add(this.lblTabuada);
            this.pSide.Controls.Add(this.pbCalculator);
            this.pSide.Controls.Add(this.cbbTabuada);
            this.pSide.Controls.Add(this.cbShuffle);
            this.pSide.Location = new System.Drawing.Point(0, 0);
            this.pSide.Name = "pSide";
            this.pSide.Size = new System.Drawing.Size(250, 461);
            this.pSide.TabIndex = 1;
            // 
            // cbComutative
            // 
            this.cbComutative.AutoSize = true;
            this.cbComutative.Location = new System.Drawing.Point(121, 287);
            this.cbComutative.Name = "cbComutative";
            this.cbComutative.Size = new System.Drawing.Size(88, 19);
            this.cbComutative.TabIndex = 13;
            this.cbComutative.Text = "Comutativa";
            this.cbComutative.UseVisualStyleBackColor = true;
            // 
            // pbAwards
            // 
            this.pbAwards.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAwards.Image = global::O_Campeonato_das_Tabuadas.Properties.Resources.awards;
            this.pbAwards.Location = new System.Drawing.Point(8, 8);
            this.pbAwards.Name = "pbAwards";
            this.pbAwards.Size = new System.Drawing.Size(45, 45);
            this.pbAwards.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAwards.TabIndex = 12;
            this.pbAwards.TabStop = false;
            this.pbAwards.Click += new System.EventHandler(this.pbAwards_Click);
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(34, 239);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(83, 15);
            this.lblMax.TabIndex = 11;
            this.lblMax.Text = "Valor Máximo:";
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Location = new System.Drawing.Point(34, 186);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(105, 15);
            this.lblQtd.TabIndex = 10;
            this.lblQtd.Text = "Qtd. de Perguntas:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(80, 334);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Começar";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // nudMax
            // 
            this.nudMax.Location = new System.Drawing.Point(162, 237);
            this.nudMax.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudMax.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudMax.Name = "nudMax";
            this.nudMax.Size = new System.Drawing.Size(47, 23);
            this.nudMax.TabIndex = 8;
            this.nudMax.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // nudQtd
            // 
            this.nudQtd.Location = new System.Drawing.Point(162, 184);
            this.nudQtd.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudQtd.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudQtd.Name = "nudQtd";
            this.nudQtd.Size = new System.Drawing.Size(47, 23);
            this.nudQtd.TabIndex = 7;
            this.nudQtd.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // tbTabuada
            // 
            this.tbTabuada.Location = new System.Drawing.Point(162, 132);
            this.tbTabuada.MaxLength = 3;
            this.tbTabuada.Name = "tbTabuada";
            this.tbTabuada.Size = new System.Drawing.Size(47, 23);
            this.tbTabuada.TabIndex = 6;
            this.tbTabuada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbTabuada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTabuada_KeyPress);
            // 
            // pbNTabuada
            // 
            this.pbNTabuada.Image = global::O_Campeonato_das_Tabuadas.Properties.Resources.tabuadaX;
            this.pbNTabuada.Location = new System.Drawing.Point(34, 114);
            this.pbNTabuada.Name = "pbNTabuada";
            this.pbNTabuada.Size = new System.Drawing.Size(40, 40);
            this.pbNTabuada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNTabuada.TabIndex = 5;
            this.pbNTabuada.TabStop = false;
            // 
            // pbBack
            // 
            this.pbBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBack.Image = global::O_Campeonato_das_Tabuadas.Properties.Resources.back;
            this.pbBack.Location = new System.Drawing.Point(8, 408);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(45, 45);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBack.TabIndex = 3;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // lblTabuada
            // 
            this.lblTabuada.AutoSize = true;
            this.lblTabuada.Location = new System.Drawing.Point(80, 114);
            this.lblTabuada.Name = "lblTabuada";
            this.lblTabuada.Size = new System.Drawing.Size(54, 15);
            this.lblTabuada.TabIndex = 4;
            this.lblTabuada.Text = "Tabuada:";
            // 
            // pbCalculator
            // 
            this.pbCalculator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCalculator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCalculator.Image = global::O_Campeonato_das_Tabuadas.Properties.Resources.calculator;
            this.pbCalculator.Location = new System.Drawing.Point(198, 8);
            this.pbCalculator.Name = "pbCalculator";
            this.pbCalculator.Size = new System.Drawing.Size(45, 45);
            this.pbCalculator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCalculator.TabIndex = 2;
            this.pbCalculator.TabStop = false;
            this.pbCalculator.Click += new System.EventHandler(this.pbCalculator_Click);
            // 
            // cbShuffle
            // 
            this.cbShuffle.AutoSize = true;
            this.cbShuffle.Location = new System.Drawing.Point(34, 287);
            this.cbShuffle.Name = "cbShuffle";
            this.cbShuffle.Size = new System.Drawing.Size(74, 19);
            this.cbShuffle.TabIndex = 0;
            this.cbShuffle.Text = "Aleatório";
            this.cbShuffle.UseVisualStyleBackColor = true;
            // 
            // pgbCompletition
            // 
            this.pgbCompletition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pgbCompletition.Location = new System.Drawing.Point(422, 426);
            this.pgbCompletition.Name = "pgbCompletition";
            this.pgbCompletition.Size = new System.Drawing.Size(150, 23);
            this.pgbCompletition.TabIndex = 2;
            this.pgbCompletition.Visible = false;
            // 
            // pbCorrect
            // 
            this.pbCorrect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbCorrect.Image = global::O_Campeonato_das_Tabuadas.Properties.Resources.correct;
            this.pbCorrect.Location = new System.Drawing.Point(12, 426);
            this.pbCorrect.Name = "pbCorrect";
            this.pbCorrect.Size = new System.Drawing.Size(23, 23);
            this.pbCorrect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCorrect.TabIndex = 3;
            this.pbCorrect.TabStop = false;
            this.pbCorrect.Visible = false;
            // 
            // pbWrong
            // 
            this.pbWrong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbWrong.Image = global::O_Campeonato_das_Tabuadas.Properties.Resources.wrong;
            this.pbWrong.Location = new System.Drawing.Point(93, 426);
            this.pbWrong.Name = "pbWrong";
            this.pbWrong.Size = new System.Drawing.Size(23, 23);
            this.pbWrong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWrong.TabIndex = 4;
            this.pbWrong.TabStop = false;
            this.pbWrong.Visible = false;
            // 
            // lblCorrect
            // 
            this.lblCorrect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCorrect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(185)))), ((int)(((byte)(119)))));
            this.lblCorrect.Location = new System.Drawing.Point(39, 428);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(33, 19);
            this.lblCorrect.TabIndex = 5;
            this.lblCorrect.Text = "null";
            this.lblCorrect.Visible = false;
            // 
            // lblWrong
            // 
            this.lblWrong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblWrong.AutoSize = true;
            this.lblWrong.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWrong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.lblWrong.Location = new System.Drawing.Point(120, 428);
            this.lblWrong.Name = "lblWrong";
            this.lblWrong.Size = new System.Drawing.Size(33, 19);
            this.lblWrong.TabIndex = 7;
            this.lblWrong.Text = "null";
            this.lblWrong.Visible = false;
            // 
            // lblProblemN
            // 
            this.lblProblemN.AutoSize = true;
            this.lblProblemN.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProblemN.Location = new System.Drawing.Point(12, 9);
            this.lblProblemN.Name = "lblProblemN";
            this.lblProblemN.Size = new System.Drawing.Size(66, 32);
            this.lblProblemN.TabIndex = 8;
            this.lblProblemN.Text = "0 / X";
            this.lblProblemN.Visible = false;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTime.Location = new System.Drawing.Point(500, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(72, 32);
            this.lblTime.TabIndex = 9;
            this.lblTime.Text = "00:00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblTime.Visible = false;
            // 
            // lblProblem
            // 
            this.lblProblem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProblem.AutoSize = true;
            this.lblProblem.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProblem.Location = new System.Drawing.Point(3, 0);
            this.lblProblem.Name = "lblProblem";
            this.lblProblem.Size = new System.Drawing.Size(554, 188);
            this.lblProblem.TabIndex = 10;
            this.lblProblem.Text = "0 × 0";
            this.lblProblem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbAnswer
            // 
            this.tbAnswer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbAnswer.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbAnswer.Location = new System.Drawing.Point(205, 191);
            this.tbAnswer.MaxLength = 6;
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.PlaceholderText = "XX";
            this.tbAnswer.Size = new System.Drawing.Size(150, 61);
            this.tbAnswer.TabIndex = 12;
            this.tbAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAnswer.Visible = false;
            this.tbAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAnswer_KeyPress);
            // 
            // pGame
            // 
            this.pGame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pGame.Controls.Add(this.lblProblemN);
            this.pGame.Controls.Add(this.lblCorrect);
            this.pGame.Controls.Add(this.pbCorrect);
            this.pGame.Controls.Add(this.lblTime);
            this.pGame.Controls.Add(this.pbWrong);
            this.pGame.Controls.Add(this.pgbCompletition);
            this.pGame.Controls.Add(this.lblWrong);
            this.pGame.Controls.Add(this.tlpProblem);
            this.pGame.Controls.Add(this.tlpNoGameInfo);
            this.pGame.Location = new System.Drawing.Point(250, 0);
            this.pGame.Name = "pGame";
            this.pGame.Size = new System.Drawing.Size(584, 461);
            this.pGame.TabIndex = 12;
            // 
            // tlpProblem
            // 
            this.tlpProblem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpProblem.ColumnCount = 1;
            this.tlpProblem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpProblem.Controls.Add(this.tbAnswer, 0, 1);
            this.tlpProblem.Controls.Add(this.lblProblem, 0, 0);
            this.tlpProblem.Location = new System.Drawing.Point(12, 44);
            this.tlpProblem.Name = "tlpProblem";
            this.tlpProblem.RowCount = 2;
            this.tlpProblem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpProblem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpProblem.Size = new System.Drawing.Size(560, 376);
            this.tlpProblem.TabIndex = 13;
            this.tlpProblem.Visible = false;
            // 
            // tlpNoGameInfo
            // 
            this.tlpNoGameInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpNoGameInfo.ColumnCount = 1;
            this.tlpNoGameInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpNoGameInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpNoGameInfo.Controls.Add(this.pbWinLose, 0, 0);
            this.tlpNoGameInfo.Controls.Add(this.lblNoGameInfo, 0, 1);
            this.tlpNoGameInfo.Location = new System.Drawing.Point(12, 79);
            this.tlpNoGameInfo.Name = "tlpNoGameInfo";
            this.tlpNoGameInfo.RowCount = 2;
            this.tlpNoGameInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpNoGameInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpNoGameInfo.Size = new System.Drawing.Size(560, 207);
            this.tlpNoGameInfo.TabIndex = 14;
            // 
            // pbWinLose
            // 
            this.pbWinLose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbWinLose.Image = global::O_Campeonato_das_Tabuadas.Properties.Resources.win;
            this.pbWinLose.Location = new System.Drawing.Point(3, 3);
            this.pbWinLose.Name = "pbWinLose";
            this.pbWinLose.Size = new System.Drawing.Size(554, 97);
            this.pbWinLose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWinLose.TabIndex = 1;
            this.pbWinLose.TabStop = false;
            this.pbWinLose.Visible = false;
            // 
            // lblNoGameInfo
            // 
            this.lblNoGameInfo.AutoSize = true;
            this.lblNoGameInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNoGameInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNoGameInfo.Location = new System.Drawing.Point(3, 103);
            this.lblNoGameInfo.Name = "lblNoGameInfo";
            this.lblNoGameInfo.Size = new System.Drawing.Size(554, 104);
            this.lblNoGameInfo.TabIndex = 0;
            this.lblNoGameInfo.Text = "Configure e inicie um jogo através das configurações ao lado";
            this.lblNoGameInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pAwards
            // 
            this.pAwards.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pAwards.Controls.Add(this.lvwAwards);
            this.pAwards.Controls.Add(this.lblTextAwards);
            this.pAwards.Controls.Add(this.lblAwards);
            this.pAwards.Location = new System.Drawing.Point(250, 0);
            this.pAwards.Name = "pAwards";
            this.pAwards.Size = new System.Drawing.Size(584, 461);
            this.pAwards.TabIndex = 13;
            // 
            // lvwAwards
            // 
            this.lvwAwards.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwAwards.LargeImageList = this.ilAwards;
            this.lvwAwards.Location = new System.Drawing.Point(15, 97);
            this.lvwAwards.Name = "lvwAwards";
            this.lvwAwards.Size = new System.Drawing.Size(554, 350);
            this.lvwAwards.TabIndex = 13;
            this.lvwAwards.UseCompatibleStateImageBehavior = false;
            // 
            // ilAwards
            // 
            this.ilAwards.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ilAwards.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilAwards.ImageStream")));
            this.ilAwards.TransparentColor = System.Drawing.Color.Transparent;
            this.ilAwards.Images.SetKeyName(0, "A1.png");
            this.ilAwards.Images.SetKeyName(1, "A1G.png");
            this.ilAwards.Images.SetKeyName(2, "A1R.png");
            this.ilAwards.Images.SetKeyName(3, "A2.png");
            this.ilAwards.Images.SetKeyName(4, "A2G.png");
            this.ilAwards.Images.SetKeyName(5, "A2R.png");
            this.ilAwards.Images.SetKeyName(6, "A3.png");
            this.ilAwards.Images.SetKeyName(7, "A3G.png");
            this.ilAwards.Images.SetKeyName(8, "A3R.png");
            this.ilAwards.Images.SetKeyName(9, "A4.png");
            this.ilAwards.Images.SetKeyName(10, "A4G.png");
            this.ilAwards.Images.SetKeyName(11, "A4R.png");
            this.ilAwards.Images.SetKeyName(12, "A5.png");
            this.ilAwards.Images.SetKeyName(13, "A5G.png");
            this.ilAwards.Images.SetKeyName(14, "A5R.png");
            this.ilAwards.Images.SetKeyName(15, "A6.png");
            this.ilAwards.Images.SetKeyName(16, "A6G.png");
            this.ilAwards.Images.SetKeyName(17, "A6R.png");
            this.ilAwards.Images.SetKeyName(18, "A7.png");
            this.ilAwards.Images.SetKeyName(19, "A7G.png");
            this.ilAwards.Images.SetKeyName(20, "A7R.png");
            this.ilAwards.Images.SetKeyName(21, "A8.png");
            this.ilAwards.Images.SetKeyName(22, "A8G.png");
            this.ilAwards.Images.SetKeyName(23, "A8R.png");
            this.ilAwards.Images.SetKeyName(24, "A9.png");
            this.ilAwards.Images.SetKeyName(25, "A9G.png");
            this.ilAwards.Images.SetKeyName(26, "A9R.png");
            this.ilAwards.Images.SetKeyName(27, "AX.png");
            this.ilAwards.Images.SetKeyName(28, "AXG.png");
            this.ilAwards.Images.SetKeyName(29, "AXR.png");
            this.ilAwards.Images.SetKeyName(30, "C100.png");
            this.ilAwards.Images.SetKeyName(31, "C300.png");
            this.ilAwards.Images.SetKeyName(32, "C1000.png");
            this.ilAwards.Images.SetKeyName(33, "T30.png");
            this.ilAwards.Images.SetKeyName(34, "T10.png");
            this.ilAwards.Images.SetKeyName(35, "F1.png");
            this.ilAwards.Images.SetKeyName(36, "F2.png");
            // 
            // lblTextAwards
            // 
            this.lblTextAwards.AutoSize = true;
            this.lblTextAwards.Location = new System.Drawing.Point(15, 61);
            this.lblTextAwards.Name = "lblTextAwards";
            this.lblTextAwards.Size = new System.Drawing.Size(307, 15);
            this.lblTextAwards.TabIndex = 12;
            this.lblTextAwards.Text = "Aqui estão todas as medalhas que conseguiste até agora:";
            // 
            // lblAwards
            // 
            this.lblAwards.AutoSize = true;
            this.lblAwards.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAwards.Location = new System.Drawing.Point(6, 9);
            this.lblAwards.Name = "lblAwards";
            this.lblAwards.Size = new System.Drawing.Size(164, 45);
            this.lblAwards.TabIndex = 10;
            this.lblAwards.Text = "Medalhas";
            // 
            // tTime
            // 
            this.tTime.Interval = 1000;
            this.tTime.Tick += new System.EventHandler(this.tTime_Tick);
            // 
            // pbNotebook
            // 
            this.pbNotebook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbNotebook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbNotebook.Image = global::O_Campeonato_das_Tabuadas.Properties.Resources.book;
            this.pbNotebook.Location = new System.Drawing.Point(198, 408);
            this.pbNotebook.Name = "pbNotebook";
            this.pbNotebook.Size = new System.Drawing.Size(45, 45);
            this.pbNotebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNotebook.TabIndex = 14;
            this.pbNotebook.TabStop = false;
            this.pbNotebook.Click += new System.EventHandler(this.pbNotebook_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.pSide);
            this.Controls.Add(this.pGame);
            this.Controls.Add(this.pAwards);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(850, 500);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "O Campeonato das Tabuadas";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.pSide.ResumeLayout(false);
            this.pSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAwards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNTabuada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCalculator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWrong)).EndInit();
            this.pGame.ResumeLayout(false);
            this.pGame.PerformLayout();
            this.tlpProblem.ResumeLayout(false);
            this.tlpProblem.PerformLayout();
            this.tlpNoGameInfo.ResumeLayout(false);
            this.tlpNoGameInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWinLose)).EndInit();
            this.pAwards.ResumeLayout(false);
            this.pAwards.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotebook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbTabuada;
        private System.Windows.Forms.Panel pSide;
        private System.Windows.Forms.Label lblTabuada;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.PictureBox pbCalculator;
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
        private System.Windows.Forms.PictureBox pbAwards;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.Panel pGame;
        private System.Windows.Forms.Panel pAwards;
        private System.Windows.Forms.TableLayoutPanel tlpProblem;
        private System.Windows.Forms.CheckBox cbComutative;
        private System.Windows.Forms.Timer tTime;
        private System.Windows.Forms.TableLayoutPanel tlpNoGameInfo;
        private System.Windows.Forms.Label lblNoGameInfo;
        private System.Windows.Forms.PictureBox pbWinLose;
        private System.Windows.Forms.Label lblAwards;
        private System.Windows.Forms.Label lblTextAwards;
        private System.Windows.Forms.ListView lvwAwards;
        private System.Windows.Forms.ImageList ilAwards;
        private System.Windows.Forms.PictureBox pbNotebook;
    }
}

