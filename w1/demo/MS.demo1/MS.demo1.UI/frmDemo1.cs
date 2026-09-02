namespace MS.demo1.UI
{
    public partial class frmDemo1 : Form
    {
        public frmDemo1()
        {
            InitializeComponent();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            //This generates text into the label
            lblName.Text = "Mia";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //This clears the text in the label
            lblName.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
