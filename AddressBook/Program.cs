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
                Console.WriteLine("2. Add new contact");
                Console.WriteLine("3. Edit Added contact");
                Console.WriteLine("4. Delete Added contact");
                Console.WriteLine("5. Add multitple person");

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
                        Console.WriteLine("Delete Contact using person name? 1. yes/ 0: No: ");
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
                    case 5:
                        MultipleContacts personContact = new MultipleContacts();
                    Add:
                        Console.WriteLine("Do yo wanna add next contact? 1. Yes/ 0: No:");
                        Console.Write("Enter your Choice: ");
                        int choice5 = Convert.ToInt32(Console.ReadLine());
                        if (choice5 == 1)
                        {
                            personContact.AddContactDetails();
                            personContact.DisplayDetails();
                            goto Add;
                        }

                    //Asking user if he/she want to edit the contact details
                    Edit:
                        if (personContact.ContactDetailsList.Count > 0)
                        {
                            Console.WriteLine("Edit contact details? 1: Yes/ 0: No");
                            Console.Write("Enter your choice: ");
                            int choice51 = Convert.ToInt32(Console.ReadLine());
                            if (choice51 == 1)
                            {
                                personContact.EditContactDetails();
                                personContact.DisplayDetails();
                                goto Edit;
                            }
                        }
                        else
                        {
                            Console.WriteLine("No contact details available to edit");
                        }

                    //Asking user if He/she wants to delete the contact or not
                    Delete:
                        if (personContact.ContactDetailsList.Count > 0)
                        {
                            Console.WriteLine("Delete person using person name? 1. Yes/ 0. No");
                            Console.WriteLine("Enter you choice: ");
                            int choice52 = Convert.ToInt32(Console.ReadLine());
                            if (choice52 == 1)
                            {
                                personContact.DeleteContactDetails();
                                personContact.DisplayDetails();
                                goto Delete;
                            }

                        }
                        else
                        {
                            Console.WriteLine("No contact details available for deletion");
                        }
                        break;
                    case 6:
                        Console.Write("How many Address Books do you need : ");
                        int need = Convert.ToInt32(Console.ReadLine());
                        MultipleAddressBook multipleAddressBook = new MultipleAddressBook(need);
                    GoAgain:
                        multipleAddressBook.DisplayAllAddressBooks();
                        multipleAddressBook.AddingMultipleAddressBooks();
                        multipleAddressBook.DisplayAllAddressBooks();
                        multipleAddressBook.AccessingAddressBook();

                    Add1:
                        Console.Write("You want to enter details ? ( Press 1 for Yes / OtherNumber for No) : ");
                        int choice6 = Convert.ToInt32(Console.ReadLine());
                        if (choice6 == 1)
                        {
                            multipleAddressBook.AddingContactDetails();
                            multipleAddressBook.DisplayDetails();
                            goto Add1;
                        }

                    //Asking user if he/she wanted to edit the contact details or not
                    Edit1:
                        if (multipleAddressBook.contactDetailsList[multipleAddressBook.addressBookIndex].Count > 0)
                        {
                            Console.Write("Edit contact details using name ? ( Press 1 for Yes / OtherNumber for No) : ");
                            int choice61 = Convert.ToInt32(Console.ReadLine());
                            if (choice61 == 1)
                            {
                                multipleAddressBook.EditContactDetails();
                                multipleAddressBook.DisplayDetails();
                                goto Edit1;
                            }
                        }
                        else
                        {
                            Console.WriteLine("No contact details available to edit");
                        }

                    //Asking user if he/she wanted to delete the contact details or not
                    Delete1:
                        if (multipleAddressBook.contactDetailsList[multipleAddressBook.addressBookIndex].Count > 0)
                        {
                            Console.Write("Delete person using person name ? ( Press 1 for Yes / OtherNumber for No) : ");
                            int choice62 = Convert.ToInt32(Console.ReadLine());
                            if (choice62 == 1)
                            {
                                multipleAddressBook.DeleteContactDetails();
                                multipleAddressBook.DisplayDetails();
                                goto Delete1;
                            }
                        }
                        else
                        {
                            Console.WriteLine("No contact details available for deletion");
                        }
                        Console.WriteLine("Want to choose Address Book again ? ( Press 1 for Yes / OtherNumber for No) : ");
                        int start = Convert.ToInt32(Console.ReadLine());
                        if (start == 1)
                        {
                            goto GoAgain;
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