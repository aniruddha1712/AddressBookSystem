using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    interface IContact
    {
        void AddNewContact();
        void ViewContact();
        void EditContact(string input);
        void DeleteContact(string fName, string lName);
        void AddNewAddressBook();
    }
}
