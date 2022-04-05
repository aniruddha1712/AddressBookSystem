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
            addressBook.AddContactDetail("Aniruddha","Mishra","Ward 11","DGG","CG",491445,7864209211,"xyz@gmail.com");
            addressBook.ViewContact();

            Console.ReadLine();
        }
    }
}
