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

namespace daniel_humphreys_Ex_01
{
    public partial class GlobalPizzaShop : Form     
    {
        // Initialize the windows form
        public GlobalPizzaShop()
        {
            InitializeComponent();

            // Sets default index for comboboxes
            comboBoxPizzaType.SelectedIndex = 0;
            comboBoxShops.SelectedIndex = 0;
        }

        // Declare properties
        public decimal PizzaEstimate { get; private set; }

        public decimal SizeCost { get; private set; }

        public decimal PizzaGrandTotal { get; private set; }

        private ArrayList orders = new ArrayList();

        /*
         * Displays all of the customer info in the customerInfoTextBox
         */
        private void updateInfoButton_Click(object sender, EventArgs e)
        {
            int orderNumber = 0;
            string customerName = "";
            string phoneNumber = "";

            // Ensures sure order number is between 0 and 99999999
            if (Int32.Parse(orderNumberTextBox.Text) >= 0 && Int32.Parse(orderNumberTextBox.Text) <= 99999999)
                orderNumber = Int32.Parse(orderNumberTextBox.Text);
            else
                throw new Exception("Order Number must be between 0 and 99999999");

            // Ensures there are no numbers in customers name
            if (customerNameTextBox.Text.Any(char.IsDigit))
                throw new Exception("Customer name musn't contain numbers");
            else
                customerName = customerNameTextBox.Text;

            // Ensures there are no letters in phone number
            if (phoneNumberTextBox.Text.Any(char.IsLetter))
                throw new Exception("Telephone number must not contain letters");
            else
                phoneNumber = phoneNumberTextBox.Text;

            customerInfoTextBox.Text = 
                $"Order Number: {orderNumber}\n\n" +
                $"Customer Name: {customerName}\n\n" +
                $"Phone Number: {phoneNumber}\n\n" +
                $"Delivery Address: {addressTextBox.Text}"; 
        }

        /*
         * Clears all of the customer info in the customerInfoTextBox
         */
        private void clearInfoButton_Click(object sender, EventArgs e)
        {
            customerInfoTextBox.Text = "";
        }

        /*
         * Determines the base price of the pizza based on the the size that is chosen
         */
        private void comboBoxPizzaType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPizzaType.SelectedIndex == 0)
            {
                PizzaEstimate = (PizzaEstimate - SizeCost);
                SizeCost = 0M;
            }

            if (comboBoxPizzaType.SelectedIndex == 1)
            {
                PizzaEstimate = (PizzaEstimate - SizeCost) + 8;
                SizeCost = 8M;
            }

            if (comboBoxPizzaType.SelectedIndex == 2)
            {
                PizzaEstimate = (PizzaEstimate - SizeCost) + 10;
                SizeCost = 10M;
            }
            
            if (comboBoxPizzaType.SelectedIndex == 3)
            {
                PizzaEstimate = (PizzaEstimate - SizeCost) + 12;
                SizeCost = 12M;
            }

            if (comboBoxPizzaType.SelectedIndex == 4)
            {
                PizzaEstimate = (PizzaEstimate - SizeCost) + 14;
                SizeCost = 14M;
            }

            if (comboBoxPizzaType.SelectedIndex == 5)
            {
                PizzaEstimate = (PizzaEstimate - SizeCost) + 16;
                SizeCost = 16M;
            }

