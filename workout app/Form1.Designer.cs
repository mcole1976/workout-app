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
            this.pBxExercise = new System.Windows.Forms.PictureBox();
            this.tmrWork2 = new System.Windows.Forms.Timer(this.components);
            this.lbTimeTitle = new System.Windows.Forms.Label();
            this.lbClicker = new System.Windows.Forms.Label();
            this.lbExTtlTime = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbNextLb = new System.Windows.Forms.Label();
            this.lbNextName = new System.Windows.Forms.Label();
            this.grdExercise = new System.Windows.Forms.DataGridView();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lbRnTime = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnPause60 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBxExercise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdExercise)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxWorkOut
            // 
            this.lbxWorkOut.FormattingEnabled = true;
            this.lbxWorkOut.Location = new System.Drawing.Point(17, 59);
            this.lbxWorkOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbxWorkOut.Name = "lbxWorkOut";
            this.lbxWorkOut.Size = new System.Drawing.Size(186, 147);
            this.lbxWorkOut.TabIndex = 0;
            // 
            // lbWrkOut
            // 
            this.lbWrkOut.AutoSize = true;
            this.lbWrkOut.Font = new System.Drawing.Font("Miriam Libre", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWrkOut.Location = new System.Drawing.Point(19, 16);
            this.lbWrkOut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbWrkOut.Name = "lbWrkOut";
            this.lbWrkOut.Size = new System.Drawing.Size(119, 21);
            this.lbWrkOut.TabIndex = 1;
            this.lbWrkOut.Text = "Workout Type";
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Miriam CLM", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnRun.Location = new System.Drawing.Point(281, 20);
            this.btnRun.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(90, 49);
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
            this.lbActivity.Font = new System.Drawing.Font("Miriam Libre", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbActivity.Location = new System.Drawing.Point(418, 85);
            this.lbActivity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbActivity.Name = "lbActivity";
            this.lbActivity.Size = new System.Drawing.Size(228, 110);
            this.lbActivity.TabIndex = 10;
            this.lbActivity.Text = "Exercise";
            this.lbActivity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pBxExercise
            // 
            this.pBxExercise.Location = new System.Drawing.Point(9, 223);
            this.pBxExercise.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pBxExercise.Name = "pBxExercise";
            this.pBxExercise.Size = new System.Drawing.Size(862, 406);
            this.pBxExercise.TabIndex = 12;
            this.pBxExercise.TabStop = false;
            this.pBxExercise.BackgroundImageChanged += new System.EventHandler(this.pBxExercise_BackgroundImageChanged);
            // 
            // tmrWork2
            // 
            this.tmrWork2.Interval = 1000;
            this.tmrWork2.Tick += new System.EventHandler(this.tmrWork2_Tick);
            // 
            // lbTimeTitle
            // 
            this.lbTimeTitle.Font = new System.Drawing.Font("Miriam Libre", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeTitle.Location = new System.Drawing.Point(900, 325);
            this.lbTimeTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTimeTitle.Name = "lbTimeTitle";
            this.lbTimeTitle.Size = new System.Drawing.Size(184, 114);
            this.lbTimeTitle.TabIndex = 13;
            this.lbTimeTitle.Text = "Time of Exercise";
            this.lbTimeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbClicker
            // 
            this.lbClicker.Font = new System.Drawing.Font("Miriam Libre", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClicker.Location = new System.Drawing.Point(900, 447);
            this.lbClicker.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbClicker.Name = "lbClicker";
            this.lbClicker.Size = new System.Drawing.Size(184, 91);
            this.lbClicker.TabIndex = 14;
            this.lbClicker.Text = "0";
            this.lbClicker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbExTtlTime
            // 
            this.lbExTtlTime.AutoSize = true;
            this.lbExTtlTime.Font = new System.Drawing.Font("Miriam Libre", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExTtlTime.Location = new System.Drawing.Point(900, 223);
            this.lbExTtlTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbExTtlTime.MaximumSize = new System.Drawing.Size(300, 32);
            this.lbExTtlTime.MinimumSize = new System.Drawing.Size(188, 32);
            this.lbExTtlTime.Name = "lbExTtlTime";
            this.lbExTtlTime.Size = new System.Drawing.Size(199, 32);
            this.lbExTtlTime.TabIndex = 15;
            this.lbExTtlTime.Text = "Total Exercise Time";
            // 
            // lbTime
            // 
            this.lbTime.Font = new System.Drawing.Font("Miriam Libre", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(900, 264);
            this.lbTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(188, 32);
            this.lbTime.TabIndex = 16;
            this.lbTime.Text = "lbTime";
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNextLb
            // 
            this.lbNextLb.Font = new System.Drawing.Font("Miriam Libre", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNextLb.Location = new System.Drawing.Point(650, 25);
            this.lbNextLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNextLb.Name = "lbNextLb";
            this.lbNextLb.Size = new System.Drawing.Size(385, 40);
            this.lbNextLb.TabIndex = 17;
            this.lbNextLb.Text = "Next Exercise";
            this.lbNextLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNextName
            // 
            this.lbNextName.Font = new System.Drawing.Font("Miriam Libre", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNextName.Location = new System.Drawing.Point(650, 100);
            this.lbNextName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNextName.MaximumSize = new System.Drawing.Size(385, 90);
            this.lbNextName.Name = "lbNextName";
            this.lbNextName.Size = new System.Drawing.Size(385, 90);
            this.lbNextName.TabIndex = 18;
            this.lbNextName.Text = "Next Exercise";
            this.lbNextName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grdExercise
            // 
            this.grdExercise.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdExercise.Location = new System.Drawing.Point(1125, 223);
            this.grdExercise.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grdExercise.Name = "grdExercise";
            this.grdExercise.RowHeadersWidth = 51;
            this.grdExercise.RowTemplate.Height = 24;
            this.grdExercise.Size = new System.Drawing.Size(281, 406);
            this.grdExercise.TabIndex = 19;
            // 
            // tmrMain
            // 
            this.tmrMain.Interval = 1000;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Miriam Libre", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1125, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 61);
            this.label1.TabIndex = 20;
            this.label1.Text = "Total Run Time";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbRnTime
            // 
            this.lbRnTime.Font = new System.Drawing.Font("Miriam Libre", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRnTime.Location = new System.Drawing.Point(1125, 89);
            this.lbRnTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRnTime.Name = "lbRnTime";
            this.lbRnTime.Size = new System.Drawing.Size(129, 102);
            this.lbRnTime.TabIndex = 21;
            this.lbRnTime.Text = "0";
            this.lbRnTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPause
            // 
            this.btnPause.Font = new System.Drawing.Font("Miriam CLM", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnPause.Location = new System.Drawing.Point(281, 85);
            this.btnPause.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(90, 48);
            this.btnPause.TabIndex = 22;
            this.btnPause.Text = "Pause 5 Seconds";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnPause60
            // 
            this.btnPause60.Font = new System.Drawing.Font("Miriam CLM", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnPause60.Location = new System.Drawing.Point(281, 154);
            this.btnPause60.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPause60.Name = "btnPause60";
            this.btnPause60.Size = new System.Drawing.Size(90, 48);
            this.btnPause60.TabIndex = 23;
            this.btnPause60.Text = "Pause 60 Seconds";
            this.btnPause60.UseVisualStyleBackColor = true;
            this.btnPause60.Click += new System.EventHandler(this.btnPause60_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 687);
            this.Controls.Add(this.btnPause60);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.lbRnTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdExercise);
            this.Controls.Add(this.lbNextName);
            this.Controls.Add(this.lbNextLb);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbExTtlTime);
            this.Controls.Add(this.lbClicker);
            this.Controls.Add(this.lbTimeTitle);
            this.Controls.Add(this.pBxExercise);
            this.Controls.Add(this.lbActivity);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.lbWrkOut);
            this.Controls.Add(this.lbxWorkOut);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(1460, 820);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1154, 675);
            this.Name = "Form1";
            this.Text = "Exercise App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pBxExercise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdExercise)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxWorkOut;
        private System.Windows.Forms.Label lbWrkOut;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Timer tmrWrkOut;
        private System.Windows.Forms.Label lbActivity;
        private System.Windows.Forms.PictureBox pBxExercise;
        private System.Windows.Forms.Timer tmrWork2;
        private System.Windows.Forms.Label lbTimeTitle;
        private System.Windows.Forms.Label lbClicker;
        private System.Windows.Forms.Label lbExTtlTime;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbNextLb;
        private System.Windows.Forms.Label lbNextName;
        private System.Windows.Forms.DataGridView grdExercise;
        private System.Windows.Forms.Timer tmrMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbRnTime;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnPause60;
    }
}

