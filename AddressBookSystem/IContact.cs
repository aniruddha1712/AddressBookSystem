using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    interface IContact
    {
        void AddContactDetail(string firstName, string lastName, string address, string city,
            string state, int zipcode, long phoneNumber, string email);
        void ViewContact();
        void ViewContact(string fname);
        void EditContact(string input);
        void DeleteContact(string fName, string lName);
    }
}
