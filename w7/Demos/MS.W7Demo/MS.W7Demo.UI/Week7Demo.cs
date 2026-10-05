namespace MS.W7Demo.UI
{
    public partial class Week7Demo : Form
    {
        public Week7Demo()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            //int age = 20;
            //bool hasTicket = true;

            //if(age >= 18 && hasTicket)
            //{
            //    MessageBox.Show("You are an adult");
            //}
            //string username = "admin";
            //string password = "password123!";

            //if(username == "admin" && password == "password123!")
            //{
            //    //login successful
            //}
            //else
            //{
            //    //Invalid login
            //}
            //bool isLoggedIn = false;
            //if (!isLoggedIn)
            //{
            //    MessageBox.Show("Please log in");
            //}
            int age = 17;
            bool hasPermission = true;
            bool isBanned = false;
            if(age >= 18 || hasPermission && !isBanned)
            {
                //allowed
            }
            else
            {
                //denied
            }
        }
    }
}
