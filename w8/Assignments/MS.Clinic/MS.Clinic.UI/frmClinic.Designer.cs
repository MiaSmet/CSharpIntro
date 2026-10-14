namespace MS.Clinic.UI
{
    partial class frmClinic
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
            chkEmergency = new CheckBox();
            chkVacc = new CheckBox();
            chkExam = new CheckBox();
            chkHour = new CheckBox();
            chkSpay = new CheckBox();
            chkDay = new CheckBox();
            chkGrooming = new CheckBox();
            chkWeek = new CheckBox();
            lblP1 = new Label();
            lblP2 = new Label();
            lblP3 = new Label();
            lblP4 = new Label();
            lblP5 = new Label();
            lblP6 = new Label();
            lblP7 = new Label();
            lblP8 = new Label();
            lblCharges = new Label();
            lblTotal = new Label();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(72, 131);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(185, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Available services:";
            // 
            // chkEmergency
            // 
            chkEmergency.AutoSize = true;
            chkEmergency.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkEmergency.Location = new Point(72, 178);
            chkEmergency.Name = "chkEmergency";
            chkEmergency.Size = new Size(106, 25);
            chkEmergency.TabIndex = 1;
            chkEmergency.Text = "Emergency";
            chkEmergency.UseVisualStyleBackColor = true;
            chkEmergency.CheckedChanged += chkEmergency_CheckedChanged;
            // 
            // chkVacc
            // 
            chkVacc.AutoSize = true;
            chkVacc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkVacc.Location = new Point(72, 426);
            chkVacc.Name = "chkVacc";
            chkVacc.Size = new Size(108, 25);
            chkVacc.TabIndex = 2;
            chkVacc.Text = "Vaccination";
            chkVacc.UseVisualStyleBackColor = true;
            chkVacc.CheckedChanged += chkVacc_CheckedChanged;
            // 
            // chkExam
            // 
            chkExam.AutoSize = true;
            chkExam.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkExam.Location = new Point(72, 240);
            chkExam.Name = "chkExam";
            chkExam.Size = new Size(66, 25);
            chkExam.TabIndex = 3;
            chkExam.Text = "Exam";
            chkExam.UseVisualStyleBackColor = true;
            chkExam.CheckedChanged += chkExam_CheckedChanged;
            // 
            // chkHour
            // 
            chkHour.AutoSize = true;
            chkHour.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkHour.Location = new Point(72, 486);
            chkHour.Name = "chkHour";
            chkHour.Size = new Size(164, 25);
            chkHour.TabIndex = 4;
            chkHour.Text = "One Hour Boarding";
            chkHour.UseVisualStyleBackColor = true;
            chkHour.CheckedChanged += chkHour_CheckedChanged;
            // 
            // chkSpay
            // 
            chkSpay.AutoSize = true;
            chkSpay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkSpay.Location = new Point(72, 364);
            chkSpay.Name = "chkSpay";
            chkSpay.Size = new Size(117, 25);
            chkSpay.TabIndex = 5;
            chkSpay.Text = "Spay/Neuter";
            chkSpay.UseVisualStyleBackColor = true;
            chkSpay.CheckedChanged += chkSpay_CheckedChanged;
            // 
            // chkDay
            // 
            chkDay.AutoSize = true;
            chkDay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkDay.Location = new Point(72, 543);
            chkDay.Name = "chkDay";
            chkDay.Size = new Size(156, 25);
            chkDay.TabIndex = 6;
            chkDay.Text = "One Day Boarding";
            chkDay.UseVisualStyleBackColor = true;
            chkDay.CheckedChanged += chkDay_CheckedChanged;
            // 
            // chkGrooming
            // 
            chkGrooming.AutoSize = true;
            chkGrooming.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkGrooming.Location = new Point(72, 302);
            chkGrooming.Name = "chkGrooming";
            chkGrooming.Size = new Size(100, 25);
            chkGrooming.TabIndex = 7;
            chkGrooming.Text = "Grooming";
            chkGrooming.UseVisualStyleBackColor = true;
            chkGrooming.CheckedChanged += chkGrooming_CheckedChanged;
            // 
            // chkWeek
            // 
            chkWeek.AutoSize = true;
            chkWeek.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkWeek.Location = new Point(72, 599);
            chkWeek.Name = "chkWeek";
            chkWeek.Size = new Size(167, 25);
            chkWeek.TabIndex = 8;
            chkWeek.Text = "One Week Boarding";
            chkWeek.UseVisualStyleBackColor = true;
            chkWeek.CheckedChanged += chkWeek_CheckedChanged;
            // 
            // lblP1
            // 
            lblP1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblP1.Location = new Point(638, 178);
            lblP1.Name = "lblP1";
            lblP1.Size = new Size(86, 25);
            lblP1.TabIndex = 9;
            // 
            // lblP2
            // 
            lblP2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblP2.Location = new Point(638, 240);
            lblP2.Name = "lblP2";
            lblP2.Size = new Size(86, 25);
            lblP2.TabIndex = 10;
            // 
            // lblP3
            // 
            lblP3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblP3.Location = new Point(638, 302);
            lblP3.Name = "lblP3";
            lblP3.Size = new Size(86, 25);
            lblP3.TabIndex = 11;
            // 
            // lblP4
            // 
            lblP4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblP4.Location = new Point(638, 364);
            lblP4.Name = "lblP4";
            lblP4.Size = new Size(86, 25);
            lblP4.TabIndex = 12;
            // 
            // lblP5
            // 
            lblP5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblP5.Location = new Point(638, 426);
            lblP5.Name = "lblP5";
            lblP5.Size = new Size(86, 25);
            lblP5.TabIndex = 13;
            // 
            // lblP6
            // 
            lblP6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblP6.Location = new Point(638, 486);
            lblP6.Name = "lblP6";
            lblP6.Size = new Size(86, 25);
            lblP6.TabIndex = 14;
            // 
            // lblP7
            // 
            lblP7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblP7.Location = new Point(638, 543);
            lblP7.Name = "lblP7";
            lblP7.Size = new Size(86, 25);
            lblP7.TabIndex = 15;
            // 
            // lblP8
            // 
            lblP8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblP8.Location = new Point(638, 599);
            lblP8.Name = "lblP8";
            lblP8.Size = new Size(86, 25);
            lblP8.TabIndex = 16;
            // 
            // lblCharges
            // 
            lblCharges.AutoSize = true;
            lblCharges.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCharges.Location = new Point(72, 665);
            lblCharges.Name = "lblCharges";
            lblCharges.Size = new Size(145, 30);
            lblCharges.TabIndex = 17;
            lblCharges.Text = "Total charges:";
            // 
            // lblTotal
            // 
            lblTotal.BorderStyle = BorderStyle.Fixed3D;
            lblTotal.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(540, 665);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(184, 30);
            lblTotal.TabIndex = 18;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(76, 738);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(141, 37);
            btnClear.TabIndex = 20;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(540, 738);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(141, 37);
            btnExit.TabIndex = 20;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmClinic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 820);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(lblTotal);
            Controls.Add(lblCharges);
            Controls.Add(lblP8);
            Controls.Add(lblP7);
            Controls.Add(lblP6);
            Controls.Add(lblP5);
            Controls.Add(lblP4);
            Controls.Add(lblP3);
            Controls.Add(lblP2);
            Controls.Add(lblP1);
            Controls.Add(chkWeek);
            Controls.Add(chkGrooming);
            Controls.Add(chkDay);
            Controls.Add(chkSpay);
            Controls.Add(chkHour);
            Controls.Add(chkExam);
            Controls.Add(chkVacc);
            Controls.Add(chkEmergency);
            Controls.Add(lblTitle);
            Name = "frmClinic";
            Text = "Pet Clinic";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private CheckBox chkEmergency;
        private CheckBox chkVacc;
        private CheckBox chkExam;
        private CheckBox chkHour;
        private CheckBox chkSpay;
        private CheckBox chkDay;
        private CheckBox chkGrooming;
        private CheckBox chkWeek;
        private Label lblP1;
        private Label lblP2;
        private Label lblP3;
        private Label lblP4;
        private Label lblP5;
        private Label lblP6;
        private Label lblP7;
        private Label lblP8;
        private Label lblCharges;
        private Label lblTotal;
        private Button btnClear;
        private Button btnExit;
    }
}
