using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerDatabaseApplication
{
    public partial class CustomerControl : UserControl
    {
        int panelDisplay;
        public const int AddCustomer = 0;
        public const int ViewList = 1;
        public const int UpdateCustomer = 2;
        public const int DeleteCustomer = 3;

        Customer selectedCustomer;

        public CustomerControl(int custID, int display)
        {
            InitializeComponent();

            panelDisplay = display;

            

            if (panelDisplay == AddCustomer && custID == -1)
            {
                TheButton.Text = "Add Customer";

            }
            else if (panelDisplay == UpdateCustomer)
            {
                TheButton.Text = "Save";

                selectedCustomer = Customer.findCustomerByID(custID);

                CustomerIDTextBox.Text = selectedCustomer.ID.ToString();
                LastNameTextBox.Text = selectedCustomer.LastName;
                FirstNameTextBox.Text = selectedCustomer.FirstName;
                Street1TextBox.Text = selectedCustomer.Street1;
                Street2TextBox.Text = selectedCustomer.Street2;
                CityTextBox.Text = selectedCustomer.City;
                StateTextBox.Text = selectedCustomer.State;
                ZipTextBox.Text = selectedCustomer.ZipCode.ToString();

            }
            else
            {
                TheButton.Text = "Something Wrong";
            }
        }

        private void CustomerControl_Load(object sender, EventArgs e)
        {

        }

        private void CustomerIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Street1Label_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void TheButton_Click(object sender, EventArgs e)
        {
            if (panelDisplay == AddCustomer)
            {
                // Add Customer Button Click
                CreateCustomerButtonClick();
            }
            else if (panelDisplay == UpdateCustomer)
            {
                // Update Customer Button Click
                SaveCustomerButtonClick();
            }
        }

        private void CreateCustomerButtonClick()
        {
            // If necessary information is not null
            if ((FirstNameTextBox.Text != "") &&
                (LastNameTextBox.Text != "") &&
                (Street1TextBox.Text != "") &&
                (CityTextBox.Text != "") &&
                (StateTextBox.Text != "") &&
                (ZipTextBox.Text != ""))
            {
                // Catches and throws an exception if user enters letters into the zipcode field. 
                try
                {
                    string Str = ZipTextBox.Text.Trim();
                    double Num;
                    bool isNum = double.TryParse(Str, out Num); // tests if 
                    if (isNum == false)
                    {
                        throw new FormatException();
                    }
                    // Then Add Customer
                    Customer newCustomer = new Customer(FirstNameTextBox.Text,
                        LastNameTextBox.Text,
                        Street1TextBox.Text,
                        Street2TextBox.Text,
                        CityTextBox.Text,
                        StateTextBox.Text,
                        Int32.Parse(ZipTextBox.Text));

                    // Add Customer to IO Server
                    Customer.addCustomer(newCustomer);

                    // Set Customer ID
                    CustomerIDTextBox.Text = newCustomer.Id.ToString();
                }
                catch
                {
                    MessageBox.Show("Zip Code must contain only numbers.");
                }

                // Disable TextBox Fields
                FirstNameTextBox.Enabled = false;
                LastNameTextBox.Enabled = false;
                Street1TextBox.Enabled = false;
                Street2TextBox.Enabled = false;
                CityTextBox.Enabled = false;
                StateTextBox.Enabled = false;
                ZipTextBox.Enabled = false;

                // Hide the Add Customer button
                TheButton.Visible = false;
            }
        }

        private void SaveCustomerButtonClick()
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to modify the Customer information?", "Update Customer Dialog Box", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                selectedCustomer.FirstName = FirstNameTextBox.Text;
                selectedCustomer.LastName = LastNameTextBox.Text;
                selectedCustomer.Street1 = Street1TextBox.Text;
                selectedCustomer.Street2 = Street2TextBox.Text;
                selectedCustomer.City = CityTextBox.Text;
                selectedCustomer.State = StateTextBox.Text;
                selectedCustomer.ZipCode = Int32.Parse(ZipTextBox.Text);

                Customer.updateCustomer(selectedCustomer);

            }
            else
            {
              
            }
        }


    }
}
