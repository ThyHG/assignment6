using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using Assignment_6.ContactFiles;

namespace Assignment_6
{
    /// <summary>
    /// Interaction logic for ContactWindow.xaml
    /// </summary>
    public partial class ContactWindow : Window
    {
        private Contact contact = new Contact();
        public ContactWindow()
        {
            InitializeComponent();
            InitializeGUI();
        }
        //todo make everything fucking public?
        internal Contact CurrentContact
        {
            get { return contact; }
            set { contact = value; }
        }


        private void InitializeGUI()
        {
            //Reset all input fields to an empty string.
            TextBoxFirstName.Text = String.Empty;
            TextBoxLastName.Text = String.Empty;
            TextBoxHomePhone.Text = String.Empty;
            TextBoxCellPhone.Text = String.Empty;
            TextBoxEmailBusiness.Text = String.Empty;
            TextBoxEmailPrivate.Text = String.Empty;
            TextBoxStreet.Text = String.Empty;
            TextBoxCity.Text = String.Empty;
            TextBoxZipCode.Text = String.Empty;

            //load combobox items, display proper names (no underscores) and set index to Sweden.
            foreach (var item in Enum.GetValues(typeof(Countries)))
            {
                string itemString = item.ToString();
                itemString = itemString.Replace("_", " ");
                ComboBoxCountry.Items.Add(itemString);
            }
            ComboBoxCountry.SelectedIndex = (int)Countries.Sverige;
        }

        //Set all the values for the contact and it's subclasses from the window.
        private void SaveValues()
        {
            if (CheckValues())
            {
                //set name values
                contact.FirstName = TextBoxFirstName.Text; //firstname
                contact.LastName = TextBoxLastName.Text; //lastname

                //Set address values
                contact.Caddress = new Address(TextBoxStreet.Text, //street
                    TextBoxZipCode.Text, //zipcode
                    TextBoxCity.Text, //city
                    (Countries) ComboBoxCountry.SelectedIndex //country
                );
                //set email values
                contact.Cemail = new Email(
                    TextBoxEmailBusiness.Text, //business mail
                    TextBoxEmailPrivate.Text); //private mail
                //set phone values
                contact.Cphone = new Phone(TextBoxCellPhone.Text, //work phone
                    TextBoxHomePhone.Text); // private phone

                //set dialogresult to true to close the window.
                DialogResult = true;

            }
            else
            {
                MessageBox.Show("Please fill in a First Name, a last name and a city");
            }
        }

        private bool CheckValues()
        {
            if (TextBoxFirstName.Text.Trim(' ') != String.Empty || TextBoxFirstName.Text.Trim(' ') != String.Empty ||
                TextBoxCity.Text.Trim(' ') != String.Empty)
            {
                return true;
            }
            return false;
        }

        //On button Okay click.
        private void ButtonOkay_OnClick(object sender, RoutedEventArgs e)
        {
            SaveValues();
        }

        private void ButtonCancel_OnClick(object sender, RoutedEventArgs e)
        {
            DialogBox dialogBox = new DialogBox();
            dialogBox.Owner = Application.Current.MainWindow;
            if (dialogBox.ShowDialog().Equals(true))
            {

                Close();
            }
            else
            {
                //Do nothing
            }

               
        }
    }


}
