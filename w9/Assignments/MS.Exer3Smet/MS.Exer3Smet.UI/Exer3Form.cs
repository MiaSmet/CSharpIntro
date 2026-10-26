namespace MS.Exer3Smet.UI
{
    public partial class Exer3Form : Form
    {
        //instatiate variables
        int quantity;
        double total;
        const int PRICE = 99;
        public Exer3Form()
        {
            InitializeComponent();
            //access keys
            AcceptButton = btnCalc;
            CancelButton = btnExit;

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //test if the text box has an integer in it
            if(int.TryParse(txtSold.Text, out quantity))
            {
                //checks for negatives
                if(quantity < 0)
                {
                    txtSold.Focus();
                    txtSold.SelectAll();
                    MessageBox.Show("Please enter a positive integer.");
                }
                else
                {
                    //calculate total & discount
                    total = quantity * PRICE;
                    if (quantity >= 20)
                    {
                        total *= .9;
                    }
                    else if (quantity >= 10)
                    {
                        total *= .95;
                    }
                    lblTotal.Text = total.ToString("C");
                    txtSold.Focus();
                    txtSold.SelectAll();
                }
            }
            else
            {
                //error handling for non integers
                MessageBox.Show("Please enter an integer.");
                txtSold.Focus();
                txtSold.SelectAll();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clears both the text box and the total
            txtSold.Text = "";
            lblTotal.Text = "";
            txtSold.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes the application
            Application.Exit();
        }

        private void txtSold_TextChanged(object sender, EventArgs e)
        {
            //Clears the total if you start typing
            lblTotal.Text = "";
        }
    }
}
