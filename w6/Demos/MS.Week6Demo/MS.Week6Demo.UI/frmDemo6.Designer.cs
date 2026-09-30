namespace MS.Week6Demo.UI
{
    partial class frmDemo6
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
            btnExit = new Button();
            btnEnter = new Button();
            txtInput = new TextBox();
            lblResult = new Label();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Location = new Point(370, 305);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(219, 305);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(75, 23);
            btnEnter.TabIndex = 1;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(219, 161);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(226, 23);
            txtInput.TabIndex = 2;
            // 
            // lblResult
            // 
            lblResult.BorderStyle = BorderStyle.Fixed3D;
            lblResult.Location = new Point(156, 217);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(426, 34);
            lblResult.TabIndex = 3;
            // 
            // frmDemo6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(txtInput);
            Controls.Add(btnEnter);
            Controls.Add(btnExit);
            Name = "frmDemo6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Week 6 Demo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Button btnEnter;
        private TextBox txtInput;
        private Label lblResult;
    }
}
