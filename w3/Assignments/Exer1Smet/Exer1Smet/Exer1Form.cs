namespace Exer1Smet
{
    public partial class Exer1Form : Form
    {
        public Exer1Form()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            //sets the second label to my name when clicked and changes the color to Bisque
            lblFVTCName.Text = "Mia Smet";
            this.BackColor = Color.Bisque;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //sets the second label back to fox valley technical college and changes the color back to Aqua
            lblFVTCName.Text = "Fox Valley Technical College";
            this.BackColor = Color.Aqua;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //exits the program when clicked
            Application.Exit();
        }
    }
}
