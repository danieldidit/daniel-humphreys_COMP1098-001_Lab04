namespace daniel_humphreys_Ex_01
{
    partial class GlobalPizzaShop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.customerInfo = new System.Windows.Forms.GroupBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.orderNumberTextBox = new System.Windows.Forms.TextBox();
            this.updateInfoButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pizzaSelection = new System.Windows.Forms.GroupBox();
            this.pizzaEstimateBox = new System.Windows.Forms.RichTextBox();
            this.addOrderButton = new System.Windows.Forms.Button();
            this.checkBoxCheese = new System.Windows.Forms.CheckBox();
            this.checkBoxOnions = new System.Windows.Forms.CheckBox();
            this.checkBoxOlives = new System.Windows.Forms.CheckBox();
            this.checkBoxPeppers = new System.Windows.Forms.CheckBox();
            this.checkBoxPineapple = new System.Windows.Forms.CheckBox();
            this.checkBoxMushrooms = new System.Windows.Forms.CheckBox();
            this.clearOrderButton = new System.Windows.Forms.Button();
            this.checkBoxSausage = new System.Windows.Forms.CheckBox();
            this.checkBoxHam = new System.Windows.Forms.CheckBox();
            this.checkBoxPepperoni = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxPizzaType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.clearInfoButton = new System.Windows.Forms.Button();
            this.grandTotal = new System.Windows.Forms.TextBox();
            this.clearOrdersButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.customerInfoTextBox = new System.Windows.Forms.RichTextBox();
            this.orderTextBox = new System.Windows.Forms.RichTextBox();
            this.grandTotalDisplay = new System.Windows.Forms.TextBox();
            this.customerInfo.SuspendLayout();
            this.pizzaSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerInfo
            // 
            this.customerInfo.Controls.Add(this.addressTextBox);
            this.customerInfo.Controls.Add(this.phoneNumberTextBox);
            this.customerInfo.Controls.Add(this.customerNameTextBox);
            this.customerInfo.Controls.Add(this.orderNumberTextBox);
            this.customerInfo.Controls.Add(this.updateInfoButton);
            this.customerInfo.Controls.Add(this.label4);
            this.customerInfo.Controls.Add(this.label3);
            this.customerInfo.Controls.Add(this.label2);
            this.customerInfo.Controls.Add(this.label1);
            this.customerInfo.Location = new System.Drawing.Point(12, 24);
            this.customerInfo.Name = "customerInfo";
            this.customerInfo.Size = new System.Drawing.Size(250, 230);
            this.customerInfo.TabIndex = 0;
            this.customerInfo.TabStop = false;
            this.customerInfo.Text = "Customer Information";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(106, 143);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(124, 20);
            this.addressTextBox.TabIndex = 8;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(106, 99);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(124, 20);
            this.phoneNumberTextBox.TabIndex = 7;
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(106, 59);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(124, 20);
            this.customerNameTextBox.TabIndex = 6;
            // 
            // orderNumberTextBox
            // 
            this.orderNumberTextBox.Location = new System.Drawing.Point(106, 20);
            this.orderNumberTextBox.Name = "orderNumberTextBox";
            this.orderNumberTextBox.Size = new System.Drawing.Size(124, 20);
            this.orderNumberTextBox.TabIndex = 5;
            // 
            // updateInfoButton
            // 
            this.updateInfoButton.Location = new System.Drawing.Point(56, 192);
            this.updateInfoButton.Name = "updateInfoButton";
            this.updateInfoButton.Size = new System.Drawing.Size(132, 23);
            this.updateInfoButton.TabIndex = 4;
            this.updateInfoButton.Text = "Update Information";
            this.updateInfoButton.UseVisualStyleBackColor = true;
            this.updateInfoButton.Click += new System.EventHandler(this.updateInfoButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Delivery Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Number:";
            // 
            // pizzaSelection
            // 
            this.pizzaSelection.Controls.Add(this.pizzaEstimateBox);
            this.pizzaSelection.Controls.Add(this.addOrderButton);
            this.pizzaSelection.Controls.Add(this.checkBoxCheese);
            this.pizzaSelection.Controls.Add(this.checkBoxOnions);
            this.pizzaSelection.Controls.Add(this.checkBoxOlives);
            this.pizzaSelection.Controls.Add(this.checkBoxPeppers);
            this.pizzaSelection.Controls.Add(this.checkBoxPineapple);
            this.pizzaSelection.Controls.Add(this.checkBoxMushrooms);
            this.pizzaSelection.Controls.Add(this.clearOrderButton);
            this.pizzaSelection.Controls.Add(this.checkBoxSausage);
            this.pizzaSelection.Controls.Add(this.checkBoxHam);
            this.pizzaSelection.Controls.Add(this.checkBoxPepperoni);
            this.pizzaSelection.Controls.Add(this.label7);
            this.pizzaSelection.Controls.Add(this.comboBoxPizzaType);
            this.pizzaSelection.Controls.Add(this.label6);
            this.pizzaSelection.Controls.Add(this.label5);
            this.pizzaSelection.Controls.Add(this.comboBoxSize);
            this.pizzaSelection.Location = new System.Drawing.Point(268, 24);
            this.pizzaSelection.Name = "pizzaSelection";
            this.pizzaSelection.Size = new System.Drawing.Size(414, 230);
            this.pizzaSelection.TabIndex = 1;
            this.pizzaSelection.TabStop = false;
            this.pizzaSelection.Text = "Pizza Selection";
            // 
            // pizzaEstimateBox
            // 
            this.pizzaEstimateBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pizzaEstimateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzaEstimateBox.Location = new System.Drawing.Point(254, 19);
            this.pizzaEstimateBox.Name = "pizzaEstimateBox";
            this.pizzaEstimateBox.ReadOnly = true;
            this.pizzaEstimateBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pizzaEstimateBox.Size = new System.Drawing.Size(137, 61);
            this.pizzaEstimateBox.TabIndex = 16;
            this.pizzaEstimateBox.Text = "";
            // 
            // addOrderButton
            // 
            this.addOrderButton.Location = new System.Drawing.Point(231, 192);
            this.addOrderButton.Name = "addOrderButton";
            this.addOrderButton.Size = new System.Drawing.Size(100, 23);
            this.addOrderButton.TabIndex = 15;
            this.addOrderButton.Text = "Add Order";
            this.addOrderButton.UseVisualStyleBackColor = true;
            this.addOrderButton.Click += new System.EventHandler(this.addOrderButton_Click);
            // 
            // checkBoxCheese
            // 
            this.checkBoxCheese.AutoSize = true;
            this.checkBoxCheese.Location = new System.Drawing.Point(278, 169);
            this.checkBoxCheese.Name = "checkBoxCheese";
            this.checkBoxCheese.Size = new System.Drawing.Size(62, 17);
            this.checkBoxCheese.TabIndex = 14;
            this.checkBoxCheese.Text = "Cheese";
            this.checkBoxCheese.UseVisualStyleBackColor = true;
            this.checkBoxCheese.CheckedChanged += new System.EventHandler(this.checkBoxCheese_CheckedChanged);
            // 
            // checkBoxOnions
            // 
            this.checkBoxOnions.AutoSize = true;
            this.checkBoxOnions.Location = new System.Drawing.Point(278, 145);
            this.checkBoxOnions.Name = "checkBoxOnions";
            this.checkBoxOnions.Size = new System.Drawing.Size(59, 17);
            this.checkBoxOnions.TabIndex = 13;
            this.checkBoxOnions.Text = "Onions";
            this.checkBoxOnions.UseVisualStyleBackColor = true;
            this.checkBoxOnions.CheckedChanged += new System.EventHandler(this.checkBoxOnions_CheckedChanged);
            // 
            // checkBoxOlives
            // 
            this.checkBoxOlives.AutoSize = true;
            this.checkBoxOlives.Location = new System.Drawing.Point(278, 116);
            this.checkBoxOlives.Name = "checkBoxOlives";
            this.checkBoxOlives.Size = new System.Drawing.Size(55, 17);
            this.checkBoxOlives.TabIndex = 12;
            this.checkBoxOlives.Text = "Olives";
            this.checkBoxOlives.UseVisualStyleBackColor = true;
            this.checkBoxOlives.CheckedChanged += new System.EventHandler(this.checkBoxOlives_CheckedChanged);
            // 
            // checkBoxPeppers
            // 
            this.checkBoxPeppers.AutoSize = true;
            this.checkBoxPeppers.Location = new System.Drawing.Point(141, 169);
            this.checkBoxPeppers.Name = "checkBoxPeppers";
            this.checkBoxPeppers.Size = new System.Drawing.Size(65, 17);
            this.checkBoxPeppers.TabIndex = 11;
            this.checkBoxPeppers.Text = "Peppers";
            this.checkBoxPeppers.UseVisualStyleBackColor = true;
            this.checkBoxPeppers.CheckedChanged += new System.EventHandler(this.checkBoxPeppers_CheckedChanged);
            // 
            // checkBoxPineapple
            // 
            this.checkBoxPineapple.AutoSize = true;
            this.checkBoxPineapple.Location = new System.Drawing.Point(141, 143);
            this.checkBoxPineapple.Name = "checkBoxPineapple";
            this.checkBoxPineapple.Size = new System.Drawing.Size(73, 17);
            this.checkBoxPineapple.TabIndex = 10;
            this.checkBoxPineapple.Text = "Pineapple";
            this.checkBoxPineapple.UseVisualStyleBackColor = true;
            this.checkBoxPineapple.CheckedChanged += new System.EventHandler(this.checkBoxPineapple_CheckedChanged);
            // 
            // checkBoxMushrooms
            // 
            this.checkBoxMushrooms.AutoSize = true;
            this.checkBoxMushrooms.Location = new System.Drawing.Point(141, 116);
            this.checkBoxMushrooms.Name = "checkBoxMushrooms";
            this.checkBoxMushrooms.Size = new System.Drawing.Size(80, 17);
            this.checkBoxMushrooms.TabIndex = 9;
            this.checkBoxMushrooms.Text = "Mushrooms";
            this.checkBoxMushrooms.UseVisualStyleBackColor = true;
            this.checkBoxMushrooms.CheckedChanged += new System.EventHandler(this.checkBoxMushrooms_CheckedChanged);
            // 
            // clearOrderButton
            // 
            this.clearOrderButton.Location = new System.Drawing.Point(44, 192);
            this.clearOrderButton.Name = "clearOrderButton";
            this.clearOrderButton.Size = new System.Drawing.Size(100, 23);
            this.clearOrderButton.TabIndex = 8;
            this.clearOrderButton.Text = "Clear Order";
            this.clearOrderButton.UseVisualStyleBackColor = true;
            this.clearOrderButton.Click += new System.EventHandler(this.clearOrderButton_Click);
            // 
            // checkBoxSausage
            // 
            this.checkBoxSausage.AutoSize = true;
            this.checkBoxSausage.Location = new System.Drawing.Point(10, 169);
            this.checkBoxSausage.Name = "checkBoxSausage";
            this.checkBoxSausage.Size = new System.Drawing.Size(68, 17);
            this.checkBoxSausage.TabIndex = 7;
            this.checkBoxSausage.Text = "Sausage";
            this.checkBoxSausage.UseVisualStyleBackColor = true;
            this.checkBoxSausage.CheckedChanged += new System.EventHandler(this.checkBoxSausage_CheckedChanged);
            // 
            // checkBoxHam
            // 
            this.checkBoxHam.AutoSize = true;
            this.checkBoxHam.Location = new System.Drawing.Point(10, 142);
            this.checkBoxHam.Name = "checkBoxHam";
            this.checkBoxHam.Size = new System.Drawing.Size(48, 17);
            this.checkBoxHam.TabIndex = 6;
            this.checkBoxHam.Text = "Ham";
            this.checkBoxHam.UseVisualStyleBackColor = true;
            this.checkBoxHam.CheckedChanged += new System.EventHandler(this.checkBoxHam_CheckedChanged);
            // 
            // checkBoxPepperoni
            // 
            this.checkBoxPepperoni.AutoSize = true;
            this.checkBoxPepperoni.Location = new System.Drawing.Point(10, 116);
            this.checkBoxPepperoni.Name = "checkBoxPepperoni";
            this.checkBoxPepperoni.Size = new System.Drawing.Size(74, 17);
            this.checkBoxPepperoni.TabIndex = 5;
            this.checkBoxPepperoni.Text = "Pepperoni";
            this.checkBoxPepperoni.UseVisualStyleBackColor = true;
            this.checkBoxPepperoni.CheckedChanged += new System.EventHandler(this.checkBoxPepperoni_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Extra Toppings:";
            // 
            // comboBoxPizzaType
            // 
            this.comboBoxPizzaType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxPizzaType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxPizzaType.FormattingEnabled = true;
            this.comboBoxPizzaType.Items.AddRange(new object[] {
            "Select One",
            "Normal",
            "Whole Wheat"});
            this.comboBoxPizzaType.Location = new System.Drawing.Point(76, 59);
            this.comboBoxPizzaType.Name = "comboBoxPizzaType";
            this.comboBoxPizzaType.Size = new System.Drawing.Size(154, 21);
            this.comboBoxPizzaType.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Pizza Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Pizza Size:";
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxSize.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Items.AddRange(new object[] {
            "Select One",
            "Small",
            "Medium",
            "Large"});
            this.comboBoxSize.Location = new System.Drawing.Point(76, 20);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(154, 21);
            this.comboBoxSize.TabIndex = 0;
            this.comboBoxSize.SelectedIndexChanged += new System.EventHandler(this.comboBoxSize_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Orders Summary:";
            // 
            // clearInfoButton
            // 
            this.clearInfoButton.Location = new System.Drawing.Point(68, 427);
            this.clearInfoButton.Name = "clearInfoButton";
            this.clearInfoButton.Size = new System.Drawing.Size(132, 23);
            this.clearInfoButton.TabIndex = 17;
            this.clearInfoButton.Text = "Clear Information";
            this.clearInfoButton.UseVisualStyleBackColor = true;
            this.clearInfoButton.Click += new System.EventHandler(this.clearInfoButton_Click);
            // 
            // grandTotal
            // 
            this.grandTotal.Location = new System.Drawing.Point(268, 398);
            this.grandTotal.Name = "grandTotal";
            this.grandTotal.ReadOnly = true;
            this.grandTotal.Size = new System.Drawing.Size(70, 20);
            this.grandTotal.TabIndex = 19;
            this.grandTotal.Text = "Grand Total:";
            // 
            // clearOrdersButton
            // 
            this.clearOrdersButton.Location = new System.Drawing.Point(312, 427);
            this.clearOrdersButton.Name = "clearOrdersButton";
            this.clearOrdersButton.Size = new System.Drawing.Size(100, 23);
            this.clearOrdersButton.TabIndex = 20;
            this.clearOrdersButton.Text = "Clear All Orders";
            this.clearOrdersButton.UseVisualStyleBackColor = true;
            this.clearOrdersButton.Click += new System.EventHandler(this.clearOrdersButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(499, 427);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 23);
            this.exitButton.TabIndex = 17;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // customerInfoTextBox
            // 
            this.customerInfoTextBox.Location = new System.Drawing.Point(12, 289);
            this.customerInfoTextBox.Name = "customerInfoTextBox";
            this.customerInfoTextBox.ReadOnly = true;
            this.customerInfoTextBox.Size = new System.Drawing.Size(250, 129);
            this.customerInfoTextBox.TabIndex = 21;
            this.customerInfoTextBox.Text = "";
            // 
            // orderTextBox
            // 
            this.orderTextBox.Location = new System.Drawing.Point(268, 289);
            this.orderTextBox.Name = "orderTextBox";
            this.orderTextBox.ReadOnly = true;
            this.orderTextBox.Size = new System.Drawing.Size(414, 103);
            this.orderTextBox.TabIndex = 22;
            this.orderTextBox.Text = "";
            // 
            // grandTotalDisplay
            // 
            this.grandTotalDisplay.Location = new System.Drawing.Point(335, 398);
            this.grandTotalDisplay.Name = "grandTotalDisplay";
            this.grandTotalDisplay.ReadOnly = true;
            this.grandTotalDisplay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grandTotalDisplay.Size = new System.Drawing.Size(347, 20);
            this.grandTotalDisplay.TabIndex = 23;
            this.grandTotalDisplay.Text = "$0.00";
            // 
            // GlobalPizzaShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 462);
            this.Controls.Add(this.grandTotalDisplay);
            this.Controls.Add(this.orderTextBox);
            this.Controls.Add(this.customerInfoTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearOrdersButton);
            this.Controls.Add(this.grandTotal);
            this.Controls.Add(this.clearInfoButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pizzaSelection);
            this.Controls.Add(this.customerInfo);
            this.Name = "GlobalPizzaShop";
            this.Text = "Global Pizza Shop";
            this.customerInfo.ResumeLayout(false);
            this.customerInfo.PerformLayout();
            this.pizzaSelection.ResumeLayout(false);
            this.pizzaSelection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox customerInfo;
        private System.Windows.Forms.GroupBox pizzaSelection;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.TextBox orderNumberTextBox;
        private System.Windows.Forms.Button updateInfoButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxSausage;
        private System.Windows.Forms.CheckBox checkBoxHam;
        private System.Windows.Forms.CheckBox checkBoxPepperoni;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxPizzaType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxSize;
        private System.Windows.Forms.Button addOrderButton;
        private System.Windows.Forms.CheckBox checkBoxCheese;
        private System.Windows.Forms.CheckBox checkBoxOnions;
        private System.Windows.Forms.CheckBox checkBoxOlives;
        private System.Windows.Forms.CheckBox checkBoxPeppers;
        private System.Windows.Forms.CheckBox checkBoxPineapple;
        private System.Windows.Forms.CheckBox checkBoxMushrooms;
        private System.Windows.Forms.Button clearOrderButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button clearInfoButton;
        private System.Windows.Forms.TextBox grandTotal;
        private System.Windows.Forms.Button clearOrdersButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.RichTextBox customerInfoTextBox;
        private System.Windows.Forms.RichTextBox orderTextBox;
        private System.Windows.Forms.RichTextBox pizzaEstimateBox;
        private System.Windows.Forms.TextBox grandTotalDisplay;
    }
}

