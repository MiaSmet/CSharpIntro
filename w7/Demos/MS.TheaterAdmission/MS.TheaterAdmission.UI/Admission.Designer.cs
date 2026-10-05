namespace MS.TheaterAdmission.UI
{
    partial class Admission
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
            lblAge = new Label();
            lblTitle = new Label();
            txtAge = new TextBox();
            chkParent = new CheckBox();
            chkTicket = new CheckBox();
            chkBanned = new CheckBox();
            btnCheck = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 14F);
            lblAge.Location = new Point(43, 81);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(135, 25);
            lblAge.TabIndex = 0;
            lblAge.Text = "Customer Age:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(194, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(382, 45);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Movie Theater Admission";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(44, 125);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(86, 23);
            txtAge.TabIndex = 2;
            // 
            // chkParent
            // 
            chkParent.AutoSize = true;
            chkParent.Location = new Point(43, 168);
            chkParent.Name = "chkParent";
            chkParent.Size = new Size(150, 19);
            chkParent.TabIndex = 3;
            chkParent.Text = "Parent is with customer";
            chkParent.UseVisualStyleBackColor = true;
            // 
            // chkTicket
            // 
            chkTicket.AutoSize = true;
            chkTicket.Location = new Point(43, 193);
            chkTicket.Name = "chkTicket";
            chkTicket.Size = new Size(140, 19);
            chkTicket.TabIndex = 4;
            chkTicket.Text = "Customer has a ticket";
            chkTicket.UseVisualStyleBackColor = true;
            // 
            // chkBanned
            // 
            chkBanned.AutoSize = true;
            chkBanned.Location = new Point(43, 218);
            chkBanned.Name = "chkBanned";
            chkBanned.Size = new Size(132, 19);
            chkBanned.TabIndex = 5;
            chkBanned.Text = "Customer is banned";
            chkBanned.UseVisualStyleBackColor = true;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(32, 267);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(161, 47);
            btnCheck.TabIndex = 6;
            btnCheck.Text = "Check Admission";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(32, 343);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(45, 15);
            lblResult.TabIndex = 7;
            lblResult.Text = "Result: ";
            // 
            // Admission
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnCheck);
            Controls.Add(chkBanned);
            Controls.Add(chkTicket);
            Controls.Add(chkParent);
            Controls.Add(txtAge);
            Controls.Add(lblTitle);
            Controls.Add(lblAge);
            Name = "Admission";
            Text = "Movie Theater Admission";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAge;
        private Label lblTitle;
        private TextBox txtAge;
        private CheckBox chkParent;
        private CheckBox chkTicket;
        private CheckBox chkBanned;
        private Button btnCheck;
        private Label lblResult;
    }
}
