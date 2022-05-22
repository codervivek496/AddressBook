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
        //editing in existing contact details
        public void EditContactDetails()
        {
            Console.WriteLine("Enter the First Name of the contact for which you want to edit: ");
            string fName = Console.ReadLine();
            foreach (ContactDetails contactDetails in contactDetailsList)
            {
                if (contactDetails.firstName == fName)
                {
                    Console.WriteLine("1. First Name");
                    Console.WriteLine("2.Last Name");
                    Console.WriteLine("3. Address");
                    Console.WriteLine("4. City");
                    Console.WriteLine("5. State");
                    Console.WriteLine("6. Zip Code");
                    Console.WriteLine("7. Phone number");
                    Console.WriteLine("8. Email id");
                    Console.WriteLine("0. Exit to display contact details");
                    Console.WriteLine("Choose what you wnat to edit");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter new First Name : ");
                            string newName = Console.ReadLine();
                            contactDetails.firstName = newName;
                            break;
                        case 2:
                            Console.Write("Enter new Last Name : ");
                            string newLast = Console.ReadLine();
                            contactDetails.lastName = newLast;
                            break;
                        case 3:
                            Console.Write("Enter new Address : ");
                            string newAdd = Console.ReadLine();
                            contactDetails.address = newAdd;
                            break;
                        case 4:
                            Console.Write("Enter new City : ");
                            string newCity = Console.ReadLine();
                            contactDetails.city = newCity;
                            break;
                        case 5:
                            Console.Write("Enter new State : ");
                            string newState = Console.ReadLine();
                            contactDetails.state = newState;
                            break;
                        case 6:
                            Console.Write("Enter new zip code : ");
                            string newZip = (Console.ReadLine());
                            contactDetails.zip = newZip;
                            break;
                        case 7:
                            Console.Write("Enter new Phone number : ");
                            long newPhone = Convert.ToInt64(Console.ReadLine());
                            contactDetails.phoneNumber = newPhone;
                            break;
                        case 8:
                            Console.Write("Enter new Email id : ");
                            string newEmail = Console.ReadLine();
                            contactDetails.email = newEmail;
                            break;
                        default:
                            Console.WriteLine("\nEnter correct choice");
                            break;
                    }
                }
                //If input does not match with the contact list detail
                else
                {
                    Console.WriteLine("Entered input does not match with contact details");
                }
            }
        }

        //For deleting Added contact details
        public void DeleteContactDetails()
        {
            Console.Write("Enter First name of contact you want to delete: ");
            string deleteContact = Console.ReadLine();
            foreach (ContactDetails contactDetails in contactDetailsList)
            {
                if (contactDetails.firstName == deleteContact)
                {
                    contactDetailsList.Remove(contactDetails);
                    Console.WriteLine("***contact details deteted***");
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong credential");
                }
            }
        }
    }
}