namespace MS.StateCapitals.UI
{
    partial class frmCapitals
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
            lblStart = new Label();
            lblState = new Label();
            btnWisconsin = new Button();
            lblMiddle = new Label();
            lblCapital = new Label();
            btnCalifornia = new Button();
            btnIdaho = new Button();
            btnNebraska = new Button();
            btnNewYork = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblStart
            // 
            lblStart.AutoSize = true;
            lblStart.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStart.Location = new Point(486, 57);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(184, 38);
            lblStart.TabIndex = 0;
            lblStart.Text = "The capital of";
            // 
            // lblState
            // 
            lblState.BorderStyle = BorderStyle.Fixed3D;
            lblState.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblState.Location = new Point(496, 103);
            lblState.Name = "lblState";
            lblState.Size = new Size(174, 48);
            lblState.TabIndex = 1;
            // 
            // btnWisconsin
            // 
            btnWisconsin.Location = new Point(69, 67);
            btnWisconsin.Name = "btnWisconsin";
            btnWisconsin.Size = new Size(227, 54);
            btnWisconsin.TabIndex = 2;
            btnWisconsin.Text = "Wisconsin";
            btnWisconsin.UseVisualStyleBackColor = true;
            btnWisconsin.Click += btnWisconsin_Click;
            // 
            // lblMiddle
            // 
            lblMiddle.AutoSize = true;
            lblMiddle.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMiddle.Location = new Point(497, 151);
            lblMiddle.Name = "lblMiddle";
            lblMiddle.Size = new Size(36, 38);
            lblMiddle.TabIndex = 3;
            lblMiddle.Text = "is";
            // 
            // lblCapital
            // 
            lblCapital.BorderStyle = BorderStyle.Fixed3D;
            lblCapital.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCapital.Location = new Point(497, 200);
            lblCapital.Name = "lblCapital";
            lblCapital.Size = new Size(173, 41);
            lblCapital.TabIndex = 4;
            // 
            // btnCalifornia
            // 
            btnCalifornia.Location = new Point(69, 127);
            btnCalifornia.Name = "btnCalifornia";
            btnCalifornia.Size = new Size(227, 54);
            btnCalifornia.TabIndex = 5;
            btnCalifornia.Text = "California";
            btnCalifornia.UseVisualStyleBackColor = true;
            btnCalifornia.Click += btnCalifornia_Click;
            // 
            // btnIdaho
            // 
            btnIdaho.Location = new Point(69, 187);
            btnIdaho.Name = "btnIdaho";
            btnIdaho.Size = new Size(227, 54);
            btnIdaho.TabIndex = 6;
            btnIdaho.Text = "Idaho";
            btnIdaho.UseVisualStyleBackColor = true;
            btnIdaho.Click += btnIdaho_Click;
            // 
            // btnNebraska
            // 
            btnNebraska.Location = new Point(69, 247);
            btnNebraska.Name = "btnNebraska";
            btnNebraska.Size = new Size(227, 54);
            btnNebraska.TabIndex = 7;
            btnNebraska.Text = "Nebraska";
            btnNebraska.UseVisualStyleBackColor = true;
            btnNebraska.Click += btnNebraska_Click;
            // 
            // btnNewYork
            // 
            btnNewYork.Location = new Point(69, 307);
            btnNewYork.Name = "btnNewYork";
            btnNewYork.Size = new Size(227, 54);
            btnNewYork.TabIndex = 8;
            btnNewYork.Text = "New York";
            btnNewYork.UseVisualStyleBackColor = true;
            btnNewYork.Click += btnNewYork_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(408, 289);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(165, 69);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(579, 289);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(165, 69);
            btnExit.TabIndex = 10;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmCapitals
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aquamarine;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnNewYork);
            Controls.Add(btnNebraska);
            Controls.Add(btnIdaho);
            Controls.Add(btnCalifornia);
            Controls.Add(lblCapital);
            Controls.Add(lblMiddle);
            Controls.Add(btnWisconsin);
            Controls.Add(lblState);
            Controls.Add(lblStart);
            Name = "frmCapitals";
            Text = "State Capitals";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStart;
        private Label lblState;
        private Button btnWisconsin;
        private Label lblMiddle;
        private Label lblCapital;
        private Button btnCalifornia;
        private Button btnIdaho;
        private Button btnNebraska;
        private Button btnNewYork;
        private Button btnClear;
        private Button btnExit;
    }
}
