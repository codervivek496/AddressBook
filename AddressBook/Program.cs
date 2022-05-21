using System;

namespace AddressBook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\t\tWelcome to Address Book Program");
            int choice;
            do
            {
                Console.WriteLine("\n1. Contact details in adress book");

                Console.WriteLine("0. Exit");
                Console.WriteLine("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Contact details are as shown below");
                        //Passing the input to Constructor parameter through onject
                        ContactsInfo contactInfo = new ContactsInfo("Vivek", "Kumar", "Somajiguda", "Hyderabad", "Telangana", "viveksinghssm496@gmai.com", "500082", 7004437837);
                        contactInfo.DisplayInformation();
                        break;
                    default:
                        Console.WriteLine("Enter corect choice");
                        break;
                }
            }while (choice != 0);
        }
    }
}