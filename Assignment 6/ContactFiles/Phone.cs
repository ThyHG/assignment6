using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6.ContactFiles
{
    class Phone
    {
        //all properties with get set permissions

        public string Home { get; set; }
        public string Work { get; set; }

        public Phone() : this(String.Empty)
        {

        }

        public Phone(string work) : this(work, String.Empty)
        {

        }
        public Phone(string work, string home)
        {
            Home = home;
            Work = work;
        }

        public override string ToString()
        {
            string OutputString = string.Format("{0,-15}{1,-15}", Work, Home);
            return OutputString;
        }
    }
}
