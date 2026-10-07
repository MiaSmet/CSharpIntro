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
            
            if(cChoice == pChoice)
            {
                
            }
        }
    }
}
