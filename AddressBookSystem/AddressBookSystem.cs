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
            //addressBook.AddContactDetail("Ram", "Sharma", "Ward 11", "Dongargarh", "Chhattisgarh", 491445, 7864209211, "abc@gmail.com");

            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1. Add New Contact \n2. View Contact \n3. Edit Contact \n4: Exit\n");
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
                    addressBook.ViewContact();
                    Console.WriteLine("\nEnter First name to edit it's contact details");
                    string input = Console.ReadLine();
                    addressBook.EditContact(input);
                    break;
                case 4:
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
