namespace MS.Increment.UI
{
    partial class Form1
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
            btnMethod1 = new Button();
            btnMethod2 = new Button();
            btnMethod3 = new Button();
            lblIncrement = new Label();
            SuspendLayout();
            // 
            // btnMethod1
            // 
            btnMethod1.Location = new Point(82, 43);
            btnMethod1.Name = "btnMethod1";
            btnMethod1.Size = new Size(215, 80);
            btnMethod1.TabIndex = 0;
            btnMethod1.Text = "Method 1";
            btnMethod1.UseVisualStyleBackColor = true;
            btnMethod1.Click += btnMethod1_Click;
            // 
            // btnMethod2
            // 
            btnMethod2.Location = new Point(82, 170);
            btnMethod2.Name = "btnMethod2";
            btnMethod2.Size = new Size(215, 80);
            btnMethod2.TabIndex = 1;
            btnMethod2.Text = "Method 2";
            btnMethod2.UseVisualStyleBackColor = true;
            btnMethod2.Click += btnMethod2_Click;
            // 
            // btnMethod3
            // 
            btnMethod3.Location = new Point(82, 299);
            btnMethod3.Name = "btnMethod3";
            btnMethod3.Size = new Size(215, 80);
            btnMethod3.TabIndex = 2;
            btnMethod3.Text = "Method 3";
            btnMethod3.UseVisualStyleBackColor = true;
            btnMethod3.Click += btnMethod3_Click;
            // 
            // lblIncrement
            // 
            lblIncrement.BorderStyle = BorderStyle.FixedSingle;
            lblIncrement.Location = new Point(494, 170);
            lblIncrement.Name = "lblIncrement";
            lblIncrement.Size = new Size(198, 71);
            lblIncrement.TabIndex = 3;
            lblIncrement.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblIncrement);
            Controls.Add(btnMethod3);
            Controls.Add(btnMethod2);
            Controls.Add(btnMethod1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMethod1;
        private Button btnMethod2;
        private Button btnMethod3;
        private Label lblIncrement;
    }
}
