namespace MS.DemoSize.UI
{
    public partial class frmDemo : Form
    {
        public frmDemo()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            double dblInput;
            double dblOutput;

            if (double.TryParse(txtNumber.Text, out dblInput))
            {
                lblResults.Text = dblInput.ToString();
            }
            else
            {
                MessageBox.Show("Please enter a number");
            }

            /*
            try
            {
                double dblNumber = double.Parse(txtNumber.Text);
                dblNumber *= 5;
                lblResults.Text = dblNumber.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Please enter a number");
            }
            */
            
        }
    }
}
