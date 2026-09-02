namespace MS.demo1.UI
{
    partial class frmDemo1
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
            lblTitle = new Label();
            lblName = new Label();
            btnDisplay = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.PaleGoldenrod;
            lblTitle.Font = new Font("Courier New", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(285, 184);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(194, 27);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Welcome to C#";
            lblTitle.Click += lblTitle_Click;
            // 
            // lblName
            // 
            lblName.BackColor = Color.DarkGoldenrod;
            lblName.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(240, 227);
            lblName.Name = "lblName";
            lblName.Size = new Size(298, 56);
            lblName.TabIndex = 1;
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            lblName.Click += lbl_Click;
            // 
            // btnDisplay
            // 
            btnDisplay.BackColor = Color.DarkKhaki;
            btnDisplay.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDisplay.ForeColor = SystemColors.Desktop;
            btnDisplay.Location = new Point(240, 305);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(100, 58);
            btnDisplay.TabIndex = 2;
            btnDisplay.Text = "Display";
            btnDisplay.UseVisualStyleBackColor = false;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DarkKhaki;
            btnClear.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.ForeColor = SystemColors.Desktop;
            btnClear.Location = new Point(438, 305);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 58);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.DarkKhaki;
            btnExit.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.Desktop;
            btnExit.Location = new Point(339, 369);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 58);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // frmDemo1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnDisplay);
            Controls.Add(lblName);
            Controls.Add(lblTitle);
            Name = "frmDemo1";
            Text = "Demo 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblName;
        private Button btnDisplay;
        private Button btnClear;
        private Button btnExit;
    }
}
