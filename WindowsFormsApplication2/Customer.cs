using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;
using System.Web.Script.Serialization;

namespace CustomerDatabaseApplication
{
    class Customer : CustomerObject
    {
        // Json Creation keys
        private const string FIRST_NAME_KEY = @"FirstName";
        private const string LAST_NAME_KEY = @"LastName";
        private const string STREET1_KEY = @"Street1";
        private const string STREET2_KEY = @"Street2";
        private const string CITY_KEY = @"City";
        private const string STATE_KEY = @"State";
        private const string ZIP_KEY = @"Zip";

        private string firstName;
        private string lastName;
        private string street1;
        private string street2;
        private string city;
        private string state;
        private int zip;


        // Customer Constructor
        public Customer(string nameFirst, string nameLast, string streetOne, string streetTwo, string cityDec, string stateDec, int zipDec)
        {
            firstName = nameFirst;
            lastName = nameLast;
            street1 = streetOne;
            street2 = streetTwo;
            city = cityDec;
            state = stateDec;
            zip = zipDec;
        }

        // Customer Constructor for Json
        public Customer(string customerJson)
        {
            // A Json class used to convert the string data in the text files into an object that is readable by the methods below
            JavaScriptSerializer deSerializer = new JavaScriptSerializer();

            Dictionary<string, object> customerDictionary = deSerializer.Deserialize<Dictionary<string, object>>(customerJson);
            this.Id = (int)customerDictionary[ID_KEY];
            this.firstName = (string)customerDictionary[FIRST_NAME_KEY];
            this.lastName = (string)customerDictionary[LAST_NAME_KEY];
            this.street1 = (string)customerDictionary[STREET1_KEY];
            this.street2 = (string)customerDictionary[STREET2_KEY];
            this.city = (string)customerDictionary[CITY_KEY];
            this.state = (string)customerDictionary[STATE_KEY];
            this.zip = (int)customerDictionary[ZIP_KEY];
        }

        // Create and add a new customer object to the customer text file
        public static int addCustomer(Customer newCustomer)
        {
            // Access to ioServer
            CustomerIOServer<Customer> ioServer = new CustomerIOServer<Customer>();

            // Insert customer object to files using ioServer
            return ioServer.insert(newCustomer);
        }

        // Use the assigned Customer Id # to find customer information already stored in text file
        public static Customer findCustomerByID(int customerId)
        {
            // Access to ioServer
            CustomerIOServer<Customer> ioServer = new CustomerIOServer<Customer>();

            // Find customer object by customer Id
            return ioServer.findById(customerId);
        }

        public static List<Customer> viewCustomers()
        {
            CustomerIOServer<Customer> ioServer = new CustomerIOServer<Customer>();
            List<Customer> allCustomers = ioServer.findAll();

            return allCustomers;
        }

        // Update one or more of the fields of information for an existing customer that is already stored in the text file
        public static int updateCustomer(Customer customer)
        {
            // Access to ioServer
            CustomerIOServer<Customer> ioServer = new CustomerIOServer<Customer>();

            // Update customer information using ioServer for an already existing customer
            return ioServer.update(customer);
        }

        // Find and delete an already existing customer object and all its information fields including the created Id #
        public static int deleteCustomerByID(int customerId)
        {
            // Access to ioServer
            CustomerIOServer<Customer> ioServer = new CustomerIOServer<Customer>();

            // Find a specific cutomer Id and delete the cooresponding customer information, including Id #
            return ioServer.deleteById(customerId);
        }

        // Override String method to create a hashtable used to store object information
        public override string ToString()
        {
            // Create a dictionary to hold the customer information
            Dictionary<string, object> customerDictionary = new Dictionary<string, object>();

            // Add the customer information and dictonary keys to the hash table
            customerDictionary.Add(ID_KEY, this.Id);
            customerDictionary.Add(FIRST_NAME_KEY, this.FirstName);
            customerDictionary.Add(LAST_NAME_KEY, this.LastName);
            customerDictionary.Add(STREET1_KEY, this.Street1);
            customerDictionary.Add(STREET2_KEY, this.Street2);
            customerDictionary.Add(CITY_KEY, this.City);
            customerDictionary.Add(STATE_KEY, this.State);
            customerDictionary.Add(ZIP_KEY, this.ZipCode);

            // Create serializer instance of JavaScriptSerializer class
            JavaScriptSerializer serializer = new JavaScriptSerializer();

            // Serialize this data to json, converts the object into an easier to understand string
            string customerString = serializer.Serialize((object)customerDictionary);

            // Return the data as json
            return customerString;
        }

        // ID Accessor
        public int ID
        {
            get
            {
                return this.Id;
            }
            set
            {
                Id = value;
            }
        }

        // First Name Accessor
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        // Last Name Accessor
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        // Street1 Accessor
        public string Street1
        {
            get
            {
                return street1;
            }
            set
            {
                street1 = value;
            }
        }
        // Street2 Accessor
        public string Street2
        {
            get
            {
                return street2;
            }
            set
            {
                street2 = value;
            }
        }
        // City Accessor
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        // State Accessor
        public string State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }
        // Zip Code Accessor
        public int ZipCode
        {
            get
            {
                return zip;
            }
            set
            {
                zip = value;
            }
        }


    }
}
