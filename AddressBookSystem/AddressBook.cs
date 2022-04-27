using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class AddressBook : IContact
    {
        List<Contact> contactList;
        Dictionary<string, List<Contact>> addressBookDict;
        public AddressBook()
        {
            contactList = new List<Contact>();
            addressBookDict = new Dictionary<string, List<Contact>>();
        }
        public void AddNewContact()
        {
            Console.WriteLine("Enter how many contacts you want to add?");
            int howMany = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= howMany; i++)
            {

                Console.WriteLine("\nEnter your First Name: ");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter your Last Name: ");
                string lastName = Console.ReadLine();
                Console.WriteLine("Enter your Address: ");
                string address = Console.ReadLine();
                Console.WriteLine("Enter your City: ");
                string city = Console.ReadLine();
                Console.WriteLine("Enter your State: ");
                string state = Console.ReadLine();
                Console.WriteLine("Enter your Zipcode: ");
                int zipcode = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your Phone Number: ");
                long phoneNumber = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Enter your Email-ID: ");
                string email = Console.ReadLine();

                Contact personDetail = new Contact(firstName, lastName, address, city, state, zipcode, phoneNumber, email);
                if (CheckIfAlreadyPresent(firstName, lastName))
                    Console.WriteLine("Already exist");
                else
                {
                    contactList.Add(personDetail);
                }
            }
        }
        public bool CheckIfAlreadyPresent(string firstName, string lastName) //using lambda for no duplicate entry
        {
            return contactList.Any(x => x.firstName == firstName && x.lastName == lastName);
        }

        public void ViewContact()
        {
            int count = 1;
            foreach (var contact in contactList)
            {
                Console.WriteLine("Person {0} Details: ", count);
                Console.WriteLine("First Name: " + contact.firstName);
                Console.WriteLine("Last Name: " + contact.lastName);
                Console.WriteLine("Address: " + contact.address);
                Console.WriteLine("City: " + contact.city);
                Console.WriteLine("State: " + contact.state);
                Console.WriteLine("ZipCode: " + contact.zipcode);
                Console.WriteLine("Phone Number: " + contact.phoneNumber);
                Console.WriteLine("Email ID: " + contact.email);
                count++;
            }
        }
        public void EditContact(string input)
        {
            for (int i = 0; i < contactList.Count; i++)
            {
                if (contactList[i].firstName == input)
                {
                    Console.WriteLine("\n Choose the field you want to edit " +
                        "\n 1. First Name \n 2 Last Name \n 3. Address \n 4. City \n 5. State \n 6. ZipCode \n 7. Phone Number \n 8. Email-ID\n");
                    int edit = Convert.ToInt32(Console.ReadLine());
                    switch (edit)
                    {
                        case 1:
                            Console.WriteLine("Enter New First Name: ");
                            contactList[i].firstName = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Enter New Last Name: ");
                            contactList[i].lastName = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Enter New Address: ");
                            contactList[i].address = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Enter New City: ");
                            contactList[i].city = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Enter New State: ");
                            contactList[i].state = Console.ReadLine();
                            break;
                        case 6:
                            Console.WriteLine("Enter New ZipCode: ");
                            contactList[i].zipcode = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 7:
                            Console.WriteLine("Enter New Phone Number: ");
                            contactList[i].phoneNumber = Convert.ToInt64(Console.ReadLine());
                            break;
                        case 8:
                            Console.WriteLine("Enter New Email-ID: ");
                            contactList[i].email = Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("Invalid Input");
                            break;
                    }
                }
            }
        }
        public void DeleteContact(string fName, string lName)
        {
            for (int i = 0; i < contactList.Count; i++)
            {
                if (contactList[i].firstName == fName && contactList[i].lastName == lName)
                {
                    Console.WriteLine("Contact {0} {1} Deleted Successfully from Address Book.", contactList[i].firstName, contactList[i].lastName);
                    contactList.RemoveAt(i);
                }
            }
        }
        public void AddNewAddressBook()
        {
            Console.WriteLine("Howmany number of address books you want to add? ");
            int numberOfBooks = Convert.ToInt32(Console.ReadLine());
            while (numberOfBooks > 0)
            {
                Console.WriteLine("Enter name of the address book:");
                string addBookName = Console.ReadLine();
                if (addressBookDict.ContainsKey(addBookName))
                {
                    Console.WriteLine("Address Book Name Already Exists");
                }
                else
                {
                    AddressBook books = new AddressBook();
                    List<Contact> list = new List<Contact>();
                    books.AddNewContact();
                    addressBookDict.Add(addBookName, list);
                }
                foreach (KeyValuePair<string, List<Contact>> item in addressBookDict)
                {
                    Console.WriteLine($"key:{item.Key} value:{item.Value}");
                }
                numberOfBooks--;
            }
        }
        public void SearchPersonInCityOrState()
        {
            Console.WriteLine("enter the city or state name");
            string city = Console.ReadLine();
            int found = 0;
            foreach (KeyValuePair<string, List<Contact>> user in addressBookDict)
            {
                foreach (Contact contact in user.Value)
                {
                    if (contact.city == city || contact.state == city)
                    {
                        Console.WriteLine(contact.firstName);
                        found = 1;
                    }
                }
            }
            if (found == 0)
                Console.WriteLine("No record found");
        }
        public void ViewPersonInCityOrState()
        {
            Console.WriteLine("enter the city or state name");
            string city = Console.ReadLine();
            foreach (KeyValuePair<string, List<Contact>> user in addressBookDict)
            {
                foreach (Contact contact in user.Value)
                {
                    if (contact.city == city || contact.state == city)
                    {
                        Console.WriteLine("FirstName: " + contact.firstName);
                        Console.WriteLine("LastName: " + contact.lastName);
                        Console.WriteLine("City: " + contact.city);
                        Console.WriteLine("State: " + contact.state);
                        Console.WriteLine("Address: " + contact.address);
                        Console.WriteLine("zipCode: " + contact.zipcode);
                        Console.WriteLine("Email: " + contact.email);
                        Console.WriteLine("PhoneNo: " + contact.phoneNumber);
                    }
                }
            }
        }
    }
}
