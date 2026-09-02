namespace MS.StateCapitals.UI
{
    public partial class frmCapitals : Form
    {
        public frmCapitals()
        {
            InitializeComponent();
        }

        private void btnWisconsin_Click(object sender, EventArgs e)
        {
            //display state and capital of Wisconsin
            lblState.Text = "Wisconsin";
            lblCapital.Text = "Madison";
        }

        private void btnCalifornia_Click(object sender, EventArgs e)
        {
            //display state and capital of California
            lblState.Text = "California";
            lblCapital.Text = "Sacramento";
        }

        private void btnIdaho_Click(object sender, EventArgs e)
        {
            //display state and capital of Idaho
            lblState.Text = "Idaho";
            lblCapital.Text = "Boise";
        }

        private void btnNebraska_Click(object sender, EventArgs e)
        {
            //display state and capital of Nebraska
            lblState.Text = "Nebraska";
            lblCapital.Text = "Lincoln";
        }

        private void btnNewYork_Click(object sender, EventArgs e)
        {
            //display state and capital of New York
            lblState.Text = "New York";
            lblCapital.Text = "Albany";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clears text from the state and capital labels
            lblState.Text = "";
            lblCapital.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
