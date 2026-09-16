namespace MS.MilesToKilos.UI
{
    public partial class frmMiles : Form
    {
        //declare variables
        double dblMiles = 0.0;
        double dblKilos;
        const double MILES_TO_KM = 1.61;


        public frmMiles()
        {
            InitializeComponent();
            //set button commands on enter and escape
            AcceptButton = btnConvert;
            CancelButton = btnClear;
            //stops the labels from being tabbed
            lblMiles.TabStop = false;
            lblKilos.TabStop = false;

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            //Convert to kilometers if a number is entered
            try
            {
                //set variables
                dblMiles = double.Parse(txtMiles.Text);
                dblKilos = dblMiles * MILES_TO_KM;
                //output kilometer calculation
                lblOutput.Text = dblKilos.ToString("n3");
            }
            catch (Exception)
            {
                //error message if entered text is not a number
                MessageBox.Show("Please enter a number");
            }
            //focuses and selects the miles for quick reruns
            txtMiles.Focus();
            txtMiles.SelectAll();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clears both input and output
            txtMiles.Text = "";
            lblOutput.Text = "";
            txtMiles.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exits the application
            Application.Exit();
        }

        private void txtMiles_TextChanged(object sender, EventArgs e)
        {
            //clears the output field when the input is changed
            lblOutput.Text = "";
        }
    }
}
