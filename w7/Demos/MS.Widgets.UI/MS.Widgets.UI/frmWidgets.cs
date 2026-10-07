using System.Linq.Expressions;

namespace MS.Widgets.UI
{
    public partial class frmWidgets : Form
    {
        int countdown = 10;
        int count = 0;
        int counter = 0;

        int choice = 0;

        public frmWidgets()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            /*
            switch (choice)
            {
                case 1:
                    lblResult.Text = "Easy";
                    break;
                case 2:
                    lblResult.Text = "Medium";
                    break;
                case 3:
                    lblResult.Text = "Hard";
                    break;
                default:
                    lblResult.Text = "Select a difficulty";
                    break;
            }
            */
            int num = Random.Shared.Next(1, 101);
            lblResult.Text = num.ToString();
            if (num == 100)
            {
                lblMessage.Text = "You win!";
                lblMessage.ForeColor = Color.Green;
            }
            else
            {
                lblMessage.Text = "Try Again.";
                lblMessage.ForeColor = Color.Red;
            }
        }

        private void btnPress_Click(object sender, EventArgs e)
        {
            /*
            int x = Random.Shared.Next(0, ClientSize.Width - btnPress.Width);
            int y = Random.Shared.Next(0, ClientSize.Height - btnPress.Height);
            btnPress.Left = x;
            btnPress.Top = y;
            */
            count++;
            
            if(countdown > 0)
            {

                this.BackColor = Color.Green;
                MessageBox.Show("You caught it!");
            }
        }

        private void tmrGame_Tick(object sender, EventArgs e)
        {
            ///*
            countdown--;
            lblTimer.Text = countdown.ToString();
            if (countdown == 0)
            {
                tmrGame.Stop();
                MessageBox.Show("Game over! Score: " + count);
            }
            /*
            DateTime christmas = new DateTime(2026, 12, 25);
            TimeSpan timeLeft = christmas - DateTime.Now;

            lblCountdown.Text =
                $"{timeLeft.Days} days, " +
                $"{timeLeft.Hours} hours, " +
                $"{timeLeft.Minutes} minutes, " +
                $"{timeLeft.Seconds} seconds";
            */
        }

        private void btnPress_MouseEnter(object sender, EventArgs e)
        {
            counter++;
            int x = Random.Shared.Next(0, ClientSize.Width - btnPress.Width);
            int y = Random.Shared.Next(0, ClientSize.Height - btnPress.Height);
            btnPress.Left = x;
            btnPress.Top = y;
            /*
            if(counter > 10)
            {
                btnPress.Text = "Okay this is just sad";
            }
            else if (counter > 6)
            {
                btnPress.Text = "Want to try again?";
            }
            else if (counter > 3)
            {
                btnPress.Text = "You're too slow!";
            }
            else
            {
                btnPress.Text = "Catch me!";
            }
            */
            switch (counter)
            {
                case > 10:
                    btnPress.Text = "Okay this is just sad";
                    break;
                case > 6:
                    btnPress.Text = "Want to try again?";
                    break;
                case > 3:
                    btnPress.Text = "You're too slow!";
                    break;
                default:
                    btnPress.Text = "Catch me!";
                    break;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            countdown = 10;
            count = 0;
            counter = 0;
            tmrGame.Start();
        }
    }
}
