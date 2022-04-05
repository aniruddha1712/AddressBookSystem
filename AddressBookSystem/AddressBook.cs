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
        public AddressBook()
        {
         contactList = new List<Contact>();
        }

        public void AddContactDetail(string firstName, string lastName, string address, string city,
            string state, int zipcode, long phoneNumber, string email)
        {
            Contact personDetail = new Contact(firstName,lastName,address,city,state,zipcode,phoneNumber,email);
            contactList.Add(personDetail);
        }
        public void AddNewContact()
        {
            Console.WriteLine("Enter your First Name: ");
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

            AddContactDetail(firstName, lastName, address, city, state, zipcode, phoneNumber, email);
            ViewContact();
        }

            public void ViewContact()
        {
            foreach (var contact in contactList)
            {
                Console.WriteLine("First Name: " + contact.firstName);
                Console.WriteLine("Last Name: " + contact.lastName);
                Console.WriteLine("Address: " + contact.address);
                Console.WriteLine("City: " + contact.city);
                Console.WriteLine("State: " + contact.state);
                Console.WriteLine("ZipCode: " + contact.zipcode);
                Console.WriteLine("Phone Number: " + contact.phoneNumber);
                Console.WriteLine("Email ID: " + contact.email);
            }
        }
    }
}
