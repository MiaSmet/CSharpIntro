namespace MS.rps.UI
{
    partial class rps
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
            btnRock = new Button();
            btnPaper = new Button();
            btnScissors = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // btnRock
            // 
            btnRock.Location = new Point(42, 327);
            btnRock.Name = "btnRock";
            btnRock.Size = new Size(174, 81);
            btnRock.TabIndex = 0;
            btnRock.Text = "Rock";
            btnRock.UseVisualStyleBackColor = true;
            btnRock.Click += btnRock_Click;
            // 
            // btnPaper
            // 
            btnPaper.Location = new Point(286, 327);
            btnPaper.Name = "btnPaper";
            btnPaper.Size = new Size(174, 81);
            btnPaper.TabIndex = 1;
            btnPaper.Text = "Paper";
            btnPaper.UseVisualStyleBackColor = true;
            btnPaper.Click += btnPaper_Click;
            // 
            // btnScissors
            // 
            btnScissors.Location = new Point(535, 327);
            btnScissors.Name = "btnScissors";
            btnScissors.Size = new Size(174, 81);
            btnScissors.TabIndex = 2;
            btnScissors.Text = "Scissors";
            btnScissors.UseVisualStyleBackColor = true;
            btnScissors.Click += btnScissors_Click;
            // 
            // lblResult
            // 
            lblResult.BorderStyle = BorderStyle.Fixed3D;
            lblResult.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(123, 93);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(529, 197);
            lblResult.TabIndex = 3;
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rps
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnScissors);
            Controls.Add(btnPaper);
            Controls.Add(btnRock);
            Name = "rps";
            Text = "Rock paper scissors";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRock;
        private Button btnPaper;
        private Button btnScissors;
        private Label lblResult;
    }
}
