using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomerDatabaseApplication;

namespace CustomerDatabaseApplication
{
    public partial class CustomerDatabase : Form
    {
        public CustomerDatabase()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateCustomerButtonClick();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteCustomerButtonClick();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewCustomersButtonClick();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UpdateCustomerButtonClick();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void ViewCustomersButtonClick()
        {
            List<Customer> customerList = Customer.viewCustomers();

            FindListControl searchList = new FindListControl();
            searchList.SearchList.Columns.Add("Customer Id", 80, HorizontalAlignment.Left);
            searchList.SearchList.Columns.Add("First Name", 80, HorizontalAlignment.Left);
            searchList.SearchList.Columns.Add("Last Name", 80, HorizontalAlignment.Left);
            searchList.SearchList.Columns.Add("Street 1", 160, HorizontalAlignment.Left);
            searchList.SearchList.Columns.Add("City", 80, HorizontalAlignment.Left);
            searchList.SearchList.Columns.Add("State", 60, HorizontalAlignment.Left);
            searchList.SearchList.Columns.Add("Zip Code", 80, HorizontalAlignment.Left);

            foreach (Customer customer in customerList)
            {
                //string[] row = {customer.FirstName, customer.LastName, customer.Street1,
                //               customer.City, customer.State, customer.ZipCode.ToString()};
                ListViewItem row = new ListViewItem(customer.Id.ToString());
                row.SubItems.Add(customer.FirstName);
                row.SubItems.Add(customer.LastName);
                row.SubItems.Add(customer.Street1);
                row.SubItems.Add(customer.City);
                row.SubItems.Add(customer.State);
                row.SubItems.Add(customer.ZipCode.ToString());
                searchList.SearchList.Items.Add(row);
            }

            foreach (Control controls in panel1.Controls)
            {
                panel1.Controls.Remove(controls);
            }

            panel1.Controls.Add(searchList);
        }

        private void DeleteCustomerButtonClick()
        {
            string deleteID = null;

            deleteID = Prompt.ShowDialog("Enter Customer ID to be Deleted:","Delete Customer");

            if (deleteID != null)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this customer?", "Delete Customer Dialog Box", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Customer.deleteCustomerByID(Int32.Parse(deleteID));
                }
                else if (dialogResult == DialogResult.No)
                {
                    // Do Nothing
                }
            }
            foreach (Control controls in panel1.Controls)
            {
                panel1.Controls.Remove(controls);
            }
        }

        private void UpdateCustomerButtonClick()
        {
            string searchID;
            searchID = Prompt.ShowDialog("Enter ID of customer you wish to modify", "Update Customer");

            Customer tempCustomer = Customer.findCustomerByID(Int32.Parse(searchID));

            CustomerControl asdf = new CustomerControl(tempCustomer);

            foreach (Control controls in panel1.Controls)
            {
                panel1.Controls.Remove(controls);
            }
            panel1.Controls.Add(newInfo);
        }


        private void CreateCustomerButtonClick()
        {
            CustomerControl newGuy = new CustomerControl(CustomerControl.AddCustomer);
            foreach (Control controls in panel1.Controls)
            {
                panel1.Controls.Remove(controls);
            }
            panel1.Controls.Add(newGuy);
        }


    }
}
