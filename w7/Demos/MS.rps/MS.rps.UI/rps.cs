namespace MS.rps.UI
{
    public partial class rps : Form
    {
        public rps()
        {
            InitializeComponent();
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            playGame(1);
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            playGame(2);
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            playGame(3);
        }

        private void playGame(int pChoice)
        {
            int cChoice = Random.Shared.Next(1, 4);

            switch (pChoice)
            {
                case 1:
                   switch(cChoice)
                    {
                        case 2:
                            lblResult.Text = "You lose!";
                            break;
                        case 3:
                            lblResult.Text = "You win!";
                            break;
                        default:
                            lblResult.Text = "You tied!";
                            break;

                    }
                    break;
                case 2:
                    switch (cChoice)
                    {
                        case 3:
                            lblResult.Text = "You lose!";
                            break;
                        case 1:
                            lblResult.Text = "You win!";
                            break;
                        default:
                            lblResult.Text = "You tied!";
                            break;

                    }
                   break;
                default:
                    switch (cChoice)
                    {
                        case 1:
                            lblResult.Text = "You lose!";
                            break;
                        case 2:
                            lblResult.Text = "You win!";
                            break;
                        default:
                            lblResult.Text = "You tied!";
                            break;

                    }
                    break;
                }
            
        }
    }
}
