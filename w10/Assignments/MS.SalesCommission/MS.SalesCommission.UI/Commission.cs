namespace MS.SalesCommission.UI
{
    public partial class Commission : Form
    {
        const double COMMISSION = .1;
        public Commission()
        {
            InitializeComponent();
            AcceptButton = btnCalc;
            CancelButton = btnExit;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //instantiate and set variables
            string last = txtLast.Text;
            string first = txtFirst.Text;
            //check for a positive number in sales
            if (double.TryParse(txtSales.Text, out double sales) && sales >= 0)
            {
                //calculate and output commission
                double calc = sales * COMMISSION;
                lblFinal.Text = sales.ToString("C");
                //Check for names and output commission title
                if(first == "" && last == "")
                {
                    lblCommission.Text = "Commission";
                }
                else if(first == "")
                {
                    lblCommission.Text = "Commission for " + last;
                }
                else if (last == "")
                {
                    lblCommission.Text = "Commission for " + first;
                }
                else
                {
                    lblCommission.Text = "Commission for " + first + " " + last;
                }

            }
            else
            {
                //error handling
                MessageBox.Show("Please enter a positive number in Sales.");
                txtSales.SelectAll();
                txtSales.Focus();
            }
        }

        private void txtLast_TextChanged(object sender, EventArgs e)
        {
            //clears output labels
            lblCommission.Text = "";
            lblFinal.Text = "";
        }

        private void txtFirst_TextChanged(object sender, EventArgs e)
        {
            //clears output labels
            lblCommission.Text = "";
            lblFinal.Text = "";
        }

        private void txtSales_TextChanged(object sender, EventArgs e)
        {
            //clears output labels
            lblCommission.Text = "";
            lblFinal.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clears all
            txtFirst.Text = "";
            txtLast.Text = "";
            txtSales.Text = "";
            lblCommission.Text = "";
            lblFinal.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exits the application
            Application.Exit();
        }
    }
}
