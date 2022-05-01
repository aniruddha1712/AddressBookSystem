using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class Contact
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int zipcode { get; set; }
        public long phoneNumber { get; set; }
        public string email { get; set; }

        public override string ToString()
        {
            return $"firstname:{firstName} lastname:{lastName} address:{address} city:{city} state:{state} zipcode:{zipcode} phone:{phoneNumber} email:{email}";
        }
    }
}
