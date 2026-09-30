namespace MS.FineCalc.UI
{
    partial class FineCalc
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
            lblSubtitle = new Label();
            lblNum = new Label();
            txtNum = new TextBox();
            lblDays = new Label();
            txtDays = new TextBox();
            btnCalc = new Button();
            btnClear = new Button();
            btnExit = new Button();
            lblFine = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(78, 73);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(307, 37);
            lblTitle.TabIndex = 6;
            lblTitle.Text = "Library Fine Calculator";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Location = new Point(80, 110);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(305, 15);
            lblSubtitle.TabIndex = 7;
            lblSubtitle.Text = "Overdue materials are assessed at $0.05 per book per day";
            // 
            // lblNum
            // 
            lblNum.AutoSize = true;
            lblNum.Font = new Font("Segoe UI", 15F);
            lblNum.Location = new Point(60, 179);
            lblNum.Name = "lblNum";
            lblNum.Size = new Size(283, 28);
            lblNum.TabIndex = 8;
            lblNum.Text = "NUMBER OF OVERDUE BOOKS";
            // 
            // txtNum
            // 
            txtNum.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNum.Location = new Point(60, 210);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(372, 35);
            txtNum.TabIndex = 0;
            // 
            // lblDays
            // 
            lblDays.AutoSize = true;
            lblDays.Font = new Font("Segoe UI", 15F);
            lblDays.Location = new Point(60, 300);
            lblDays.Name = "lblDays";
            lblDays.Size = new Size(152, 28);
            lblDays.TabIndex = 9;
            lblDays.Text = "DAYS OVERDUE";
            // 
            // txtDays
            // 
            txtDays.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            txtDays.Location = new Point(60, 331);
            txtDays.Name = "txtDays";
            txtDays.Size = new Size(372, 35);
            txtDays.TabIndex = 1;
            // 
            // btnCalc
            // 
            btnCalc.BackColor = Color.FromArgb(0, 192, 192);
            btnCalc.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            btnCalc.ForeColor = SystemColors.ControlLightLight;
            btnCalc.Location = new Point(60, 389);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(372, 81);
            btnCalc.TabIndex = 2;
            btnCalc.Text = "Calculate Fine";
            btnCalc.UseVisualStyleBackColor = false;
            btnCalc.Click += btnCalc_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(60, 484);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(175, 52);
            btnClear.TabIndex = 3;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(260, 484);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(172, 52);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblFine
            // 
            lblFine.BorderStyle = BorderStyle.Fixed3D;
            lblFine.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFine.Location = new Point(80, 539);
            lblFine.Name = "lblFine";
            lblFine.Size = new Size(332, 103);
            lblFine.TabIndex = 5;
            lblFine.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FineCalc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 761);
            Controls.Add(lblFine);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalc);
            Controls.Add(txtDays);
            Controls.Add(lblDays);
            Controls.Add(txtNum);
            Controls.Add(lblNum);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Name = "FineCalc";
            Text = "Library Fine Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblNum;
        private TextBox txtNum;
        private Label lblDays;
        private TextBox txtDays;
        private Button btnCalc;
        private Button btnClear;
        private Button btnExit;
        private Label lblFine;
    }
}
