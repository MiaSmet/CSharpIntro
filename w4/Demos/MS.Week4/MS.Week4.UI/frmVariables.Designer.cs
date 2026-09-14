namespace MS.Week4.UI
{
    partial class frmVariables
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
            lblName = new Label();
            btnSubmit = new Button();
            txtFirst = new TextBox();
            txtSecond = new TextBox();
            btnCalculate = new Button();
            lblPlus = new Label();
            lblResult = new Label();
            lblEquals = new Label();
            btnClick = new Button();
            btnReset = new Button();
            lblClickCount = new Label();
            txtQuantity = new TextBox();
            lblTotalCost = new Label();
            btnCostCalc = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.BorderStyle = BorderStyle.FixedSingle;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(469, 380);
            lblName.Name = "lblName";
            lblName.Size = new Size(316, 61);
            lblName.TabIndex = 0;
            lblName.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(555, 351);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(134, 26);
            btnSubmit.TabIndex = 1;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtFirst
            // 
            txtFirst.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirst.Location = new Point(107, 35);
            txtFirst.Name = "txtFirst";
            txtFirst.Size = new Size(101, 43);
            txtFirst.TabIndex = 2;
            // 
            // txtSecond
            // 
            txtSecond.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSecond.Location = new Point(325, 35);
            txtSecond.Name = "txtSecond";
            txtSecond.Size = new Size(111, 43);
            txtSecond.TabIndex = 3;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(312, 100);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(134, 26);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblPlus
            // 
            lblPlus.AutoSize = true;
            lblPlus.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlus.Location = new Point(252, 41);
            lblPlus.Name = "lblPlus";
            lblPlus.Size = new Size(35, 37);
            lblPlus.TabIndex = 5;
            lblPlus.Text = "+";
            // 
            // lblResult
            // 
            lblResult.BorderStyle = BorderStyle.FixedSingle;
            lblResult.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(555, 37);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(149, 44);
            lblResult.TabIndex = 6;
            // 
            // lblEquals
            // 
            lblEquals.AutoSize = true;
            lblEquals.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEquals.Location = new Point(469, 41);
            lblEquals.Name = "lblEquals";
            lblEquals.Size = new Size(35, 37);
            lblEquals.TabIndex = 7;
            lblEquals.Text = "=";
            // 
            // btnClick
            // 
            btnClick.Location = new Point(12, 313);
            btnClick.Name = "btnClick";
            btnClick.Size = new Size(134, 26);
            btnClick.TabIndex = 8;
            btnClick.Text = "Click";
            btnClick.UseVisualStyleBackColor = true;
            btnClick.Click += btnClick_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(12, 412);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(134, 26);
            btnReset.TabIndex = 9;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // lblClickCount
            // 
            lblClickCount.BorderStyle = BorderStyle.FixedSingle;
            lblClickCount.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClickCount.Location = new Point(12, 342);
            lblClickCount.Name = "lblClickCount";
            lblClickCount.Size = new Size(134, 67);
            lblClickCount.TabIndex = 10;
            lblClickCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuantity.Location = new Point(97, 174);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(111, 43);
            txtQuantity.TabIndex = 11;
            // 
            // lblTotalCost
            // 
            lblTotalCost.BorderStyle = BorderStyle.FixedSingle;
            lblTotalCost.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalCost.Location = new Point(252, 173);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(219, 44);
            lblTotalCost.TabIndex = 12;
            // 
            // btnCostCalc
            // 
            btnCostCalc.Location = new Point(167, 232);
            btnCostCalc.Name = "btnCostCalc";
            btnCostCalc.Size = new Size(134, 26);
            btnCostCalc.TabIndex = 13;
            btnCostCalc.Text = "Calculate";
            btnCostCalc.UseVisualStyleBackColor = true;
            btnCostCalc.Click += btnCostCalc_Click;
            // 
            // frmVariables
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCostCalc);
            Controls.Add(lblTotalCost);
            Controls.Add(txtQuantity);
            Controls.Add(lblClickCount);
            Controls.Add(btnReset);
            Controls.Add(btnClick);
            Controls.Add(lblEquals);
            Controls.Add(lblResult);
            Controls.Add(lblPlus);
            Controls.Add(btnCalculate);
            Controls.Add(txtSecond);
            Controls.Add(txtFirst);
            Controls.Add(btnSubmit);
            Controls.Add(lblName);
            Name = "frmVariables";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Button btnSubmit;
        private TextBox txtFirst;
        private TextBox txtSecond;
        private Button btnCalculate;
        private Label lblPlus;
        private Label lblResult;
        private Label lblEquals;
        private Button btnClick;
        private Button btnReset;
        private Label lblClickCount;
        private TextBox txtQuantity;
        private Label lblTotalCost;
        private Button btnCostCalc;
    }
}
