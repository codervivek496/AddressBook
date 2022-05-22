﻿using System;

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
                Console.WriteLine("2. Add new contact");
                Console.WriteLine("3. Edit Added contact");
                Console.WriteLine("4. Delete Added contact");

                Console.WriteLine("0. Exit");
                Console.WriteLine("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Contact details are as shown below");
                        //Passing the input to Constructor parameter through onject
                        ContactDetails contactDetails = new ContactDetails("Vivek", "Kumar", "Somajiguda", "Hyderabad", "Telangana", "viveksinghssm496@gmai.com", "500082", 7004437837);
                        contactDetails.DisplayDetails();
                        break;
                    case 2:
                        AddNewContact addNewContact = new AddNewContact();
                        addNewContact.AddContactDetails();
                        addNewContact.DisplayDetails();
                        break;
                    case 3:
                        AddNewContact editContact = new AddNewContact();
                        editContact.AddContactDetails();
                        editContact.DisplayDetails();

                        //Asking user if he/she wants to edit contact details or not
                        Console.WriteLine("Do you want to Edit contact details? 1: yes/ 0: No");
                        Console.WriteLine("Enter your Choice: ");
                        int choice3 = Convert.ToInt32(Console.ReadLine());
                        if (choice3 == 1)
                        {
                            editContact.EditContactDetails();
                            editContact.DisplayDetails();
                        }
                        break;
                    case 4:
                        AddNewContact deleteContact = new AddNewContact();
                        deleteContact.AddContactDetails();
                        deleteContact.DisplayDetails();
                        //Asking user if he/she wants to edit contact details or not
                        Console.WriteLine("Do you want to Edit contact details? 1: yes/ 0: No");
                        Console.Write("Enter your Choice: ");
                        int choice4 = Convert.ToInt32(Console.ReadLine());
                        if (choice4 == 1)
                        {
                            deleteContact.EditContactDetails();
                            deleteContact.DisplayDetails();
                        }
                        //Asking user if he she wants to delete contact details or not
                        Console.WriteLine("Delete Contact using person name? 1. yes/ 0: No");
                        Console.Write("Enter your choice: ");
                        int choice42 = Convert.ToInt32(Console.ReadLine());
                        if (choice42 == 1)
                        {
                            deleteContact.DeleteContactDetails();
                        }
                        else
                        {
                            deleteContact.DisplayDetails();
                        }
                        break;
                    default:
                        Console.WriteLine("Enter correct choice");
                        break;
                }
            } while (choice != 0);
        }
    }
}