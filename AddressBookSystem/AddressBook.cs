﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class AddressBook
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
