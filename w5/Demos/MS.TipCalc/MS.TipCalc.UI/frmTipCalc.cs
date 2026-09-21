namespace MS.TipCalc.UI
{
    public partial class frmTipCalc : Form
    {
        public frmTipCalc()
        {
            InitializeComponent();
            AcceptButton = btnCalc;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            { 
                //declare variables
                double dblBill = double.Parse(txtBill.Text);
                double dblPercent = double.Parse(txtTip.Text);

                //calculate & output tip amount
                double dblTip = (dblBill * dblPercent) / 100;
                lblAmount.Text = "$" + dblTip.ToString("n2");

                //calculate & output total
                double dblTotal = dblTip + dblBill;
                lblOutput.Text = dblTotal.ToString("n2");
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a number");
            }
        }
    }
}
