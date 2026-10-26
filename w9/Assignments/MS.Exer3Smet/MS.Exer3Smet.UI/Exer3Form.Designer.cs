namespace MS.Exer3Smet.UI
{
    partial class Exer3Form
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
            lblQuantity = new Label();
            txtSold = new TextBox();
            btnCalc = new Button();
            btnExit = new Button();
            btnClear = new Button();
            lblAmount = new Label();
            lblTotal = new Label();
            SuspendLayout();
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(65, 38);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(79, 15);
            lblQuantity.TabIndex = 4;
            lblQuantity.Text = "Quantity Sold";
            // 
            // txtSold
            // 
            txtSold.Location = new Point(176, 30);
            txtSold.Name = "txtSold";
            txtSold.Size = new Size(151, 23);
            txtSold.TabIndex = 0;
            txtSold.TextChanged += txtSold_TextChanged;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(28, 86);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(107, 58);
            btnCalc.TabIndex = 1;
            btnCalc.Text = "Calculate";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(254, 86);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(107, 58);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(141, 86);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(107, 58);
            btnClear.TabIndex = 2;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAmount.Location = new Point(41, 191);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(122, 25);
            lblAmount.TabIndex = 5;
            lblAmount.Text = "Amount Due";
            // 
            // lblTotal
            // 
            lblTotal.BorderStyle = BorderStyle.Fixed3D;
            lblTotal.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(191, 191);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(168, 25);
            lblTotal.TabIndex = 6;
            lblTotal.TextAlign = ContentAlignment.TopRight;
            // 
            // Exer3Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 258);
            Controls.Add(lblTotal);
            Controls.Add(lblAmount);
            Controls.Add(btnClear);
            Controls.Add(btnExit);
            Controls.Add(btnCalc);
            Controls.Add(txtSold);
            Controls.Add(lblQuantity);
            Name = "Exer3Form";
            Text = "Exercise 3 ~ Software Sales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblQuantity;
        private TextBox txtSold;
        private Button btnCalc;
        private Button btnExit;
        private Button btnClear;
        private Label lblAmount;
        private Label lblTotal;
    }
}
