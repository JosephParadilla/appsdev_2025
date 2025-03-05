namespace SimpleFormsAppWithMessageBoxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string fNameValue = firstname.Text;
            string lNameValue = lastname.Text;
            string middlenameValue = middlename.Text;
            string suffixValue = suffix.Text;

            DialogResult result = MessageBox.Show(
            "Are you sure you want to submit?",
             "Confirm Submission",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
             );

            if (result == DialogResult.Yes)
            {
                MessageBox.Show($"Hello World! {fNameValue} {middlenameValue} {lNameValue} {suffixValue}",
                    "Greetings", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Submission canceled.", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
