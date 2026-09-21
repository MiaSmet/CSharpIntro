namespace MS.TipCalc.UI
{
    partial class frmTipCalc
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
            lblBill = new Label();
            lblPercent = new Label();
            lblTotal = new Label();
            lblTip = new Label();
            txtBill = new TextBox();
            txtTip = new TextBox();
            lblAmount = new Label();
            lblOutput = new Label();
            btnCalc = new Button();
            SuspendLayout();
            // 
            // lblBill
            // 
            lblBill.AutoSize = true;
            lblBill.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBill.Location = new Point(75, 42);
            lblBill.Name = "lblBill";
            lblBill.Size = new Size(161, 37);
            lblBill.TabIndex = 0;
            lblBill.Text = "Bill Amount:";
            // 
            // lblPercent
            // 
            lblPercent.AutoSize = true;
            lblPercent.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPercent.Location = new Point(75, 130);
            lblPercent.Name = "lblPercent";
            lblPercent.Size = new Size(89, 37);
            lblPercent.TabIndex = 1;
            lblPercent.Text = "Tip %:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(76, 295);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(80, 37);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Total:";
            // 
            // lblTip
            // 
            lblTip.AutoSize = true;
            lblTip.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTip.Location = new Point(75, 207);
            lblTip.Name = "lblTip";
            lblTip.Size = new Size(162, 37);
            lblTip.TabIndex = 3;
            lblTip.Text = "Tip Amount:";
            // 
            // txtBill
            // 
            txtBill.Font = new Font("Segoe UI", 20F);
            txtBill.Location = new Point(314, 36);
            txtBill.Name = "txtBill";
            txtBill.Size = new Size(184, 43);
            txtBill.TabIndex = 4;
            txtBill.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTip
            // 
            txtTip.Font = new Font("Segoe UI", 20F);
            txtTip.Location = new Point(314, 124);
            txtTip.Name = "txtTip";
            txtTip.Size = new Size(184, 43);
            txtTip.TabIndex = 5;
            txtTip.TextAlign = HorizontalAlignment.Right;
            // 
            // lblAmount
            // 
            lblAmount.BorderStyle = BorderStyle.FixedSingle;
            lblAmount.Font = new Font("Segoe UI", 20F);
            lblAmount.Location = new Point(314, 207);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(184, 37);
            lblAmount.TabIndex = 6;
            lblAmount.TextAlign = ContentAlignment.TopRight;
            // 
            // lblOutput
            // 
            lblOutput.BorderStyle = BorderStyle.FixedSingle;
            lblOutput.Font = new Font("Segoe UI", 20F);
            lblOutput.Location = new Point(314, 295);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(184, 37);
            lblOutput.TabIndex = 7;
            lblOutput.TextAlign = ContentAlignment.TopRight;
            // 
            // btnCalc
            // 
            btnCalc.Font = new Font("Segoe UI", 20F);
            btnCalc.Location = new Point(580, 61);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(158, 88);
            btnCalc.TabIndex = 8;
            btnCalc.Text = "Calculate";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // frmTipCalc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalc);
            Controls.Add(lblOutput);
            Controls.Add(lblAmount);
            Controls.Add(txtTip);
            Controls.Add(txtBill);
            Controls.Add(lblTip);
            Controls.Add(lblTotal);
            Controls.Add(lblPercent);
            Controls.Add(lblBill);
            Name = "frmTipCalc";
            Text = "Tip Calc";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBill;
        private Label lblPercent;
        private Label lblTotal;
        private Label lblTip;
        private TextBox txtBill;
        private TextBox txtTip;
        private Label lblAmount;
        private Label lblOutput;
        private Button btnCalc;
    }
}
