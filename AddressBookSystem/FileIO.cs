using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class FileIO
    {
        string path = @"C:\Users\CG-DTE\source\repos\AddressBookSystem\AddressBookSystem\AddBook.txt";
        public void WriteUsingStreamWriter(Dictionary<string, List<Contact>> addressBookDict)
        {
            int count = 1;
            foreach (KeyValuePair<string, List<Contact>> user in addressBookDict)
            {
                using (StreamWriter sr = File.AppendText(path))
                {
                    sr.WriteLine("Name of AddressBook" + user.Key);
                    foreach (Contact contact in user.Value)
                    {
                        sr.Write("\nPerson " + count + "\n");
                        sr.Write(" FirstName: " + contact.firstName);
                        sr.Write(" LastName: " + contact.lastName);
                        sr.Write(" City: " + contact.city);
                        sr.Write(" State: " + contact.state);
                        sr.Write(" Address: " + contact.address);
                        sr.Write(" zipCode: " + contact.zipcode);
                        sr.Write(" PhoneNo: " + contact.phoneNumber);
                        sr.Write(" Email: " + contact.email);
                        count++;
                    }
                }
            }
            Console.WriteLine("File Written Successfully");
        }
        public void ReadFile()
        {
            string lines = File.ReadAllText(path);
            Console.WriteLine(lines);
            Console.WriteLine("File Read Successfully");
        }
    }
}
