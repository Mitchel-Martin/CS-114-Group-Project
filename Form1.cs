namespace CS_114_Group_Project
{
    public partial class frmHealthWellness : Form
    {
        public frmHealthWellness()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCardNumber.Text = "";
            txtCCV.Text = "";
            txtSSN.Text = "";
            txtFullName.Text = "";
            txtAddress.Text = "";
            txtAddInfo.Text = "";
        }

        private void btnGetStarted_Click(object sender, EventArgs e)
        {
            //Here is the button to open the next form
        }
    }
}
