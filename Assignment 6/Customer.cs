using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_6.ContactFiles;

namespace Assignment_6
{//Customer class
    class Customer
    {
        //Fields
        //Contact object
        public Contact CustomerContact { get; set; }
        //String ID
        public string id { get; set; }

        //default constructor
        public Customer()
        {
            id = string.Empty;
            CustomerContact = new Contact();
        }
        //Constructor for when ID and file are presetnt
        public Customer(string ID, Contact exstContact)
        {
            id = ID;
            CustomerContact = exstContact;
        }
        //To string method for reporting.
        public override string ToString()
        {
            return id + CustomerContact.ToString();
        }
    }
}
