namespace MS.Week6Demo.UI
{
    public partial class frmDemo6 : Form
    {
        public frmDemo6()
        {
            InitializeComponent();
            AcceptButton = btnEnter;
            CancelButton = btnExit;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            int score = 0;
            if (int.TryParse(txtInput.Text, out score))
            {
                if (score >= 90)
                {
                    lblResult.Text = "Score is A";
                }
                else if (score >= 80)
                {
                    lblResult.Text = "Score is B";
                }
                else if (score >= 70)
                {
                    lblResult.Text = "Score is C";
                }
                else if (score >= 60)
                {
                    lblResult.Text = "Score is D";
                }
                else
                {
                    lblResult.Text = "Score is F";
                }
            }
            else
            {
                MessageBox.Show("Please enter a number");
            }
        }
    }
}
