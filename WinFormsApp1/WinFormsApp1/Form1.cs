namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string middleName = txtMiddleName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string suffix = txtSuffix.Text.Trim();

            // Build the full name
            string fullName = $"{firstName} {middleName} {lastName}";
            if (!string.IsNullOrEmpty(suffix))
            {
                fullName += $" {suffix}";
            }

            MessageBox.Show($"Hello There! {fullName}!", "Greetings!");
        }
    }
}
