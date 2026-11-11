namespace MS.Looping.UI
{
    public partial class Looping : Form
    {
        public Looping()
        {
            InitializeComponent();
            AcceptButton = btnDisplay;
            CancelButton = btnExit;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            //instantiate phrase
            string phrase = txtPhrase.Text;
            //check for positive number
            if(int.TryParse(txtRep.Text, out int reps) && reps > 0)
            {
                //loop until rep number is reached
                for (int i = 1; i <= reps; i++)
                {
                    lstOutput.Items.Add(i+ ". " + phrase);
                }
            }
            else
            {
                //error handling
                MessageBox.Show("Please enter a positive number");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clears inputs and output
            txtPhrase.Text = "";
            txtRep.Text = "";
            lstOutput.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exits the application
            Application.Exit();
        }
    }
}
