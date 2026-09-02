namespace MS.W2Demo.UI
{
    partial class frmHello
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
            btnSpanish = new Button();
            btnGerman = new Button();
            btnGaelic = new Button();
            lblHello = new Label();
            SuspendLayout();
            // 
            // btnSpanish
            // 
            btnSpanish.Location = new Point(24, 118);
            btnSpanish.Name = "btnSpanish";
            btnSpanish.Size = new Size(159, 37);
            btnSpanish.TabIndex = 0;
            btnSpanish.Text = "Spanish";
            btnSpanish.UseVisualStyleBackColor = true;
            btnSpanish.Click += btnSpanish_Click;
            // 
            // btnGerman
            // 
            btnGerman.Location = new Point(24, 161);
            btnGerman.Name = "btnGerman";
            btnGerman.Size = new Size(159, 37);
            btnGerman.TabIndex = 1;
            btnGerman.Text = "German";
            btnGerman.UseVisualStyleBackColor = true;
            btnGerman.Click += btnGerman_Click;
            // 
            // btnGaelic
            // 
            btnGaelic.Location = new Point(24, 204);
            btnGaelic.Name = "btnGaelic";
            btnGaelic.Size = new Size(159, 37);
            btnGaelic.TabIndex = 2;
            btnGaelic.Text = "Gaelic";
            btnGaelic.UseVisualStyleBackColor = true;
            btnGaelic.Click += btnGaelic_Click;
            // 
            // lblHello
            // 
            lblHello.BorderStyle = BorderStyle.FixedSingle;
            lblHello.Font = new Font("Segoe UI Semibold", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHello.Location = new Point(401, 138);
            lblHello.Name = "lblHello";
            lblHello.Size = new Size(346, 80);
            lblHello.TabIndex = 3;
            lblHello.Text = "Hello";
            lblHello.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmHello
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblHello);
            Controls.Add(btnGaelic);
            Controls.Add(btnGerman);
            Controls.Add(btnSpanish);
            Name = "frmHello";
            Text = "Hello";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSpanish;
        private Button btnGerman;
        private Button btnGaelic;
        private Label lblHello;
    }
}
