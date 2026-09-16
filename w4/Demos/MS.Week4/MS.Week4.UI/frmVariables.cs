namespace MS.Week4.UI
{
    public partial class frmVariables : Form
    {
        int clickCount = 0;
        public frmVariables()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string strFirst = "10";
            string strSecond = "5";

            int age = 30;
            int age2 = 5;
            int total = age + age2;

            decimal price = 4.50m;

            MessageBox.Show(total.ToString());
            lblName.Text = total.ToString();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int intNum1; //declare a variable
            intNum1 = int.Parse(txtFirst.Text);

            int num2;
            num2 = int.Parse(txtSecond.Text);

            int total = intNum1 + num2;

            lblResult.Text = total.ToString();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            clickCount++; //Increments click count by 1
            lblClickCount.Text = "Clicks: " + clickCount;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clickCount = 0;
            lblClickCount.Text = "Clicks: " + clickCount;
        }

        private void btnCostCalc_Click(object sender, EventArgs e)
        {
            try
            {
                bool isOutOfStock;


                double quantity = double.Parse(txtQuantity.Text);
                double total = quantity * 5.5;

                if (total > 30)
                {
                    isOutOfStock = true;
                }
                else
                {
                    isOutOfStock = false;
                }

                lblTotalCost.Text = "Total: $" + total;

                if (isOutOfStock = true)
                {
                    MessageBox.Show("Sorry, Out of stock");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Please enter a whole number");
            }
        }
    }
}
