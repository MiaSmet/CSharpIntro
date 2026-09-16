namespace MS.MilesToKilos.UI
{
    partial class frmMiles
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
            lblMiles = new Label();
            lblKilos = new Label();
            txtMiles = new TextBox();
            lblOutput = new Label();
            btnConvert = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblMiles
            // 
            lblMiles.AutoSize = true;
            lblMiles.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMiles.Location = new Point(86, 84);
            lblMiles.Name = "lblMiles";
            lblMiles.Size = new Size(57, 25);
            lblMiles.TabIndex = 6;
            lblMiles.Text = "Miles";
            // 
            // lblKilos
            // 
            lblKilos.AutoSize = true;
            lblKilos.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKilos.Location = new Point(86, 213);
            lblKilos.Name = "lblKilos";
            lblKilos.Size = new Size(101, 25);
            lblKilos.TabIndex = 5;
            lblKilos.Text = "Kilometers";
            // 
            // txtMiles
            // 
            txtMiles.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMiles.Location = new Point(329, 76);
            txtMiles.Name = "txtMiles";
            txtMiles.Size = new Size(148, 33);
            txtMiles.TabIndex = 0;
            txtMiles.TextAlign = HorizontalAlignment.Right;
            txtMiles.TextChanged += txtMiles_TextChanged;
            // 
            // lblOutput
            // 
            lblOutput.BorderStyle = BorderStyle.Fixed3D;
            lblOutput.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOutput.Location = new Point(329, 205);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(148, 33);
            lblOutput.TabIndex = 1;
            lblOutput.TextAlign = ContentAlignment.TopRight;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(86, 335);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(98, 53);
            btnConvert.TabIndex = 2;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(318, 335);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(98, 53);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(567, 335);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(98, 53);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmMiles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnConvert);
            Controls.Add(lblOutput);
            Controls.Add(txtMiles);
            Controls.Add(lblKilos);
            Controls.Add(lblMiles);
            Name = "frmMiles";
            Text = "Miles to Kilometers";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMiles;
        private Label lblKilos;
        private TextBox txtMiles;
        private Label lblOutput;
        private Button btnConvert;
        private Button btnClear;
        private Button btnExit;
    }
}
