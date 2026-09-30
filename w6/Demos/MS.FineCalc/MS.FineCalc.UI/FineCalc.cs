namespace MS.FineCalc.UI
{
    public partial class FineCalc : Form
    {
        //declare constant fine variable
        const double FINE = 0.05;
        public FineCalc()
        {
            InitializeComponent();
            //set accept and cancel buttons
            AcceptButton = btnCalc;
            CancelButton = btnExit;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //declare variables
            int books = 0;
            int days = 0;
            double fine;
            string exc = null;
            //parses the text boxes if they are integers
            /*
            if (!int.TryParse(txtNum.Text, out books))
            {
                MessageBox.Show("Please input a whole number.");
            }
            if(!int.TryParse(txtDays.Text, out books))
            {
                MessageBox.Show("Please input a whole number.");
            }
            */
            try
            {
                books = int.Parse(txtNum.Text);
                days = int.Parse(txtDays.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please input a whole number.");
                exc = ex.ToString();
            }
            //calculates and shows fine total only if parsing worked
            if (exc == null)
            {
                fine = books * days * FINE;
                lblFine.Text = "Total Fine: " + fine.ToString("C");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clears text boxes and calculated label
            txtNum.Text = "";
            txtDays.Text = "";
            lblFine.Text = "";
            txtNum.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exits the application
            Application.Exit();
        }
    }
}
