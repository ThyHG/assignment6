using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Assignment_6.ContactFiles;

namespace Assignment_6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //fields
        private CustomerManager cstmManager = new CustomerManager();
        //private Contact cnkt = new Contact();
        public MainWindow()
        {
            this.DataContext = cstmManager;


            FillListBox();
            InitializeComponent();
        }
        /*
         * List<User> items = new List<User>();                        
         * items.Add(new User() { Name = "John Doe", Age = 42, Mail = "john@doe-family.com" });
         */
        //fill list box with all the data.
        private void FillListBox()
        {

           
           // List<Customer> testDingen = cstmManager.GetInfo;
            //ListBoxContent.ItemsSource = testDingen;
            /*List<Customer> testDingen = cstmManager.GetCustomersInfo();
            if(testDingen.Count != 0)
                System.Diagnostics.Debug.WriteLine(testDingen[0].id);
            LvCustomers.ItemsSource = testDingen;*/
            
        }

       

        //Add a new contact
        private void BtnAdd_OnClick(object sender, RoutedEventArgs e)
        {
            //Open new contact window.
            ContactWindow CntcWindow = new ContactWindow();
            if (CntcWindow.ShowDialog().Equals(true))
            {
                //Save shit. todo decide on id.
                Customer NewCustomer = new Customer("100", CntcWindow.CurrentContact);
                cstmManager.AddCustomer(NewCustomer);
                FillListBox();
            }
        }
    }
}
