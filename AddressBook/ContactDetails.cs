using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class ContactDetails
    {
        public string firstName;
        public string lastName;
        public string address;
        public string city;
        public string state;
        public string email;
        public string zip;
        public long phoneNumber;

        public ContactDetails(string aFirstName, string aLastName, string aAddress, string aCity, string aState, string aEmail, string aZip, long aPhoneNumber)
        {
            //Set value of class variable from the constructor
            this.firstName = aFirstName;
            this.lastName = aLastName;
            this.address = aAddress;
            this.city = aCity;
            this.state = aState;
            this.email = aEmail;
            this.zip = aZip;
            this.phoneNumber = aPhoneNumber;
        }

        //Display the contacts details
        public void DisplayDetails()
        {
            Console.WriteLine("First Name: " + this.firstName);
            Console.WriteLine("Last Name: " + this.lastName);
            Console.WriteLine("Address: " + this.address);
            Console.WriteLine("City: " + this.city);
            Console.WriteLine("State: " + this.address);
            Console.WriteLine("Email id: " + this.email);
            Console.WriteLine("Zip code: " + this.zip);
            Console.WriteLine("Phoner number: " + this.phoneNumber);
        }

    }
}
