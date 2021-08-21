namespace workout_app
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbxWorkOut = new System.Windows.Forms.ListBox();
            this.lbWrkOut = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.tmrWrkOut = new System.Windows.Forms.Timer(this.components);
            this.lbActivity = new System.Windows.Forms.Label();
            this.tmrWork2 = new System.Windows.Forms.Timer(this.components);
            this.lbClicker = new System.Windows.Forms.Label();
            this.lbExTtlTime = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbNextLb = new System.Windows.Forms.Label();
            this.lbNextName = new System.Windows.Forms.Label();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lbRnTime = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.Button();
            this.tbMain = new System.Windows.Forms.TabControl();
            this.tbRoutine = new System.Windows.Forms.TabPage();
            this.btn_Del = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbxType = new System.Windows.Forms.ListBox();
            this.lcCurrEx = new System.Windows.Forms.Label();
            this.grdExercise = new System.Windows.Forms.DataGridView();
            this.pBxExercise = new System.Windows.Forms.PictureBox();
            this.tbAddEx = new System.Windows.Forms.TabPage();
            this.txtExName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbErr = new System.Windows.Forms.Label();
            this.btnExrcs = new System.Windows.Forms.Button();
            this.lbExype = new System.Windows.Forms.Label();
            this.chkNB = new System.Windows.Forms.CheckBox();
            this.chkFB = new System.Windows.Forms.CheckBox();
            this.ChkLG = new System.Windows.Forms.CheckBox();
            this.chKAB = new System.Windows.Forms.CheckBox();
            this.chkUB = new System.Windows.Forms.CheckBox();
            this.chk30 = new System.Windows.Forms.CheckBox();
            this.chk20 = new System.Windows.Forms.CheckBox();
            this.chk15 = new System.Windows.Forms.CheckBox();
            this.lbExtime = new System.Windows.Forms.Label();
            this.chk10 = new System.Windows.Forms.CheckBox();
            this.tbPerf = new System.Windows.Forms.TabPage();
            this.lbPrfCalVal = new System.Windows.Forms.Label();
            this.lbPrfCal = new System.Windows.Forms.Label();
            this.lbPrfMinsVal = new System.Windows.Forms.Label();
            this.lbPrfMins = new System.Windows.Forms.Label();
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.lbxPerfDt = new System.Windows.Forms.ListBox();
            this.lbDtPrf = new System.Windows.Forms.Label();
            this.tbFood = new System.Windows.Forms.TabPage();
            this.formsPlot2 = new ScottPlot.FormsPlot();
            this.lbErrFd = new System.Windows.Forms.Label();
            this.btnFood = new System.Windows.Forms.Button();
            this.txtCalCnt = new System.Windows.Forms.TextBox();
            this.txtFoodDesc = new System.Windows.Forms.TextBox();
            this.lbFoodExp = new System.Windows.Forms.Label();
            this.lbCalCount = new System.Windows.Forms.Label();
            this.lbMeal = new System.Windows.Forms.Label();
            this.lbxMeal = new System.Windows.Forms.ListBox();
            this.formsPlot3 = new ScottPlot.FormsPlot();
            this.tbMain.SuspendLayout();
            this.tbRoutine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdExercise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBxExercise)).BeginInit();
            this.tbAddEx.SuspendLayout();
            this.tbPerf.SuspendLayout();
            this.tbFood.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxWorkOut
            // 
            this.lbxWorkOut.FormattingEnabled = true;
            this.lbxWorkOut.ItemHeight = 31;
            this.lbxWorkOut.Location = new System.Drawing.Point(30, 85);
            this.lbxWorkOut.Margin = new System.Windows.Forms.Padding(5);
            this.lbxWorkOut.Name = "lbxWorkOut";
            this.lbxWorkOut.Size = new System.Drawing.Size(490, 345);
            this.lbxWorkOut.TabIndex = 0;
            this.lbxWorkOut.SelectedIndexChanged += new System.EventHandler(this.lbxWorkOut_SelectedIndexChanged);
            // 
            // lbWrkOut
            // 
            this.lbWrkOut.AutoSize = true;
            this.lbWrkOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWrkOut.Location = new System.Drawing.Point(535, 31);
            this.lbWrkOut.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbWrkOut.Name = "lbWrkOut";
            this.lbWrkOut.Size = new System.Drawing.Size(281, 46);
            this.lbWrkOut.TabIndex = 1;
            this.lbWrkOut.Text = "Workout Type";
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnRun.Location = new System.Drawing.Point(30, 455);
            this.btnRun.Margin = new System.Windows.Forms.Padding(5);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(240, 117);
            this.btnRun.TabIndex = 7;
            this.btnRun.Text = "Run Workout";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // tmrWrkOut
            // 
            this.tmrWrkOut.Interval = 1000;
            this.tmrWrkOut.Tick += new System.EventHandler(this.tmrWrkOut_Tick);
            // 
            // lbActivity
            // 
            this.lbActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbActivity.Location = new System.Drawing.Point(1600, 2);
            this.lbActivity.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbActivity.Name = "lbActivity";
            this.lbActivity.Size = new System.Drawing.Size(1450, 95);
            this.lbActivity.TabIndex = 10;
            this.lbActivity.Text = "Exercise";
            this.lbActivity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tmrWork2
            // 
            this.tmrWork2.Interval = 1000;
            this.tmrWork2.Tick += new System.EventHandler(this.tmrWork2_Tick);
            // 
            // lbClicker
            // 
            this.lbClicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClicker.Location = new System.Drawing.Point(30, 850);
            this.lbClicker.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbClicker.Name = "lbClicker";
            this.lbClicker.Size = new System.Drawing.Size(475, 200);
            this.lbClicker.TabIndex = 14;
            this.lbClicker.Text = "0";
            this.lbClicker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbExTtlTime
            // 
            this.lbExTtlTime.AutoSize = true;
            this.lbExTtlTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExTtlTime.Location = new System.Drawing.Point(30, 775);
            this.lbExTtlTime.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbExTtlTime.MaximumSize = new System.Drawing.Size(800, 76);
            this.lbExTtlTime.MinimumSize = new System.Drawing.Size(475, 75);
            this.lbExTtlTime.Name = "lbExTtlTime";
            this.lbExTtlTime.Size = new System.Drawing.Size(475, 75);
            this.lbExTtlTime.TabIndex = 15;
            this.lbExTtlTime.Text = "Total Exercise Time";
            // 
            // lbTime
            // 
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(2400, 630);
            this.lbTime.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(501, 76);
            this.lbTime.TabIndex = 16;
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNextLb
            // 
            this.lbNextLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNextLb.Location = new System.Drawing.Point(850, 120);
            this.lbNextLb.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbNextLb.Name = "lbNextLb";
            this.lbNextLb.Size = new System.Drawing.Size(568, 95);
            this.lbNextLb.TabIndex = 17;
            this.lbNextLb.Text = "Next Exercise";
            this.lbNextLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbNextName
            // 
            this.lbNextName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNextName.Location = new System.Drawing.Point(1600, 115);
            this.lbNextName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbNextName.MaximumSize = new System.Drawing.Size(1550, 100);
            this.lbNextName.Name = "lbNextName";
            this.lbNextName.Size = new System.Drawing.Size(1450, 100);
            this.lbNextName.TabIndex = 18;
            this.lbNextName.Text = "Next Exercise";
            this.lbNextName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tmrMain
            // 
            this.tmrMain.Interval = 1000;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 1100);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 145);
            this.label1.TabIndex = 20;
            this.label1.Text = "Total Run Time";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbRnTime
            // 
            this.lbRnTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRnTime.Location = new System.Drawing.Point(30, 1250);
            this.lbRnTime.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbRnTime.Name = "lbRnTime";
            this.lbRnTime.Size = new System.Drawing.Size(475, 250);
            this.lbRnTime.TabIndex = 21;
            this.lbRnTime.Text = "0";
            this.lbRnTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPause
            // 
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnPause.Location = new System.Drawing.Point(30, 600);
            this.btnPause.Margin = new System.Windows.Forms.Padding(5);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(240, 114);
            this.btnPause.TabIndex = 22;
            this.btnPause.Text = "Reset";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // tbMain
            // 
            this.tbMain.Controls.Add(this.tbRoutine);
            this.tbMain.Controls.Add(this.tbAddEx);
            this.tbMain.Controls.Add(this.tbPerf);
            this.tbMain.Controls.Add(this.tbFood);
            this.tbMain.Location = new System.Drawing.Point(32, 12);
            this.tbMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMain.Name = "tbMain";
            this.tbMain.SelectedIndex = 0;
            this.tbMain.Size = new System.Drawing.Size(3917, 1724);
            this.tbMain.TabIndex = 23;
            this.tbMain.SelectedIndexChanged += new System.EventHandler(this.tbMain_SelectedIndexChanged);
            // 
            // tbRoutine
            // 
            this.tbRoutine.Controls.Add(this.btn_Del);
            this.tbRoutine.Controls.Add(this.label2);
            this.tbRoutine.Controls.Add(this.lbxType);
            this.tbRoutine.Controls.Add(this.lcCurrEx);
            this.tbRoutine.Controls.Add(this.grdExercise);
            this.tbRoutine.Controls.Add(this.pBxExercise);
            this.tbRoutine.Controls.Add(this.lbRnTime);
            this.tbRoutine.Controls.Add(this.btnPause);
            this.tbRoutine.Controls.Add(this.label1);
            this.tbRoutine.Controls.Add(this.lbWrkOut);
            this.tbRoutine.Controls.Add(this.lbxWorkOut);
            this.tbRoutine.Controls.Add(this.lbNextName);
            this.tbRoutine.Controls.Add(this.lbClicker);
            this.tbRoutine.Controls.Add(this.lbExTtlTime);
            this.tbRoutine.Controls.Add(this.btnRun);
            this.tbRoutine.Controls.Add(this.lbNextLb);
            this.tbRoutine.Controls.Add(this.lbActivity);
            this.tbRoutine.Location = new System.Drawing.Point(10, 48);
            this.tbRoutine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRoutine.Name = "tbRoutine";
            this.tbRoutine.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRoutine.Size = new System.Drawing.Size(3897, 1666);
            this.tbRoutine.TabIndex = 0;
            this.tbRoutine.Text = "Exercise Routine";
            this.tbRoutine.UseVisualStyleBackColor = true;
            // 
            // btn_Del
            // 
            this.btn_Del.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_Del.Location = new System.Drawing.Point(280, 455);
            this.btn_Del.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(240, 117);
            this.btn_Del.TabIndex = 27;
            this.btn_Del.Text = "Delete Workout";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 46);
            this.label2.TabIndex = 26;
            this.label2.Text = "Workout Type";
            // 
            // lbxType
            // 
            this.lbxType.FormattingEnabled = true;
            this.lbxType.ItemHeight = 31;
            this.lbxType.Location = new System.Drawing.Point(535, 85);
            this.lbxType.MinimumSize = new System.Drawing.Size(4, 150);
            this.lbxType.Name = "lbxType";
            this.lbxType.Size = new System.Drawing.Size(286, 159);
            this.lbxType.TabIndex = 25;
            this.lbxType.SelectedIndexChanged += new System.EventHandler(this.lbxType_SelectedIndexChanged);
            // 
            // lcCurrEx
            // 
            this.lcCurrEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcCurrEx.Location = new System.Drawing.Point(850, 2);
            this.lcCurrEx.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lcCurrEx.Name = "lcCurrEx";
            this.lcCurrEx.Size = new System.Drawing.Size(550, 95);
            this.lcCurrEx.TabIndex = 24;
            this.lcCurrEx.Text = "Current Exercise";
            this.lcCurrEx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grdExercise
            // 
            this.grdExercise.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdExercise.Location = new System.Drawing.Point(3072, 246);
            this.grdExercise.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdExercise.Name = "grdExercise";
            this.grdExercise.RowHeadersWidth = 33;
            this.grdExercise.RowTemplate.Height = 40;
            this.grdExercise.Size = new System.Drawing.Size(781, 1326);
            this.grdExercise.TabIndex = 23;
            this.grdExercise.SelectionChanged += new System.EventHandler(this.grdExercise_SelectionChanged);
            // 
            // pBxExercise
            // 
            this.pBxExercise.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pBxExercise.ErrorImage")));
            this.pBxExercise.InitialImage = ((System.Drawing.Image)(resources.GetObject("pBxExercise.InitialImage")));
            this.pBxExercise.Location = new System.Drawing.Point(535, 250);
            this.pBxExercise.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.pBxExercise.MaximumSize = new System.Drawing.Size(875, 500);
            this.pBxExercise.MinimumSize = new System.Drawing.Size(800, 450);
            this.pBxExercise.Name = "pBxExercise";
            this.pBxExercise.Size = new System.Drawing.Size(850, 500);
            this.pBxExercise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pBxExercise.TabIndex = 13;
            this.pBxExercise.TabStop = false;
            // 
            // tbAddEx
            // 
            this.tbAddEx.Controls.Add(this.txtExName);
            this.tbAddEx.Controls.Add(this.label3);
            this.tbAddEx.Controls.Add(this.lbErr);
            this.tbAddEx.Controls.Add(this.btnExrcs);
            this.tbAddEx.Controls.Add(this.lbExype);
            this.tbAddEx.Controls.Add(this.chkNB);
            this.tbAddEx.Controls.Add(this.chkFB);
            this.tbAddEx.Controls.Add(this.ChkLG);
            this.tbAddEx.Controls.Add(this.chKAB);
            this.tbAddEx.Controls.Add(this.chkUB);
            this.tbAddEx.Controls.Add(this.chk30);
            this.tbAddEx.Controls.Add(this.chk20);
            this.tbAddEx.Controls.Add(this.chk15);
            this.tbAddEx.Controls.Add(this.lbExtime);
            this.tbAddEx.Controls.Add(this.chk10);
            this.tbAddEx.Location = new System.Drawing.Point(10, 48);
            this.tbAddEx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAddEx.Name = "tbAddEx";
            this.tbAddEx.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAddEx.Size = new System.Drawing.Size(3897, 1666);
            this.tbAddEx.TabIndex = 1;
            this.tbAddEx.Text = "Exercise Add";
            this.tbAddEx.UseVisualStyleBackColor = true;
            // 
            // txtExName
            // 
            this.txtExName.Location = new System.Drawing.Point(1608, 193);
            this.txtExName.Name = "txtExName";
            this.txtExName.Size = new System.Drawing.Size(200, 38);
            this.txtExName.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1599, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.MaximumSize = new System.Drawing.Size(800, 76);
            this.label3.MinimumSize = new System.Drawing.Size(501, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(501, 76);
            this.label3.TabIndex = 28;
            this.label3.Text = "Exercise Name";
            // 
            // lbErr
            // 
            this.lbErr.AutoSize = true;
            this.lbErr.Location = new System.Drawing.Point(1602, 373);
            this.lbErr.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbErr.Name = "lbErr";
            this.lbErr.Size = new System.Drawing.Size(75, 32);
            this.lbErr.TabIndex = 27;
            this.lbErr.Text = "lbErr";
            // 
            // btnExrcs
            // 
            this.btnExrcs.Location = new System.Drawing.Point(157, 584);
            this.btnExrcs.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnExrcs.Name = "btnExrcs";
            this.btnExrcs.Size = new System.Drawing.Size(200, 162);
            this.btnExrcs.TabIndex = 26;
            this.btnExrcs.Text = "Make Exercise";
            this.btnExrcs.UseVisualStyleBackColor = true;
            this.btnExrcs.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbExype
            // 
            this.lbExype.AutoSize = true;
            this.lbExype.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExype.Location = new System.Drawing.Point(1115, 88);
            this.lbExype.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbExype.MaximumSize = new System.Drawing.Size(800, 76);
            this.lbExype.MinimumSize = new System.Drawing.Size(501, 76);
            this.lbExype.Name = "lbExype";
            this.lbExype.Size = new System.Drawing.Size(501, 76);
            this.lbExype.TabIndex = 25;
            this.lbExype.Text = "Exercise Type";
            // 
            // chkNB
            // 
            this.chkNB.AutoSize = true;
            this.chkNB.Location = new System.Drawing.Point(1125, 565);
            this.chkNB.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.chkNB.Name = "chkNB";
            this.chkNB.Size = new System.Drawing.Size(184, 36);
            this.chkNB.TabIndex = 24;
            this.chkNB.Text = "No Breaks";
            this.chkNB.UseVisualStyleBackColor = true;
            this.chkNB.CheckedChanged += new System.EventHandler(this.fnchk_Exercise);
            // 
            // chkFB
            // 
            this.chkFB.AutoSize = true;
            this.chkFB.Location = new System.Drawing.Point(1125, 491);
            this.chkFB.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.chkFB.Name = "chkFB";
            this.chkFB.Size = new System.Drawing.Size(172, 36);
            this.chkFB.TabIndex = 23;
            this.chkFB.Text = "Full Body";
            this.chkFB.UseVisualStyleBackColor = true;
            this.chkFB.CheckedChanged += new System.EventHandler(this.fnchk_Exercise);
            // 
            // ChkLG
            // 
            this.ChkLG.AutoSize = true;
            this.ChkLG.Location = new System.Drawing.Point(1125, 403);
            this.ChkLG.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ChkLG.Name = "ChkLG";
            this.ChkLG.Size = new System.Drawing.Size(115, 36);
            this.ChkLG.TabIndex = 22;
            this.ChkLG.Text = "Legs";
            this.ChkLG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChkLG.UseVisualStyleBackColor = true;
            this.ChkLG.CheckedChanged += new System.EventHandler(this.fnchk_Exercise);
            // 
            // chKAB
            // 
            this.chKAB.AutoSize = true;
            this.chKAB.Location = new System.Drawing.Point(1125, 322);
            this.chKAB.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.chKAB.Name = "chKAB";
            this.chKAB.Size = new System.Drawing.Size(102, 36);
            this.chKAB.TabIndex = 21;
            this.chKAB.Text = "Abs";
            this.chKAB.UseVisualStyleBackColor = true;
            this.chKAB.CheckedChanged += new System.EventHandler(this.fnchk_Exercise);
            // 
            // chkUB
            // 
            this.chkUB.AutoSize = true;
            this.chkUB.Location = new System.Drawing.Point(1125, 234);
            this.chkUB.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.chkUB.Name = "chkUB";
            this.chkUB.Size = new System.Drawing.Size(202, 36);
            this.chkUB.TabIndex = 20;
            this.chkUB.Text = "Upper Body";
            this.chkUB.UseVisualStyleBackColor = true;
            this.chkUB.CheckedChanged += new System.EventHandler(this.fnchk_Exercise);
            // 
            // chk30
            // 
            this.chk30.AutoSize = true;
            this.chk30.Location = new System.Drawing.Point(157, 491);
            this.chk30.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.chk30.Name = "chk30";
            this.chk30.Size = new System.Drawing.Size(206, 36);
            this.chk30.TabIndex = 19;
            this.chk30.Text = "30 Minsutes";
            this.chk30.UseVisualStyleBackColor = true;
            this.chk30.CheckedChanged += new System.EventHandler(this.fnchk_Time);
            // 
            // chk20
            // 
            this.chk20.AutoSize = true;
            this.chk20.Location = new System.Drawing.Point(157, 403);
            this.chk20.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.chk20.Name = "chk20";
            this.chk20.Size = new System.Drawing.Size(192, 36);
            this.chk20.TabIndex = 18;
            this.chk20.Text = "20 Minutes";
            this.chk20.UseVisualStyleBackColor = true;
            this.chk20.CheckedChanged += new System.EventHandler(this.fnchk_Time);
            // 
            // chk15
            // 
            this.chk15.AutoSize = true;
            this.chk15.Location = new System.Drawing.Point(157, 322);
            this.chk15.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.chk15.Name = "chk15";
            this.chk15.Size = new System.Drawing.Size(192, 36);
            this.chk15.TabIndex = 17;
            this.chk15.Text = "15 Minutes";
            this.chk15.UseVisualStyleBackColor = true;
            this.chk15.CheckedChanged += new System.EventHandler(this.fnchk_Time);
            // 
            // lbExtime
            // 
            this.lbExtime.AutoSize = true;
            this.lbExtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExtime.Location = new System.Drawing.Point(147, 88);
            this.lbExtime.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbExtime.MaximumSize = new System.Drawing.Size(800, 76);
            this.lbExtime.MinimumSize = new System.Drawing.Size(501, 76);
            this.lbExtime.Name = "lbExtime";
            this.lbExtime.Size = new System.Drawing.Size(501, 76);
            this.lbExtime.TabIndex = 16;
            this.lbExtime.Text = "Total Exercise Time";
            // 
            // chk10
            // 
            this.chk10.AutoSize = true;
            this.chk10.Location = new System.Drawing.Point(157, 234);
            this.chk10.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.chk10.Name = "chk10";
            this.chk10.Size = new System.Drawing.Size(192, 36);
            this.chk10.TabIndex = 0;
            this.chk10.Text = "10 Minutes";
            this.chk10.UseVisualStyleBackColor = true;
            this.chk10.CheckedChanged += new System.EventHandler(this.fnchk_Time);
            // 
            // tbPerf
            // 
            this.tbPerf.Controls.Add(this.lbPrfCalVal);
            this.tbPerf.Controls.Add(this.lbPrfCal);
            this.tbPerf.Controls.Add(this.lbPrfMinsVal);
            this.tbPerf.Controls.Add(this.lbPrfMins);
            this.tbPerf.Controls.Add(this.formsPlot1);
            this.tbPerf.Controls.Add(this.lbxPerfDt);
            this.tbPerf.Controls.Add(this.lbDtPrf);
            this.tbPerf.Location = new System.Drawing.Point(10, 48);
            this.tbPerf.Name = "tbPerf";
            this.tbPerf.Size = new System.Drawing.Size(3897, 1666);
            this.tbPerf.TabIndex = 2;
            this.tbPerf.Text = "Performance";
            this.tbPerf.UseVisualStyleBackColor = true;
            // 
            // lbPrfCalVal
            // 
            this.lbPrfCalVal.AutoSize = true;
            this.lbPrfCalVal.Location = new System.Drawing.Point(1789, 166);
            this.lbPrfCalVal.Name = "lbPrfCalVal";
            this.lbPrfCalVal.Size = new System.Drawing.Size(31, 32);
            this.lbPrfCalVal.TabIndex = 6;
            this.lbPrfCalVal.Text = "0";
            // 
            // lbPrfCal
            // 
            this.lbPrfCal.AutoSize = true;
            this.lbPrfCal.Location = new System.Drawing.Point(1554, 184);
            this.lbPrfCal.Name = "lbPrfCal";
            this.lbPrfCal.Size = new System.Drawing.Size(191, 32);
            this.lbPrfCal.TabIndex = 5;
            this.lbPrfCal.Text = "Total Calories";
            // 
            // lbPrfMinsVal
            // 
            this.lbPrfMinsVal.AutoSize = true;
            this.lbPrfMinsVal.Location = new System.Drawing.Point(1789, 84);
            this.lbPrfMinsVal.Name = "lbPrfMinsVal";
            this.lbPrfMinsVal.Size = new System.Drawing.Size(31, 32);
            this.lbPrfMinsVal.TabIndex = 4;
            this.lbPrfMinsVal.Text = "0";
            // 
            // lbPrfMins
            // 
            this.lbPrfMins.AutoSize = true;
            this.lbPrfMins.Location = new System.Drawing.Point(1548, 84);
            this.lbPrfMins.Name = "lbPrfMins";
            this.lbPrfMins.Size = new System.Drawing.Size(186, 32);
            this.lbPrfMins.TabIndex = 3;
            this.lbPrfMins.Text = "Total Minutes";
            // 
            // formsPlot1
            // 
            this.formsPlot1.BackColor = System.Drawing.Color.Transparent;
            this.formsPlot1.Location = new System.Drawing.Point(422, 54);
            this.formsPlot1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(1067, 715);
            this.formsPlot1.TabIndex = 2;
            // 
            // lbxPerfDt
            // 
            this.lbxPerfDt.FormattingEnabled = true;
            this.lbxPerfDt.ItemHeight = 31;
            this.lbxPerfDt.Location = new System.Drawing.Point(187, 54);
            this.lbxPerfDt.Name = "lbxPerfDt";
            this.lbxPerfDt.Size = new System.Drawing.Size(187, 314);
            this.lbxPerfDt.TabIndex = 1;
            this.lbxPerfDt.SelectedIndexChanged += new System.EventHandler(this.lbxPerfDt_SelectedIndexChanged);
            // 
            // lbDtPrf
            // 
            this.lbDtPrf.AutoSize = true;
            this.lbDtPrf.Location = new System.Drawing.Point(52, 54);
            this.lbDtPrf.Name = "lbDtPrf";
            this.lbDtPrf.Size = new System.Drawing.Size(75, 32);
            this.lbDtPrf.TabIndex = 0;
            this.lbDtPrf.Text = "Date";
            // 
            // tbFood
            // 
            this.tbFood.Controls.Add(this.formsPlot3);
            this.tbFood.Controls.Add(this.formsPlot2);
            this.tbFood.Controls.Add(this.lbErrFd);
            this.tbFood.Controls.Add(this.btnFood);
            this.tbFood.Controls.Add(this.txtCalCnt);
            this.tbFood.Controls.Add(this.txtFoodDesc);
            this.tbFood.Controls.Add(this.lbFoodExp);
            this.tbFood.Controls.Add(this.lbCalCount);
            this.tbFood.Controls.Add(this.lbMeal);
            this.tbFood.Controls.Add(this.lbxMeal);
            this.tbFood.Location = new System.Drawing.Point(10, 48);
            this.tbFood.Name = "tbFood";
            this.tbFood.Size = new System.Drawing.Size(3897, 1666);
            this.tbFood.TabIndex = 3;
            this.tbFood.Text = "Food Log";
            this.tbFood.UseVisualStyleBackColor = true;
            // 
            // formsPlot2
            // 
            this.formsPlot2.BackColor = System.Drawing.Color.Transparent;
            this.formsPlot2.Location = new System.Drawing.Point(1213, 91);
            this.formsPlot2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.formsPlot2.Name = "formsPlot2";
            this.formsPlot2.Size = new System.Drawing.Size(1067, 715);
            this.formsPlot2.TabIndex = 8;
            this.formsPlot2.Tag = "fffff";
            // 
            // lbErrFd
            // 
            this.lbErrFd.AutoSize = true;
            this.lbErrFd.Location = new System.Drawing.Point(165, 523);
            this.lbErrFd.Name = "lbErrFd";
            this.lbErrFd.Size = new System.Drawing.Size(169, 32);
            this.lbErrFd.TabIndex = 7;
            this.lbErrFd.Text = "Result Entry";
            // 
            // btnFood
            // 
            this.btnFood.Location = new System.Drawing.Point(686, 232);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(200, 92);
            this.btnFood.TabIndex = 6;
            this.btnFood.Text = "Save Diary Entry";
            this.btnFood.UseVisualStyleBackColor = true;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // txtCalCnt
            // 
            this.txtCalCnt.Location = new System.Drawing.Point(686, 157);
            this.txtCalCnt.MaxLength = 4;
            this.txtCalCnt.Name = "txtCalCnt";
            this.txtCalCnt.Size = new System.Drawing.Size(200, 38);
            this.txtCalCnt.TabIndex = 5;
            this.txtCalCnt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCalCnt_KeyPress);
            // 
            // txtFoodDesc
            // 
            this.txtFoodDesc.Location = new System.Drawing.Point(686, 91);
            this.txtFoodDesc.Name = "txtFoodDesc";
            this.txtFoodDesc.Size = new System.Drawing.Size(200, 38);
            this.txtFoodDesc.TabIndex = 4;
            // 
            // lbFoodExp
            // 
            this.lbFoodExp.AutoSize = true;
            this.lbFoodExp.Location = new System.Drawing.Point(432, 91);
            this.lbFoodExp.Name = "lbFoodExp";
            this.lbFoodExp.Size = new System.Drawing.Size(222, 32);
            this.lbFoodExp.TabIndex = 3;
            this.lbFoodExp.Text = "Food Explained:";
            // 
            // lbCalCount
            // 
            this.lbCalCount.AutoSize = true;
            this.lbCalCount.Location = new System.Drawing.Point(432, 157);
            this.lbCalCount.Name = "lbCalCount";
            this.lbCalCount.Size = new System.Drawing.Size(197, 32);
            this.lbCalCount.TabIndex = 2;
            this.lbCalCount.Text = "Calorie Count:";
            // 
            // lbMeal
            // 
            this.lbMeal.AutoSize = true;
            this.lbMeal.Location = new System.Drawing.Point(79, 91);
            this.lbMeal.Name = "lbMeal";
            this.lbMeal.Size = new System.Drawing.Size(85, 32);
            this.lbMeal.TabIndex = 1;
            this.lbMeal.Text = "Meal:";
            // 
            // lbxMeal
            // 
            this.lbxMeal.FormattingEnabled = true;
            this.lbxMeal.ItemHeight = 31;
            this.lbxMeal.Location = new System.Drawing.Point(181, 91);
            this.lbxMeal.Name = "lbxMeal";
            this.lbxMeal.Size = new System.Drawing.Size(170, 252);
            this.lbxMeal.TabIndex = 0;
            // 
            // formsPlot3
            // 
            this.formsPlot3.BackColor = System.Drawing.Color.Transparent;
            this.formsPlot3.Location = new System.Drawing.Point(425, 869);
            this.formsPlot3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.formsPlot3.Name = "formsPlot3";
            this.formsPlot3.Size = new System.Drawing.Size(2280, 715);
            this.formsPlot3.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3844, 2015);
            this.Controls.Add(this.tbMain);
            this.Controls.Add(this.lbTime);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(10613, 4170);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(3838, 1838);
            this.Name = "Form1";
            this.Text = "Exercise App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tbMain.ResumeLayout(false);
            this.tbRoutine.ResumeLayout(false);
            this.tbRoutine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdExercise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBxExercise)).EndInit();
            this.tbAddEx.ResumeLayout(false);
            this.tbAddEx.PerformLayout();
            this.tbPerf.ResumeLayout(false);
            this.tbPerf.PerformLayout();
            this.tbFood.ResumeLayout(false);
            this.tbFood.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxWorkOut;
        private System.Windows.Forms.Label lbWrkOut;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Timer tmrWrkOut;
        private System.Windows.Forms.Label lbActivity;
        private System.Windows.Forms.Timer tmrWork2;
        private System.Windows.Forms.Label lbClicker;
        private System.Windows.Forms.Label lbExTtlTime;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbNextLb;
        private System.Windows.Forms.Label lbNextName;
        private System.Windows.Forms.Timer tmrMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbRnTime;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.TabControl tbMain;
        private System.Windows.Forms.TabPage tbRoutine;
        private System.Windows.Forms.TabPage tbAddEx;
        private System.Windows.Forms.PictureBox pBxExercise;
        private System.Windows.Forms.DataGridView grdExercise;
        private System.Windows.Forms.Button btnExrcs;
        private System.Windows.Forms.Label lbExype;
        private System.Windows.Forms.CheckBox chkNB;
        private System.Windows.Forms.CheckBox chkFB;
        private System.Windows.Forms.CheckBox ChkLG;
        private System.Windows.Forms.CheckBox chKAB;
        private System.Windows.Forms.CheckBox chkUB;
        private System.Windows.Forms.CheckBox chk30;
        private System.Windows.Forms.CheckBox chk20;
        private System.Windows.Forms.CheckBox chk15;
        private System.Windows.Forms.Label lbExtime;
        private System.Windows.Forms.CheckBox chk10;
        private System.Windows.Forms.Label lbErr;
        private System.Windows.Forms.Label lcCurrEx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbxType;
        private System.Windows.Forms.TextBox txtExName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.TabPage tbPerf;
        private System.Windows.Forms.TabPage tbFood;
        private System.Windows.Forms.TextBox txtCalCnt;
        private System.Windows.Forms.TextBox txtFoodDesc;
        private System.Windows.Forms.Label lbFoodExp;
        private System.Windows.Forms.Label lbCalCount;
        private System.Windows.Forms.Label lbMeal;
        private System.Windows.Forms.ListBox lbxMeal;
        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.Label lbErrFd;
        private ScottPlot.FormsPlot formsPlot1;
        private System.Windows.Forms.ListBox lbxPerfDt;
        private System.Windows.Forms.Label lbDtPrf;
        private ScottPlot.FormsPlot formsPlot2;
        private System.Windows.Forms.Label lbPrfCalVal;
        private System.Windows.Forms.Label lbPrfCal;
        private System.Windows.Forms.Label lbPrfMinsVal;
        private System.Windows.Forms.Label lbPrfMins;
        private ScottPlot.FormsPlot formsPlot3;
    }
}

