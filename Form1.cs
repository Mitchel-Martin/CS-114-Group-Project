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

        private void cboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboDay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmHealthWellness_Load(object sender, EventArgs e)
        {
            string[] months = { "Month...", "Jan", "Feb", "Mar", "Apr", "May", "June", "July", "Aug", "Sep", "Oct", "Nov", "Dec" };
            foreach (string month in months)
            {
                cboMonth.Items.Add(month);
            }
            cboMonth.SelectedIndex = 0;

            string[] years = { "Year...", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030" };
            foreach (string year in years)
            {
                cboYear.Items.Add(year);
            }
            cboYear.SelectedIndex = 0;

            string[] days = { "Day...", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" };
            foreach (string day in days)
            {
                cboDay.Items.Add(day);
            }
            cboDay.SelectedIndex = 0;
        }
    }
}
