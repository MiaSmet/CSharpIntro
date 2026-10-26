namespace MS.Clinic.UI
{
    public partial class frmClinic : Form
    {
        //declare global variables
        double total = 0;
        bool check1 = false;
        bool check2 = false;
        bool check3 = false;
        bool check4 = false;
        bool check5 = false;
        bool check6 = false;
        bool check7 = false;
        bool check8 = false;

        public frmClinic()
        {
            InitializeComponent();
            AcceptButton = btnClear;
            CancelButton = btnExit;
        }

        private void chkEmergency_CheckedChanged(object sender, EventArgs e)
        {
            //checks if the box is currently checked
            if (check1)
            {
                //removes price and subtracts from the total
                check1 = false;
                lblP1.Text = "";
                total -= 500;
            }
            else
            {
                //displays price and adds to the total
                check1 = true;
                lblP1.Text = "500.00";
                total += 500;
            }
            lblTotal.Text = total.ToString("n2");
        }

        private void chkExam_CheckedChanged(object sender, EventArgs e)
        {
            //checks if the box is currently checked
            if (check2)
            {
                //removes price and subtracts from the total
                check2 = false;
                lblP2.Text = "";
                total -= 50;
            }
            else
            {
                //displays price and adds to the total
                check2 = true;
                lblP2.Text = "50.00";
                total += 50;
            }
            lblTotal.Text = total.ToString("n2");
        }

        private void chkGrooming_CheckedChanged(object sender, EventArgs e)
        {
            //checks if the box is currently checked
            if (check3)
            {
                //removes price and subtracts from the total
                check3 = false;
                lblP3.Text = "";
                total -= 25;
            }
            else
            {
                //displays price and adds to the total
                check3 = true;
                lblP3.Text = "25.00";
                total += 25;
            }
            lblTotal.Text = total.ToString("n2");
        }

        private void chkSpay_CheckedChanged(object sender, EventArgs e)
        {
            //checks if the box is currently checked
            if (check4)
            {
                //removes price and subtracts from the total
                check4 = false;
                lblP4.Text = "";
                total -= 100;
            }
            else
            {
                //displays price and adds to the total
                check4 = true;
                lblP4.Text = "100.00";
                total += 100;
            }
            lblTotal.Text = total.ToString("n2");
        }

        private void chkVacc_CheckedChanged(object sender, EventArgs e)
        {
            //checks if the box is currently checked
            if (check5)
            {
                //removes price and subtracts from the total
                check5 = false;
                lblP5.Text = "";
                total -= 10;
            }
            else
            {
                //displays price and adds to the total
                check5 = true;
                lblP5.Text = "10.00";
                total += 10;
            }
            lblTotal.Text = total.ToString("n2");
        }

        private void chkHour_CheckedChanged(object sender, EventArgs e)
        {
            //checks if the box is currently checked
            if (check6)
            {
                //removes price and subtracts from the total
                check6 = false;
                lblP6.Text = "";
                total -= 15;
            }
            else
            {
                //displays price and adds to the total
                check6 = true;
                lblP6.Text = "15.00";
                total += 15;
            }
            lblTotal.Text = "$"+total.ToString("n2");
        }

        private void chkDay_CheckedChanged(object sender, EventArgs e)
        {
            //checks if the box is currently checked
            if (check7)
            {
                //removes price and subtracts from the total
                check7 = false;
                lblP7.Text = "";
                total -= 30;
            }
            else
            {
                //displays price and adds to the total
                check7 = true;
                lblP7.Text = "30.00";
                total += 30;
            }
            lblTotal.Text = total.ToString("n2");
        }

        private void chkWeek_CheckedChanged(object sender, EventArgs e)
        {
            //checks if the box is currently checked
            if (check8)
            {
                //removes price and subtracts from the total
                check8 = false;
                lblP8.Text = "";
                total -= 350;
            }
            else
            {
                //displays price and adds to the total
                check8 = true;
                lblP8.Text = "350.00";
                total += 350;
            }
            lblTotal.Text = total.ToString("n2");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Unchecks all boxes if they're checked, which also clears all prices
            if(check1)
            {
                chkEmergency.Checked = false;
            }
            if (check2)
            {
                chkExam.Checked = false;
            }
            if (check3)
            {
                chkGrooming.Checked = false;
            }
            if (check4)
            {
                chkSpay.Checked = false;
            }
            if (check5)
            {
                chkVacc.Checked = false;
            }
            if (check6)
            {
                chkHour.Checked = false;
            }
            if (check7)
            {
                chkDay.Checked = false;
            }
            if (check8)
            {
                chkWeek.Checked = false;
            }
            lblTotal.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exits the application
            Application.Exit();
        }
    }
}
