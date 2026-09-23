namespace MS.BookSales.UI
{
    partial class BookSales
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
            lblTotal = new Label();
            lblDiscount = new Label();
            lblFinal = new Label();
            txtTotal = new TextBox();
            lblDiscCalc = new Label();
            lblFinalCalc = new Label();
            btnCalc = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(45, 70);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(177, 35);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "Total Sale Amount";
            // 
            // lblDiscount
            // 
            lblDiscount.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiscount.Location = new Point(45, 172);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(177, 35);
            lblDiscount.TabIndex = 7;
            lblDiscount.Text = "Discount Applied";
            // 
            // lblFinal
            // 
            lblFinal.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFinal.Location = new Point(45, 280);
            lblFinal.Name = "lblFinal";
            lblFinal.Size = new Size(177, 35);
            lblFinal.TabIndex = 8;
            lblFinal.Text = "Final Sale Amount";
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(350, 70);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(213, 34);
            txtTotal.TabIndex = 0;
            txtTotal.TextAlign = HorizontalAlignment.Right;
            txtTotal.TextChanged += txtTotal_TextChanged;
            // 
            // lblDiscCalc
            // 
            lblDiscCalc.BorderStyle = BorderStyle.Fixed3D;
            lblDiscCalc.Font = new Font("Segoe UI", 15F);
            lblDiscCalc.Location = new Point(350, 172);
            lblDiscCalc.Name = "lblDiscCalc";
            lblDiscCalc.Size = new Size(213, 35);
            lblDiscCalc.TabIndex = 4;
            lblDiscCalc.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblFinalCalc
            // 
            lblFinalCalc.BorderStyle = BorderStyle.Fixed3D;
            lblFinalCalc.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFinalCalc.Location = new Point(350, 280);
            lblFinalCalc.Name = "lblFinalCalc";
            lblFinalCalc.Size = new Size(213, 35);
            lblFinalCalc.TabIndex = 5;
            lblFinalCalc.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(625, 50);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(139, 68);
            btnCalc.TabIndex = 1;
            btnCalc.Text = "Calculate";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(625, 156);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(139, 68);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(625, 264);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(139, 68);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // BookSales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalc);
            Controls.Add(lblFinalCalc);
            Controls.Add(lblDiscCalc);
            Controls.Add(txtTotal);
            Controls.Add(lblFinal);
            Controls.Add(lblDiscount);
            Controls.Add(lblTotal);
            Name = "BookSales";
            Text = "FVTC Book Sales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTotal;
        private Label lblDiscount;
        private Label lblFinal;
        private TextBox txtTotal;
        private Label lblDiscCalc;
        private Label lblFinalCalc;
        private Button btnCalc;
        private Button btnClear;
        private Button btnExit;
    }
}
