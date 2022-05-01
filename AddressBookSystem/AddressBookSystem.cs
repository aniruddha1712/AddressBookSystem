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
            try
            {
                Console.WriteLine("Welcome to the Address Book Program");

                AddressBook addressBook = new AddressBook();

                Console.WriteLine("Please choose an option:");
                Console.WriteLine("1: View Contact \n2: Add New Contact(s) \n3: Edit Contact \n4: Delete Contact " +
                    "\n5: Add Multiple Addressbook\n6: Find person in city/state\n7: View person in city/state\n8: Count by city/state\n" +
                    "9: Sort Contact List\n10: Add new book and save into file\n11: Add new book and save into csv file\n" +
                    "12: Add new book and save into json file\n13: Exit\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        addressBook.ViewContact();
                        break;
                    case 2:
                        addressBook.AddNewContact();
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
                        addressBook.AddNewAddressBook();
                        addressBook.ViewContact();
                        break;
                    case 6:
                        addressBook.SearchPersonInCityOrState();
                        break;
                    case 7:
                        addressBook.ViewPersonInCityOrState();
                        break;
                    case 8:
                        addressBook.AddNewAddressBook();
                        addressBook.CountByCityOrState();
                        break;
                    case 9:
                        addressBook.AddNewAddressBook();
                        addressBook.ViewAddressBook();
                        Console.WriteLine("After sorting:");
                        addressBook.SortPersonName();
                        break;
                    case 10:
                        addressBook.AddNewAddressBook();
                        addressBook.WriteFile();
                        FileIO fileIO = new FileIO();
                        fileIO.ReadFile();
                        break;
                    case 11:
                        addressBook.AddNewAddressBook();
                        addressBook.WriteCsvFile();
                        FileIO csvfile = new FileIO();
                        csvfile.ReadCsvFile();
                        break;
                    case 12:
                        addressBook.AddNewAddressBook();
                        addressBook.WriteJsonFile();
                        FileIO jsonfile = new FileIO();
                        jsonfile.ReadJsonFile();
                        break;
                    case 13:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Input!");
                        break;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
