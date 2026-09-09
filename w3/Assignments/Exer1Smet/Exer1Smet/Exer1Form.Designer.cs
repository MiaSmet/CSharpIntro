namespace Exer1Smet
{
    partial class Exer1Form
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
            lblCSharp = new Label();
            lblFVTCName = new Label();
            btnDisplay = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblCSharp
            // 
            lblCSharp.Font = new Font("Georgia", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCSharp.ForeColor = Color.Green;
            lblCSharp.Location = new Point(204, 78);
            lblCSharp.Name = "lblCSharp";
            lblCSharp.Size = new Size(376, 74);
            lblCSharp.TabIndex = 0;
            lblCSharp.Text = "C# is Fun!";
            lblCSharp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFVTCName
            // 
            lblFVTCName.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFVTCName.ForeColor = Color.DarkGoldenrod;
            lblFVTCName.Location = new Point(204, 165);
            lblFVTCName.Name = "lblFVTCName";
            lblFVTCName.Size = new Size(376, 69);
            lblFVTCName.TabIndex = 1;
            lblFVTCName.Text = "Fox Valley Technical College";
            lblFVTCName.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnDisplay
            // 
            btnDisplay.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDisplay.Location = new Point(30, 284);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(231, 76);
            btnDisplay.TabIndex = 2;
            btnDisplay.Text = "Display";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(291, 284);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(231, 76);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(542, 284);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(231, 76);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Exer1Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aqua;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnDisplay);
            Controls.Add(lblFVTCName);
            Controls.Add(lblCSharp);
            Name = "Exer1Form";
            Text = "Exercise 1";
            ResumeLayout(false);
        }

        #endregion

        private Label lblCSharp;
        private Label lblFVTCName;
        private Button btnDisplay;
        private Button btnClear;
        private Button btnExit;
    }
}
