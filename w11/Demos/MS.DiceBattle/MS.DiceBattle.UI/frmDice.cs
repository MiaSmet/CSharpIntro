namespace MS.DiceBattle.UI
{
    public partial class frmDice : Form
    {
        private int pWins = 0;
        private int cWins = 0;
        public frmDice()
        {
            InitializeComponent();
            AcceptButton = btnPlay;
            CancelButton = btnExit;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            ResetGame();

            int rounds = ((int)nudRounds.Value);
            if(rounds <= 20 && rounds >= 1)
            {
                for (int i = 1; i <= rounds; i++)
                {
                    int pRoll = DiceRoll();
                    int cRoll = DiceRoll();
                    string results = GetRoundWinner(pRoll, cRoll);
                    lstResults.Items.Add($" Round " + i + ": You rolled a " + pRoll + ". The computer rolled a " + cRoll + ". " + results);
                }
                if (pWins > cWins)
                {
                    lblFinalScore.Text = "Overall winner: You!";
                }
                else if (cWins > pWins)
                {
                    lblFinalScore.Text = "Overall winner: You!";
                }
                else
                {
                    lblFinalScore.Text = "You tied overall!";
                }
            }
            else
            {
                MessageBox.Show("Please enter a number between 1 and 20");
                nudRounds.Focus();
                nudRounds.Select();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private int DiceRoll()
        {
            return Random.Shared.Next(1, 7);
        }
        private string GetRoundWinner(int pRoll, int cRoll)
        {
            if (pRoll > cRoll)
            {
                pWins++;
                return "You win!";
            }
            else if (pRoll < cRoll)
            {
                cWins++;
                return "Computer wins!";
            }
            else
            {
                return "Tie!";
            }
        }
        private void ResetGame()
        {

            pWins = 0;
            cWins = 0;
            nudRounds.Value = 1;
            lstResults.Text = "";
            lblFinalScore.Text = "Click Play to begin!";
        }
    }
}
