using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SimpleFormsAppWithComboBox
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkedListBoxFood.Items.Clear(); // Clear previous items

            string selectedCuisine = comboBoxCuisine.SelectedItem.ToString();

            if (selectedCuisine == "Filipino")
            {
                checkedListBoxFood.Items.Add("Bulalo");
                checkedListBoxFood.Items.Add("Kare-Kare");
                checkedListBoxFood.Items.Add("Bicol Express");
                checkedListBoxFood.Items.Add("Pinakbet");
            }
            else if (selectedCuisine == "Japanese")
            {
                checkedListBoxFood.Items.Add("Sushi");
                checkedListBoxFood.Items.Add("Ramen");
                checkedListBoxFood.Items.Add("Tempura");
            }
            else if (selectedCuisine == "Chinese")
            {
                checkedListBoxFood.Items.Add("Dim Sum");
                checkedListBoxFood.Items.Add("Peking Duck");
                checkedListBoxFood.Items.Add("Sweet and Sour Pork");
            }
            else if (selectedCuisine == "Korean")
            {
                checkedListBoxFood.Items.Add("Kimchi");
                checkedListBoxFood.Items.Add("Bibimbap");
                checkedListBoxFood.Items.Add("Tteokbokki");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBoxFood.CheckedItems)
            {
                listBoxFavorites.Items.Add(item); // Add checked items to favorites
            }

            // Optional: Uncheck all items after adding
            for (int i = 0; i < checkedListBoxFood.Items.Count; i++)
            {
                checkedListBoxFood.SetItemChecked(i, false);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBoxFavorites.SelectedItem != null)
            {
                listBoxFavorites.Items.Remove(listBoxFavorites.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please select a food item to remove!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBoxFavorites.Items.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Make sure the ComboBox is cleared before adding items
            comboBoxCuisine.Items.Clear();

            // Add cuisine options
            comboBoxCuisine.Items.Add("Italian");
            comboBoxCuisine.Items.Add("Mexican");
            comboBoxCuisine.Items.Add("Chinese");
            comboBoxCuisine.Items.Add("Indian");
            comboBoxCuisine.Items.Add("American");

            // Set default selected item (optional)
            comboBoxCuisine.SelectedIndex = 0;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
