using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace daniel_humphreys_Ex_02
{
    public partial class GradeBookForm : Form
    {
        // Initializes Form
        public GradeBookForm()
        {
            InitializeComponent();
        }

        /**
         * This method adds a number to the listBox. Validates to ensure letters aren't entered
         */
        private void inputButton_Click(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(textBox.Text.Trim(), out value))
            {
                listBox.Items.Add(textBox.Text.Trim());
                textBox.Text = "";
            }

            else
                MessageBox.Show("This is a number only field");
        }

        /**
         * This method removes all the numbers from the listBox
         */
        private void clearButton_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }

        /**
         * This method removes only selected numbers from the listBox
         */
        private void removeButton_Click(object sender, EventArgs e)
        {
            listBox.Items.Remove(listBox.SelectedItem);
        }

        /**
         * This method Adds all the numbers in the list together giving us the sum
         */
        private void sumButton_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (var item in listBox.Items)
                sum += Convert.ToInt32(item);

            textBox.Text = sum.ToString();
        }

        /**
         * This method finds the sum and then calculates the average of all the numbers in the listBox
         */
        private void averageButton_Click(object sender, EventArgs e)
        {
            int sum = 0;
            int average = 0;
            foreach (var item in listBox.Items)
                sum += Convert.ToInt32(item);

            if (sum > 0)
                average = sum / listBox.Items.Count;

            textBox.Text = average.ToString();
        }
    }
}
