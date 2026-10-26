namespace MS.SalesCommission.UI
{
    partial class Commission
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
            lblLast = new Label();
            lblFirst = new Label();
            lblSales = new Label();
            txtLast = new TextBox();
            txtFirst = new TextBox();
            txtSales = new TextBox();
            btnCalc = new Button();
            lblCommission = new Label();
            lblFinal = new Label();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblLast
            // 
            lblLast.AutoSize = true;
            lblLast.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLast.Location = new Point(39, 51);
            lblLast.Name = "lblLast";
            lblLast.Size = new Size(112, 30);
            lblLast.TabIndex = 0;
            lblLast.Text = "Last Name";
            // 
            // lblFirst
            // 
            lblFirst.AutoSize = true;
            lblFirst.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFirst.Location = new Point(38, 113);
            lblFirst.Name = "lblFirst";
            lblFirst.Size = new Size(113, 30);
            lblFirst.TabIndex = 1;
            lblFirst.Text = "First Name";
            // 
            // lblSales
            // 
            lblSales.AutoSize = true;
            lblSales.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSales.Location = new Point(38, 177);
            lblSales.Name = "lblSales";
            lblSales.Size = new Size(60, 30);
            lblSales.TabIndex = 2;
            lblSales.Text = "Sales";
            // 
            // txtLast
            // 
            txtLast.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLast.Location = new Point(182, 46);
            txtLast.Name = "txtLast";
            txtLast.Size = new Size(193, 35);
            txtLast.TabIndex = 3;
            txtLast.TextChanged += txtLast_TextChanged;
            // 
            // txtFirst
            // 
            txtFirst.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirst.Location = new Point(182, 113);
            txtFirst.Name = "txtFirst";
            txtFirst.Size = new Size(193, 35);
            txtFirst.TabIndex = 4;
            txtFirst.TextChanged += txtFirst_TextChanged;
            // 
            // txtSales
            // 
            txtSales.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSales.Location = new Point(182, 177);
            txtSales.Name = "txtSales";
            txtSales.Size = new Size(193, 35);
            txtSales.TabIndex = 5;
            txtSales.TextAlign = HorizontalAlignment.Right;
            txtSales.TextChanged += txtSales_TextChanged;
            // 
            // btnCalc
            // 
            btnCalc.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalc.Location = new Point(39, 256);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(336, 46);
            btnCalc.TabIndex = 6;
            btnCalc.Text = "Calculate Commission";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // lblCommission
            // 
            lblCommission.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCommission.Location = new Point(63, 319);
            lblCommission.Name = "lblCommission";
            lblCommission.Size = new Size(292, 46);
            lblCommission.TabIndex = 7;
            lblCommission.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFinal
            // 
            lblFinal.BorderStyle = BorderStyle.Fixed3D;
            lblFinal.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFinal.Location = new Point(108, 384);
            lblFinal.Name = "lblFinal";
            lblFinal.Size = new Size(207, 43);
            lblFinal.TabIndex = 8;
            lblFinal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(54, 461);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(145, 51);
            btnClear.TabIndex = 9;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(230, 461);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(145, 51);
            btnExit.TabIndex = 10;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Commission
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 532);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(lblFinal);
            Controls.Add(lblCommission);
            Controls.Add(btnCalc);
            Controls.Add(txtSales);
            Controls.Add(txtFirst);
            Controls.Add(txtLast);
            Controls.Add(lblSales);
            Controls.Add(lblFirst);
            Controls.Add(lblLast);
            Name = "Commission";
            Text = "Sales Commission";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLast;
        private Label lblFirst;
        private Label lblSales;
        private TextBox txtLast;
        private TextBox txtFirst;
        private TextBox txtSales;
        private Button btnCalc;
        private Label lblCommission;
        private Label lblFinal;
        private Button btnClear;
        private Button btnExit;
    }
}
