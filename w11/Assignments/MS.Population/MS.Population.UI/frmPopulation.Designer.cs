namespace MS.Population.UI
{
    partial class frmPopulation
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
            lblCTitle = new Label();
            lblSTitle = new Label();
            btnCalc = new Button();
            btnClear = new Button();
            btnExit = new Button();
            txtCity = new TextBox();
            txtState = new TextBox();
            txtBeginPop = new TextBox();
            txtEndPop = new TextBox();
            gbxPercent = new GroupBox();
            lblDecrease = new Label();
            lblPerDec = new Label();
            lblIncrease = new Label();
            lblPerInc = new Label();
            gbxPercent.SuspendLayout();
            SuspendLayout();
            // 
            // lblCTitle
            // 
            lblCTitle.AutoSize = true;
            lblCTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCTitle.Location = new Point(51, 46);
            lblCTitle.Name = "lblCTitle";
            lblCTitle.Size = new Size(37, 21);
            lblCTitle.TabIndex = 0;
            lblCTitle.Text = "City";
            // 
            // lblSTitle
            // 
            lblSTitle.AutoSize = true;
            lblSTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSTitle.Location = new Point(410, 51);
            lblSTitle.Name = "lblSTitle";
            lblSTitle.Size = new Size(44, 21);
            lblSTitle.TabIndex = 1;
            lblSTitle.Text = "State";
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(51, 391);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(178, 47);
            btnCalc.TabIndex = 4;
            btnCalc.Text = "Calculate";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(276, 391);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(178, 47);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(494, 391);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(178, 47);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(51, 70);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(192, 23);
            txtCity.TabIndex = 8;
            txtCity.TextChanged += txtCity_TextChanged;
            // 
            // txtState
            // 
            txtState.BackColor = SystemColors.Window;
            txtState.CharacterCasing = CharacterCasing.Upper;
            txtState.Location = new Point(410, 75);
            txtState.MaxLength = 2;
            txtState.Name = "txtState";
            txtState.Size = new Size(83, 23);
            txtState.TabIndex = 9;
            txtState.TextChanged += txtState_TextChanged;
            // 
            // txtBeginPop
            // 
            txtBeginPop.Location = new Point(51, 170);
            txtBeginPop.Name = "txtBeginPop";
            txtBeginPop.RightToLeft = RightToLeft.Yes;
            txtBeginPop.Size = new Size(192, 23);
            txtBeginPop.TabIndex = 10;
            txtBeginPop.TextChanged += txtBeginPop_TextChanged;
            // 
            // txtEndPop
            // 
            txtEndPop.Location = new Point(51, 264);
            txtEndPop.Name = "txtEndPop";
            txtEndPop.RightToLeft = RightToLeft.Yes;
            txtEndPop.Size = new Size(192, 23);
            txtEndPop.TabIndex = 11;
            txtEndPop.TextChanged += txtEndPop_TextChanged;
            // 
            // gbxPercent
            // 
            gbxPercent.Controls.Add(lblDecrease);
            gbxPercent.Controls.Add(lblPerDec);
            gbxPercent.Controls.Add(lblIncrease);
            gbxPercent.Controls.Add(lblPerInc);
            gbxPercent.Location = new Point(410, 170);
            gbxPercent.Name = "gbxPercent";
            gbxPercent.Size = new Size(200, 164);
            gbxPercent.TabIndex = 12;
            gbxPercent.TabStop = false;
            gbxPercent.Text = "Percent Change";
            // 
            // lblDecrease
            // 
            lblDecrease.BorderStyle = BorderStyle.Fixed3D;
            lblDecrease.Location = new Point(18, 115);
            lblDecrease.Name = "lblDecrease";
            lblDecrease.Size = new Size(133, 23);
            lblDecrease.TabIndex = 3;
            lblDecrease.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPerDec
            // 
            lblPerDec.AutoSize = true;
            lblPerDec.Location = new Point(16, 94);
            lblPerDec.Name = "lblPerDec";
            lblPerDec.Size = new Size(97, 15);
            lblPerDec.TabIndex = 2;
            lblPerDec.Text = "Percent Decrease";
            // 
            // lblIncrease
            // 
            lblIncrease.BorderStyle = BorderStyle.Fixed3D;
            lblIncrease.Location = new Point(16, 45);
            lblIncrease.Name = "lblIncrease";
            lblIncrease.Size = new Size(133, 23);
            lblIncrease.TabIndex = 1;
            lblIncrease.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPerInc
            // 
            lblPerInc.AutoSize = true;
            lblPerInc.Location = new Point(14, 24);
            lblPerInc.Name = "lblPerInc";
            lblPerInc.Size = new Size(93, 15);
            lblPerInc.TabIndex = 0;
            lblPerInc.Text = "Percent Increase";
            // 
            // frmPopulation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbxPercent);
            Controls.Add(txtEndPop);
            Controls.Add(txtBeginPop);
            Controls.Add(txtState);
            Controls.Add(txtCity);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalc);
            Controls.Add(lblSTitle);
            Controls.Add(lblCTitle);
            Name = "frmPopulation";
            Text = "Compare Population";
            gbxPercent.ResumeLayout(false);
            gbxPercent.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCTitle;
        private Label lblSTitle;
        private Button btnCalc;
        private Button btnClear;
        private Button btnExit;
        private TextBox txtCity;
        private TextBox txtState;
        private TextBox txtBeginPop;
        private TextBox txtEndPop;
        private GroupBox gbxPercent;
        private Label lblIncrease;
        private Label lblPerInc;
        private Label lblDecrease;
        private Label lblPerDec;
    }
}
