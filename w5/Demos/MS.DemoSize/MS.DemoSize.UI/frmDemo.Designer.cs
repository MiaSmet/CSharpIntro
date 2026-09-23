namespace MS.DemoSize.UI
{
    partial class frmDemo
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
            txtNumber = new TextBox();
            lblResults = new Label();
            btnGenerate = new Button();
            SuspendLayout();
            // 
            // txtNumber
            // 
            txtNumber.Font = new Font("Segoe UI", 16F);
            txtNumber.Location = new Point(243, 67);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(212, 36);
            txtNumber.TabIndex = 0;
            // 
            // lblResults
            // 
            lblResults.BorderStyle = BorderStyle.FixedSingle;
            lblResults.Location = new Point(243, 139);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(212, 106);
            lblResults.TabIndex = 1;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(243, 285);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(212, 109);
            btnGenerate.TabIndex = 2;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // frmDemo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGenerate);
            Controls.Add(lblResults);
            Controls.Add(txtNumber);
            Name = "frmDemo";
            Text = "Demo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumber;
        private Label lblResults;
        private Button btnGenerate;
    }
}
