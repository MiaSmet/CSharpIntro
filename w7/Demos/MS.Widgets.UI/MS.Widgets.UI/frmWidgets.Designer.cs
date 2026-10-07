namespace MS.Widgets.UI
{
    partial class frmWidgets
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
            components = new System.ComponentModel.Container();
            btnGenerate = new Button();
            lblResult = new Label();
            lblMessage = new Label();
            btnPress = new Button();
            tmrGame = new System.Windows.Forms.Timer(components);
            lblTimer = new Label();
            lblCountdown = new Label();
            btnReset = new Button();
            SuspendLayout();
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(416, 298);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(300, 70);
            btnGenerate.TabIndex = 0;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // lblResult
            // 
            lblResult.BorderStyle = BorderStyle.Fixed3D;
            lblResult.Location = new Point(416, 225);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(300, 70);
            lblResult.TabIndex = 1;
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMessage
            // 
            lblMessage.BorderStyle = BorderStyle.Fixed3D;
            lblMessage.Location = new Point(416, 371);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(300, 72);
            lblMessage.TabIndex = 2;
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnPress
            // 
            btnPress.Location = new Point(67, 298);
            btnPress.Name = "btnPress";
            btnPress.Size = new Size(303, 67);
            btnPress.TabIndex = 3;
            btnPress.Text = "Press Me";
            btnPress.UseVisualStyleBackColor = true;
            btnPress.Click += btnPress_Click;
            btnPress.MouseEnter += btnPress_MouseEnter;
            // 
            // tmrGame
            // 
            tmrGame.Enabled = true;
            tmrGame.Interval = 1000;
            tmrGame.Tick += tmrGame_Tick;
            // 
            // lblTimer
            // 
            lblTimer.BorderStyle = BorderStyle.FixedSingle;
            lblTimer.Location = new Point(863, 262);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(187, 52);
            lblTimer.TabIndex = 4;
            // 
            // lblCountdown
            // 
            lblCountdown.BorderStyle = BorderStyle.FixedSingle;
            lblCountdown.Location = new Point(416, 554);
            lblCountdown.Name = "lblCountdown";
            lblCountdown.Size = new Size(300, 71);
            lblCountdown.TabIndex = 5;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(902, 322);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(96, 46);
            btnReset.TabIndex = 6;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // frmWidgets
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 711);
            Controls.Add(btnPress);
            Controls.Add(btnReset);
            Controls.Add(lblCountdown);
            Controls.Add(lblTimer);
            Controls.Add(lblMessage);
            Controls.Add(lblResult);
            Controls.Add(btnGenerate);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "frmWidgets";
            Text = "Widgets";
            ResumeLayout(false);
        }

        #endregion

        private Button btnGenerate;
        private Label lblResult;
        private Label lblMessage;
        private Button btnPress;
        private System.Windows.Forms.Timer tmrGame;
        private Label lblTimer;
        private Label lblCountdown;
        private Button btnReset;
    }
}
