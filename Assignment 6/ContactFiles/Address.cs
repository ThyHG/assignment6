using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6.ContactFiles
{
    class Address
    {
        //all properties with get set permissions
        public string Street { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public Countries Country { get; set; }

        //constructors
        //initial constructor (empty values)
        public Address():this(String.Empty, String.Empty, String.Empty)
        {
           
        }
        //Values for all strings apart from country
        public Address(string street, string zipcode, string city) : this(street, zipcode, city, Countries.Sverige)
        {
            
        }
        //All values filled in.
        public Address(string street, string zipcode, string city, Countries country)
        {
            Street = street;
            ZipCode = zipcode;
            City = city;
            Country = country;
        }

        public override string ToString()
        {
            string OutputString = string.Format("{0,-25}{1,-8}{2,-10}{3}", Street, ZipCode, City, Country);
            return OutputString;
        }
    }
}
