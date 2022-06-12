using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class ContactPerson
    {
        //Declaring list to add multiple data type information
        List<ContactDetails> contactDetailsList;

        Dictionary<string, List<ContactDetails>> cityDictionary;

        HashSet<string> cityList;

        HashSet<string> stateList;

        public ContactPerson()
        {
            contactDetailsList = new List<ContactDetails>();
            cityDictionary = new Dictionary<string, List<ContactDetails>>();
            cityList = new HashSet<string>();
            stateList = new HashSet<string>();
        }

        public void AddingContactDetails()
        {
            ContactPerson contactPerson = new ContactPerson();

        //Filling the contact details
        AddContactDetailsAgain:
            Console.WriteLine("Add details one by one");
            Console.Write("Enter First Name : ");
            string firstName = Console.ReadLine();
            if (firstName == "")
            {
                Console.WriteLine("Cannot add empty values");
                goto AddContactDetailsAgain;
            }
            if (CheckForExistingContact(contactDetailsList, firstName) == false)
            {
                goto AddContactDetailsAgain;
            }
            Console.Write("Enter Last Name : ");
            string lastName = Console.ReadLine();
            if (lastName == "")
            {
                Console.WriteLine("Cannot add empty values");
                goto AddContactDetailsAgain;
            }
            Console.Write("Enter Address : ");
            string address = Console.ReadLine();
            if (address == "")
            {
                Console.WriteLine("Cannot add empty values");
                goto AddContactDetailsAgain;
            }
            Console.Write("Enter City : ");
            string city = Console.ReadLine();
            if (city == "")
            {
                Console.WriteLine("Cannot add empty values");
                goto AddContactDetailsAgain;
            }
            Console.Write("Enter State : ");
            string state = Console.ReadLine();
            if (state == "")
            {
                Console.WriteLine("Cannot add empty values");
                goto AddContactDetailsAgain;
            }
            Console.Write("Enter zip code : ");
            int zip = Convert.ToInt32(Console.ReadLine());
            if (zip == null)
            {
                Console.WriteLine("Cannot add empty values");
                goto AddContactDetailsAgain;
            }
            Console.Write("Enter phone number : ");
            long phoneNumber = Convert.ToInt64(Console.ReadLine());
            if (phoneNumber == null)
            {
                Console.WriteLine("Cannot add empty values");
                goto AddContactDetailsAgain;
            }
            Console.Write("Enter Email id : ");
            string email = Console.ReadLine();
            if (email == "")
            {
                Console.WriteLine("Cannot add empty values");
                goto AddContactDetailsAgain;
            }

            //Passing values to the details object
            ContactDetails details = new ContactDetails(firstName, lastName, address, city, state, email, zip, phoneNumber);

            //Checking if entered details already present or not
            int flag = 0;
            if (contactDetailsList.Count > 0)
            {
                foreach (ContactDetails d in contactDetailsList)
                {
                    if (d.firstName.ToUpper().Equals(firstName.ToUpper()))
                    {
                        //Setting flag to 1 if same firstName is present
                        flag = 1;
                    }
                }
            }
            if (flag == 1)
            {
                Console.WriteLine("Same first name already present in Address book");
            }

            //If not add it to the list of the current Address Book
            else
            {
                contactDetailsList.Add(details);
            }
        }

        public bool CheckForExistingContact(List<ContactDetails> detailsList, string firstName)
        {
            foreach (ContactDetails details in detailsList)
            {
                if (firstName.Equals(details.firstName))
                {
                    Console.WriteLine("First Name already present in this or another address book");
                    return false;
                }
            }
            return true;
        }

        //Displaying the details
        public void DisplayDetails()
        {
            SortingContactDetails();
            Console.WriteLine("\nContact details are as shown below");
            foreach (ContactDetails d in contactDetailsList)
            {
                Console.WriteLine();
                Console.WriteLine("First Name : " + d.firstName);
                Console.WriteLine("Last Name : " + d.lastName);
                Console.WriteLine("Address : " + d.address);
                Console.WriteLine("City : " + d.city);
                Console.WriteLine("State : " + d.state);
                Console.WriteLine("Zip code : " + d.zip);
                Console.WriteLine("Phone number : " + d.phoneNumber);
                Console.WriteLine("Email id : " + d.email);
            }
        }

        //Editing in existing contact details
        public void EditContactDetails()
        {
            Console.Write("Enter the First Name of the contact for which you want to edit : ");
            string fName = Console.ReadLine();
            foreach (ContactDetails detail in contactDetailsList)
            {
                if (detail.firstName == fName)
                {
                    Console.WriteLine("1. First Name");
                    Console.WriteLine("2. Last Name");
                    Console.WriteLine("3. Address");
                    Console.WriteLine("4. City");
                    Console.WriteLine("5. State");
                    Console.WriteLine("6. Zip code");
                    Console.WriteLine("7. Phone number");
                    Console.WriteLine("8. Email id");
                    Console.WriteLine("Other. Exit to display contact details");
                    Console.Write("Choose what you want to edit : ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter new First Name : ");
                            string newName = Console.ReadLine();
                            detail.firstName = newName;
                            break;
                        case 2:
                            Console.Write("Enter new Last Name : ");
                            string newLast = Console.ReadLine();
                            detail.lastName = newLast;
                            break;
                        case 3:
                            Console.Write("Enter new Address : ");
                            string newAdd = Console.ReadLine();
                            detail.address = newAdd;
                            break;
                        case 4:
                            Console.Write("Enter new City : ");
                            string newCity = Console.ReadLine();
                            detail.city = newCity;
                            break;
                        case 5:
                            Console.Write("Enter new State : ");
                            string newState = Console.ReadLine();
                            detail.state = newState;
                            break;
                        case 6:
                            Console.Write("Enter new zip code : ");
                            String newZip = Console.ReadLine();
                            detail.zip = newZip;
                            break;
                        case 7:
                            Console.Write("Enter new Phone number : ");
                            long newPhone = Convert.ToInt64(Console.ReadLine());
                            detail.phoneNumber = newPhone;
                            break;
                        case 8:
                            Console.Write("Enter new Email id : ");
                            string newEmail = Console.ReadLine();
                            detail.email = newEmail;
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

        //For deleting person details
        public void DeleteContactDetails()
        {
            Console.Write("Enter First name of the contact detail you want to delete : ");
            string deleteName = Console.ReadLine();

            //Lambda expression to find if deleteName is present in the records or not
            ContactDetails detailsTemp = contactDetailsList.FirstOrDefault(x => x.firstName == deleteName);

            foreach (ContactDetails detail in contactDetailsList)
            {
                if (detail.firstName == detailsTemp.firstName)
                {
                    contactDetailsList.Remove(detail);
                    Console.WriteLine("Person details deleted");
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong credentials");
                }
            }
        }

        //To search person by city name
        public void SearchPersonByCity(string cityName)
        {
            int count = 0;
            foreach (ContactDetails d in contactDetailsList)
            {
                if (d.city == cityName)
                {
                    Console.WriteLine();
                    Console.WriteLine("First Name : " + d.firstName);
                    Console.WriteLine("Last Name : " + d.lastName);
                    Console.WriteLine("Address : " + d.address);
                    Console.WriteLine("City : " + d.city);
                    Console.WriteLine("State : " + d.state);
                    Console.WriteLine("Zip code : " + d.zip);
                    Console.WriteLine("Phone number : " + d.phoneNumber);
                    Console.WriteLine("Email id : " + d.email);
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No records for city");
            }
        }

        //To search person by state name
        public void SearchPersonByState(string stateName)
        {
            int count = 0;
            foreach (ContactDetails d in contactDetailsList)
            {
                if (d.state == stateName)
                {
                    Console.WriteLine();
                    Console.WriteLine("First Name : " + d.firstName);
                    Console.WriteLine("Last Name : " + d.lastName);
                    Console.WriteLine("Address : " + d.address);
                    Console.WriteLine("City : " + d.city);
                    Console.WriteLine("State : " + d.state);
                    Console.WriteLine("Zip code : " + d.zip);
                    Console.WriteLine("Phone number : " + d.phoneNumber);
                    Console.WriteLine("Email id : " + d.email);
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No records for city");
            }
        }

        //To add city in state list
        public HashSet<string> AddToCityList()
        {
            foreach (ContactDetails details in contactDetailsList)
            {
                cityList.Add(details.city);
            }
            return cityList;
        }

        public List<ContactDetails> ContactDetailsByCity(string cityName, List<ContactDetails> cityDetailsList)
        {
            foreach (ContactDetails details in contactDetailsList)
            {
                if (details.city.Equals(cityName))
                {
                    cityDetailsList.Add(details);
                }
            }
            return cityDetailsList;
        }

        //To add state in state list
        public HashSet<string> AddToStateList()
        {
            foreach (ContactDetails details in contactDetailsList)
            {
                stateList.Add(details.state);
            }
            return stateList;
        }

        public List<ContactDetails> ContactDetailsByState(string stateName, List<ContactDetails> stateDetailsList)
        {
            foreach (ContactDetails details in contactDetailsList)
            {
                if (details.state.Equals(stateName))
                {
                    stateDetailsList.Add(details);
                }
            }
            return stateDetailsList;
        }

        public List<ContactDetails> SortingContactDetails()
        {
            Console.WriteLine("1. Sort Contact Details by name");
            Console.WriteLine("2. Sort Contact Details by city");
            Console.WriteLine("3. Sort Contact Details by state");
            Console.WriteLine("4. Sort Contact Details by zip");
            Console.Write("Enter your choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    contactDetailsList.Sort((contact1, contact2) => contact1.firstName.CompareTo(contact2.firstName));
                    return contactDetailsList;
                    break;
                case 2:
                    contactDetailsList.Sort((contact1, contact2) => contact1.city.CompareTo(contact2.city));
                    return contactDetailsList;
                    break;
                case 3:
                    contactDetailsList.Sort((contact1, contact2) => contact1.state.CompareTo(contact2.state));
                    return contactDetailsList;
                    break;
                case 4:
                    contactDetailsList.Sort((contact1, contact2) => contact1.zip.CompareTo(contact2.zip));
                    return contactDetailsList;
                    break;
                default:
                    return contactDetailsList;
            }
        }
    }
}