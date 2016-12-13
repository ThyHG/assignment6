using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6.ContactFiles
{
    class Email
    {
        //all properties with get set permissions

        public string Personal { get; set; }
        public string Business { get; set; }

        public Email() : this(String.Empty)
        {
            
        }

        public Email(string business) : this(business, String.Empty)
        {
            
        }
        public Email(string business, string personal)
        {
            Personal = personal;
            Business = business;
        }

        public override string ToString()
        {
            string OutputString = string.Format("{0,-15}{1,-15}", Business, Personal);
            return OutputString;
        }
    }
}
