namespace MS.TheaterAdmission.UI
{
    public partial class Admission : Form
    {
        public Admission()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int age;
            bool hasParent = chkParent.Checked;
            bool hasTicket = chkTicket.Checked;
            bool isBanned = chkBanned.Checked;

            if(int.TryParse(txtAge.Text, out age))
            {
                if((age >= 17 || hasParent) && hasTicket && !isBanned)
                {
                    lblResult.Text = "Result: Admission Approved";
                }
                else
                {
                    lblResult.Text = "Result: Admission Denied";
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid age");
            }
        }
    }
}
