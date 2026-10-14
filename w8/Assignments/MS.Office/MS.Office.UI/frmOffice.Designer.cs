namespace MS.Office.UI
{
    partial class frmOffice
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
            lblDept = new Label();
            txtDept = new TextBox();
            lblManager = new Label();
            btnEnter = new Button();
            SuspendLayout();
            // 
            // lblDept
            // 
            lblDept.AutoSize = true;
            lblDept.Location = new Point(184, 116);
            lblDept.Name = "lblDept";
            lblDept.Size = new Size(76, 15);
            lblDept.TabIndex = 0;
            lblDept.Text = "Department: ";
            // 
            // txtDept
            // 
            txtDept.Location = new Point(406, 116);
            txtDept.Name = "txtDept";
            txtDept.Size = new Size(164, 23);
            txtDept.TabIndex = 1;
            // 
            // lblManager
            // 
            lblManager.BorderStyle = BorderStyle.Fixed3D;
            lblManager.Location = new Point(184, 214);
            lblManager.Name = "lblManager";
            lblManager.Size = new Size(386, 140);
            lblManager.TabIndex = 2;
            lblManager.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(304, 168);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(142, 26);
            btnEnter.TabIndex = 3;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // frmOffice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEnter);
            Controls.Add(lblManager);
            Controls.Add(txtDept);
            Controls.Add(lblDept);
            Name = "frmOffice";
            Text = "Manager finder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDept;
        private TextBox txtDept;
        private Label lblManager;
        private Button btnEnter;
    }
}
