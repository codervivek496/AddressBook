using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class AddNewContact
    {
        //Declaring list to add multiple data types information
        List<ContactDetails> contactDetailsList;

        public AddNewContact()
        {
            contactDetailsList = new List<ContactDetails>();
        }

        public void AddContactDetails()
        {
            //Reading input from user
            Console.WriteLine("Fill contact Details");
            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter Address: ");
            string address = Console.ReadLine();
            Console.Write("Enter City: ");
            string City = Console.ReadLine();
            Console.Write("Enter State: ");
            string State = Console.ReadLine();
            Console.Write("Enter Zip Code: ");
            String zip = Console.ReadLine();
            Console.Write("Enter Phone number: ");
            long phoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.Write("Enter Email id: ");
            String email = Console.ReadLine();

            //passing values to the contactInfo object
            ContactDetails contactDetails = new ContactDetails(firstName, lastName, address, City, State, email, zip, phoneNumber);

            //Checking if entered contact information already present ot not
            if (contactDetailsList.Contains(contactDetails))
            {
                Console.WriteLine("These details are already present in the address book");
            }

            //Add if not in the list
            else
            {
                contactDetailsList.Add(contactDetails);
            }
        }
        //displaying the contact details
        public void DisplayDetails()
        {
            foreach (ContactDetails d in contactDetailsList)
            {
                Console.WriteLine("\nContact details are displayed below");
                Console.WriteLine("First Name: " + d.firstName);
                Console.WriteLine("Last Name: " + d.lastName);
                Console.WriteLine("Address: " + d.address);
                Console.WriteLine("City: " + d.city);
                Console.WriteLine("State: " + d.state);
                Console.WriteLine("Zip code: " + d.zip);
                Console.WriteLine("Phone number: " + d.phoneNumber);
                Console.WriteLine("Email id: " + d.email);
            }
        }
    }
}
