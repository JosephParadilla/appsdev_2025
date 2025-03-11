using System.Windows.Forms;

namespace SimpleFormsAppWithListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textbox.Text) && !lstbox.Items.Contains(textbox.Text))
            {

                listbox.Items.Add(textbox.Text);
            }
        }

        private void removebtn_Click(object sender, EventArgs e)
        {

        }

        private void removebtn_Click_1(object sender, EventArgs e)
        {
            listbox.Items.Remove(listbox.Text);
        }

        private void clrbtn_Click(object sender, EventArgs e)
        {
            lstbox.Items.Clear();
        }
    }
}
