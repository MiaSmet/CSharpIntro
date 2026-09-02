namespace MS.W2Demo.UI
{
    public partial class frmHello : Form
    {
        public frmHello()
        {
            InitializeComponent();
        }

        private void btnSpanish_Click(object sender, EventArgs e)
        {
            //Change label text to spanish
            lblHello.Text = "Hola";
        }

        private void btnGerman_Click(object sender, EventArgs e)
        {
            //Change label text to German
            lblHello.Text = "Guten Tag";
        }

        private void btnGaelic_Click(object sender, EventArgs e)
        {
            //Change label text to Gaelic
            lblHello.Text = "Dia Duit";
        }
    }
}
