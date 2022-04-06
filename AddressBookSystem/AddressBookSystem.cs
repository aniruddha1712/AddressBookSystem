using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class AddressBookSystem
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Address Book Program");

            AddressBook addressBook = new AddressBook();
            addressBook.AddContactDetail("Aniruddha", "Mishra", "Ward 11", "Dongargarh", "Chhattisgarh", 491445, 1234567890, "xyz@gmail.com");
            addressBook.AddContactDetail("Ram", "Sharma", "Ward 11", "Raipur", "Chhattisgarh", 492001, 7864209211, "abc@gmail.com");
            addressBook.AddContactDetail("Shyam", "Sharma", "Ward 11", "Raigarh", "Chhattisgarh", 491441, 3456724564, "pqr@gmail.com");

            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1. Add New Contact \n2. View Contact \n3. Edit Contact \n4: Delete Contact \n" +
                "5: View one person in contact \n6: Exit \n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    addressBook.AddNewContact();
                    break;
                case 2:
                    addressBook.ViewContact();
                    break;
                case 3:
                    Console.WriteLine("\nEnter First name to edit it's contact details");
                    string input = Console.ReadLine();
                    addressBook.EditContact(input);
                    addressBook.ViewContact();
                    break;
                case 4:
                    Console.WriteLine("\nEnter First name to delete it's contact details");
                    string fName = Console.ReadLine();
                    Console.WriteLine("Enter last name to delete it's contact details");
                    string lName = Console.ReadLine();
                    addressBook.DeleteContact(fName, lName);
                    addressBook.ViewContact();
                    break;
                case 5:
                    Console.WriteLine("Enter firstname of a person ");
                    string f_name = Console.ReadLine();
                    addressBook.ViewContact(f_name);
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid Input!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
