namespace MS.DiceBattle.UI
{
    partial class frmDice
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
            btnPlay = new Button();
            lstResults = new ListBox();
            lblFinalScore = new Label();
            nudRounds = new NumericUpDown();
            btnClear = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)nudRounds).BeginInit();
            SuspendLayout();
            // 
            // btnPlay
            // 
            btnPlay.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPlay.Location = new Point(44, 25);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(180, 33);
            btnPlay.TabIndex = 0;
            btnPlay.Text = "Play Rounds";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // lstResults
            // 
            lstResults.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstResults.FormattingEnabled = true;
            lstResults.Location = new Point(44, 99);
            lstResults.Name = "lstResults";
            lstResults.Size = new Size(681, 274);
            lstResults.TabIndex = 1;
            // 
            // lblFinalScore
            // 
            lblFinalScore.AutoSize = true;
            lblFinalScore.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFinalScore.Location = new Point(52, 388);
            lblFinalScore.Name = "lblFinalScore";
            lblFinalScore.Size = new Size(172, 25);
            lblFinalScore.TabIndex = 2;
            lblFinalScore.Text = "Click Play to begin!";
            // 
            // nudRounds
            // 
            nudRounds.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudRounds.Location = new Point(239, 25);
            nudRounds.Name = "nudRounds";
            nudRounds.Size = new Size(130, 33);
            nudRounds.TabIndex = 3;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(460, 25);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(158, 33);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.TextAlign = ContentAlignment.TopCenter;
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(630, 25);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(158, 33);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.TextAlign = ContentAlignment.TopCenter;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmDice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(nudRounds);
            Controls.Add(lblFinalScore);
            Controls.Add(lstResults);
            Controls.Add(btnPlay);
            Name = "frmDice";
            Text = "Dice Battle";
            ((System.ComponentModel.ISupportInitialize)nudRounds).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPlay;
        private ListBox lstResults;
        private Label lblFinalScore;
        private NumericUpDown nudRounds;
        private Button btnClear;
        private Button btnExit;
    }
}
