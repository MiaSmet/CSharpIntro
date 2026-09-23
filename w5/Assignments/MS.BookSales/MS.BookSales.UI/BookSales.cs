namespace MS.BookSales.UI
{
    public partial class BookSales : Form
    {
        //declare and set constant variable
        const double DISCOUNT = .25;
        public BookSales()
        {
            InitializeComponent();
            //button shortcuts
            AcceptButton = btnCalc;
            CancelButton = btnExit;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // declare variables
            double dblTotal;
            double dblAmount;
            double dblFinal;

            try
            {
                //remove $ from the start if it's there
                string strText = txtTotal.Text;
                if (strText.Contains("$"))
                {
                    string strRemText = strText.Replace('$', ' ');
                    dblTotal = double.Parse(strRemText);
                }
                else
                {
                    dblTotal = double.Parse(strText);
                }

                //declare and set other variables
                dblAmount = dblTotal * DISCOUNT;
                dblFinal = dblTotal - dblAmount;

                //display calculated values
                lblDiscCalc.Text = "$" + dblAmount.ToString("n2");
                lblFinalCalc.Text = "$" + dblFinal.ToString("n2");
            }
            catch (Exception)
            {
                //Error handling for text and no input
                MessageBox.Show("Please enter a number");
            }

            

            
            txtTotal.Focus();
            txtTotal.SelectAll();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clears all numbers and focuses the text box
            txtTotal.Text = "";
            lblDiscCalc.Text = "";
            lblFinalCalc.Text = "";
            txtTotal.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //closes the application
            Application.Exit();
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            //clears labels when you start typing
            lblDiscCalc.Text = "";
            lblFinalCalc.Text = "";
        }
    }
}
