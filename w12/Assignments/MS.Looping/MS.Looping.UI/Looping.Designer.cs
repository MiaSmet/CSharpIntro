namespace MS.Looping.UI
{
    partial class Looping
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
            lblPhrase = new Label();
            txtPhrase = new TextBox();
            lblRep = new Label();
            txtRep = new TextBox();
            lstOutput = new ListBox();
            btnDisplay = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblPhrase
            // 
            lblPhrase.AutoSize = true;
            lblPhrase.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhrase.Location = new Point(43, 32);
            lblPhrase.Name = "lblPhrase";
            lblPhrase.Size = new Size(52, 20);
            lblPhrase.TabIndex = 7;
            lblPhrase.Text = "Phrase";
            // 
            // txtPhrase
            // 
            txtPhrase.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhrase.Location = new Point(114, 32);
            txtPhrase.Name = "txtPhrase";
            txtPhrase.Size = new Size(612, 27);
            txtPhrase.TabIndex = 0;
            // 
            // lblRep
            // 
            lblRep.AutoSize = true;
            lblRep.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRep.Location = new Point(43, 96);
            lblRep.Name = "lblRep";
            lblRep.Size = new Size(156, 20);
            lblRep.TabIndex = 6;
            lblRep.Text = "Number of repetitions";
            // 
            // txtRep
            // 
            txtRep.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRep.Location = new Point(216, 93);
            txtRep.Name = "txtRep";
            txtRep.Size = new Size(133, 27);
            txtRep.TabIndex = 1;
            txtRep.TextAlign = HorizontalAlignment.Right;
            // 
            // lstOutput
            // 
            lstOutput.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstOutput.FormattingEnabled = true;
            lstOutput.Location = new Point(12, 160);
            lstOutput.Name = "lstOutput";
            lstOutput.Size = new Size(714, 184);
            lstOutput.TabIndex = 5;
            // 
            // btnDisplay
            // 
            btnDisplay.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDisplay.Location = new Point(12, 368);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(224, 74);
            btnDisplay.TabIndex = 2;
            btnDisplay.Text = "Display";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(255, 368);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(224, 74);
            btnClear.TabIndex = 3;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(502, 368);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(224, 74);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Looping
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 450);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnDisplay);
            Controls.Add(lstOutput);
            Controls.Add(txtRep);
            Controls.Add(lblRep);
            Controls.Add(txtPhrase);
            Controls.Add(lblPhrase);
            Name = "Looping";
            Text = "Line repetition";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPhrase;
        private TextBox txtPhrase;
        private Label lblRep;
        private TextBox txtRep;
        private ListBox lstOutput;
        private Button btnDisplay;
        private Button btnClear;
        private Button btnExit;
    }
}
