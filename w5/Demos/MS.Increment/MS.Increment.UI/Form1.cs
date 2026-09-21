namespace MS.Increment.UI
{
    public partial class Form1 : Form
    {
        private int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMethod1_Click(object sender, EventArgs e)
        {
            counter = counter + 1;
            lblIncrement.Text = counter.ToString();
        }

        private void btnMethod2_Click(object sender, EventArgs e)
        {
            counter += 1;
            lblIncrement.Text = counter.ToString();
        }

        private void btnMethod3_Click(object sender, EventArgs e)
        {
            counter++;
            lblIncrement.Text = counter.ToString();
        }
    }
}
