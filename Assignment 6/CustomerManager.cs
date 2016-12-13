using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Assignment_6.ContactFiles;

namespace Assignment_6
{
    //Customer manager class
    class CustomerManager : INotifyPropertyChanged
    {
        //fields
        //List of customers in file
        private List<Customer> CustomerList;
        public event PropertyChangedEventHandler PropertyChanged;
        //default constructor
        public CustomerManager()
        {
            //Makes a new list
            CustomerList = new List<Customer>();
        }

        //returns the amount of items in List<T>
        public int Count
        {
            get { return CustomerList.Count; }
        }

        public void AddCustomer(Customer CustomerIN)
        {
            //add a customer.
            CustomerList.Add(CustomerIN);
        }

        //returns a string[] so it can be presentend in listbox.
        public List<Customer> GetCustomersInfo()
        {
           
            //return the CustomerList as a string[]
            /*todo fix this loop - remember to set return to string[]
            string[] CustomerInfo = new string[Count+1];
            int index = 0;
            foreach (Customer cust in CustomerList)
            {
                
                CustomerInfo[index] = cust.ToString();
                index++;
            }
            return CustomerInfo;
            */
            return CustomerList;
           

        }

        public List<Customer> GetInfo
        {
            get
            {
                OnPropertyChanged();
                return CustomerList;
            }
           
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
