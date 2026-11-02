namespace MS.Population.UI
{
    public partial class frmPopulation : Form
    {
        public frmPopulation()
        {
            InitializeComponent();
            AcceptButton = btnCalc;
            CancelButton = btnExit;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //checks for empty city & state
            if (txtCity.Text == "")
            {
                MessageBox.Show("Please enter a city name.");
                txtCity.Focus();
            }
            if (txtState.Text == "")
            {
                MessageBox.Show("Please enter a state abbreviation.");
                txtState.Focus();
            }

            //checks for positive integers
            bool beginCheck = int.TryParse(txtBeginPop.Text, out int begin) && begin > 0;
            bool endCheck = int.TryParse(txtEndPop.Text, out int end) && end > 0;
            if (beginCheck && endCheck)
            {
                //calculates increase/decrease
            }
            else
            {
                MessageBox.Show("Please enter a positive value.");
                if(beginCheck == false)
                {
                    txtBeginPop.Focus();
                    txtBeginPop.SelectAll();
                }
                else if (endCheck == false)
                {
                    txtEndPop.Focus();
                    txtEndPop.SelectAll();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clears all inputs
            txtCity.Text = "";
            txtState.Text = "";
            txtBeginPop.Text = "";
            txtEndPop.Text = "";
            lblDecrease.Text = "";
            lblIncrease.Text = "";
            txtCity.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exits the application
            Application.Exit();
        }

        private void txtBeginPop_TextChanged(object sender, EventArgs e)
        {
            //Clear calculated values
            lblDecrease.Text = "";
            lblIncrease.Text = "";
        }

        private void txtEndPop_TextChanged(object sender, EventArgs e)
        {
            //Clear calculated values
            lblDecrease.Text = "";
            lblIncrease.Text = "";
        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {
            //Clear calculated values
            lblDecrease.Text = "";
            lblIncrease.Text = "";
        }

        private void txtState_TextChanged(object sender, EventArgs e)
        {
            //Clear calculated values
            lblDecrease.Text = "";
            lblIncrease.Text = "";
        }
    }
}
