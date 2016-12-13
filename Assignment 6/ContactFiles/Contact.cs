using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6.ContactFiles
{
    class Contact
    {
        //all properties with get set permissions
        public Address Caddress { get; set; }
        public Email Cemail { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Phone Cphone { get; set; }

        //constructors
        public Contact()
        {
            FirstName = String.Empty;
            LastName= String.Empty;
            
        }

        public Contact(string firstName, string lastName, Address adr, Phone phn, Email eml)
        {
            //set all values.
            FirstName = firstName;
            LastName = lastName;
            Caddress = adr;
            Cphone = phn;
            Cemail = eml;
        }
        //getter for the full name of the contact
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        //Tostring method override to display in other areas.
        public override string ToString()
        {
            string OutputString = string.Format("{0}{1}{2}{3}", FullName, Caddress, Cphone, Cemail);
            return OutputString;
        }
    }
}
