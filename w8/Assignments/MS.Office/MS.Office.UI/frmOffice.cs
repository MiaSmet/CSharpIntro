namespace MS.Office.UI
{
    public partial class frmOffice : Form
    {
        public frmOffice()
        {
            InitializeComponent();
            AcceptButton = btnEnter;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string department = txtDept.Text;
            string manager = "";
            if(department.ToLower() == "sales")
            {
                manager = "Angela";
            }
            else if(department.ToLower() == "it" || department.ToLower() == "information technology")
            {
                manager = "Kevin";
            }
            else if(department.ToLower() == "marketing")
            {
                manager = "Oscar";
            }
            else if(department.ToLower() == "hr" || department.ToLower() == "human resources")
            {
                manager = "Pam";
            }
            else if(department.ToLower() == "shipping")
            {
                manager = "Darryl";
            }
            else
            {
                manager = "Unkown";
            }
            lblManager.Text = "The manager of " + department + " is " + manager + ".";
        }
    }
}