            pizzaEstimateBox.Text = $"{PizzaEstimate:C}";
        }

        /*
         * The following methods check if each checkbox is checked or not 
         *  and adjusts the pizza price accordingly
         */
        private void checkBoxPepperoni_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPepperoni.Checked)
                PizzaEstimate += 1;

            if (!checkBoxPepperoni.Checked)
                PizzaEstimate -= 1;

            pizzaEstimateBox.Text = $"{PizzaEstimate:C}";
        }

        private void checkBoxHam_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHam.Checked)
                PizzaEstimate += 1;

            if (!checkBoxHam.Checked)
                PizzaEstimate -= 1;

            pizzaEstimateBox.Text = $"{PizzaEstimate:C}";
        }

        private void checkBoxSausage_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSausage.Checked)
                PizzaEstimate += 2;

            if (!checkBoxSausage.Checked)
                PizzaEstimate -= 2;

            pizzaEstimateBox.Text = $"{PizzaEstimate:C}";
        }

        private void checkBoxMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMushrooms.Checked)
                PizzaEstimate += 1;

            if (!checkBoxMushrooms.Checked)
                PizzaEstimate -= 1;

            pizzaEstimateBox.Text = $"{PizzaEstimate:C}";
        }

        private void checkBoxPineapple_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPineapple.Checked)
                PizzaEstimate += 1;

            if (!checkBoxPineapple.Checked)
                PizzaEstimate -= 1;

            pizzaEstimateBox.Text = $"{PizzaEstimate:C}";
        }

        private void checkBoxPeppers_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPeppers.Checked)
                PizzaEstimate += 1;

            if (!checkBoxPeppers.Checked)
                PizzaEstimate -= 1;

            pizzaEstimateBox.Text = $"{PizzaEstimate:C}";
        }

        private void checkBoxOlives_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOlives.Checked)
                PizzaEstimate += 1;

            if (!checkBoxOlives.Checked)
                PizzaEstimate -= 1;

            pizzaEstimateBox.Text = $"{PizzaEstimate:C}";
        }

        private void checkBoxOnions_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOnions.Checked)
                PizzaEstimate += 1;

            if (!checkBoxOnions.Checked)
                PizzaEstimate -= 1;

            pizzaEstimateBox.Text = $"{PizzaEstimate:C}";
        }

        private void checkBoxCheese_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCheese.Checked)
                PizzaEstimate += 1;

            if (!checkBoxCheese.Checked)
                PizzaEstimate -= 1;

            pizzaEstimateBox.Text = $"{PizzaEstimate:C}";
        }

        /*
         * Clears all of the checkboxes and sets the comboboxes back to default
         */
        private void clearOrderButton_Click(object sender, EventArgs e)
        {
            // Unchecks all checkboxes
            checkBoxPepperoni.Checked = false;
            checkBoxHam.Checked = false;
            checkBoxSausage.Checked = false;
            checkBoxMushrooms.Checked = false;
            checkBoxPineapple.Checked = false;
            checkBoxPeppers.Checked = false;
            checkBoxOlives.Checked = false;
            checkBoxOnions.Checked = false;
            checkBoxCheese.Checked = false;

            // sets comboboxes to default
            comboBoxPizzaType.SelectedIndex = 0;
            comboBoxShops.SelectedIndex = 0;
        }

        /*
         * Adds the current order to the orderTextBox
         */
        private void addOrderButton_Click(object sender, EventArgs e)
        { 
            // Declare local variables
            ArrayList toppings = new ArrayList();

            string selectedToppings = "";

            string order = "";

            // Check if each checkbox is checked. If it is, add topping to the toppings list
            if (checkBoxPepperoni.Checked)
                toppings.Add("Pepperoni");

            if (checkBoxHam.Checked)
                toppings.Add("Ham");

            if (checkBoxSausage.Checked)
                toppings.Add("Sausage");

            if (checkBoxMushrooms.Checked)
                toppings.Add("Mushrooms");

            if (checkBoxPineapple.Checked)
                toppings.Add("Pineapples");

            if (checkBoxPeppers.Checked)
                toppings.Add("Peppers");

            if (checkBoxOlives.Checked)
                toppings.Add("Olives");

            if (checkBoxOnions.Checked)
                toppings.Add("Onions");

            if (checkBoxCheese.Checked)
                toppings.Add("Cheese");

            // Loop through each topping in the list and add onto the selectedToppings string
            foreach (string pizza in toppings)
                selectedToppings += pizza + ", ";

            // Removes the whitespace and unnecessary comma form the end of the string
            selectedToppings = selectedToppings.Remove(selectedToppings.Length - 2);

            // If both comboboxes are selected, add the order to the orders list
            if (comboBoxShops.SelectedIndex != 0 && comboBoxPizzaType.SelectedIndex != 0)
                orders.Add($"1x {comboBoxShops.Text} {comboBoxPizzaType.Text} Size Pizza with {selectedToppings}. {PizzaEstimate:C}\n");

            // Loop through each order in the list and add onto the order string
            foreach (string selection in orders)
            {
                order += selection + "\n";
            }

            // Calculates the grand total cost every time a new pizza is added to the order
            PizzaGrandTotal = PizzaGrandTotal + PizzaEstimate;
            
            // Displays all the orders
            orderTextBox.Text = $"{order}";

            decimal tax = Decimal.Multiply(PizzaGrandTotal, 0.13M);

            // Displays the grand total cost
            grandTotalDisplay.Text = $"{PizzaGrandTotal + tax:C}";
        }

        /*
         * Clears and resets all of the order information
         */
        private void clearOrdersButton_Click(object sender, EventArgs e)
        {
            PizzaGrandTotal = 0;         

            orders.Clear();

            orderTextBox.Text = $"";

            grandTotalDisplay.Text = $"{PizzaGrandTotal:C}";
        }

        /*
         * Exits the application 
         */
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
