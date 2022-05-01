using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using Newtonsoft.Json;

namespace AddressBookSystem
{
    class FileIO
    {
        string path = @"C:\Users\CG-DTE\source\repos\AddressBookSystem\AddressBookSystem\AddBook.txt";
        string csvpath = @"C:\Users\CG-DTE\source\repos\AddressBookSystem\AddressBookSystem\AddBook.csv";
        string jsonpath = @"C:\Users\CG-DTE\source\repos\AddressBookSystem\AddressBookSystem\AddBook.json";
        public void WriteUsingStreamWriter(Dictionary<string, List<Contact>> addressBookDict)
        {
            int count = 1;
            foreach (KeyValuePair<string, List<Contact>> user in addressBookDict)
            {
                using (StreamWriter sr = File.AppendText(path))
                {
                    sr.WriteLine("Name of AddressBook: " + user.Key);
                    foreach (Contact contact in user.Value)
                    {
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
        public void WriteInCsvFile(Dictionary<string, List<Contact>> addressBookDict)
        {
            using (StreamWriter sw = new StreamWriter(csvpath))
            using (CsvWriter csvWriter = new CsvWriter(sw, CultureInfo.InvariantCulture))
                foreach (KeyValuePair<string, List<Contact>> user in addressBookDict)
                {
                    csvWriter.WriteRecords(user.Value.ToList());
                }
            Console.WriteLine("File Written Successfully");
        }
        public void ReadCsvFile()
        {
            using (StreamReader streamreader = new StreamReader(csvpath))
            using (CsvReader csvReader = new CsvReader(streamreader, CultureInfo.InvariantCulture))
            {
                List<Contact> records = csvReader.GetRecords<Contact>().ToList();
                foreach (var contact in records)
                {
                    Console.WriteLine(contact);
                }
            }
            Console.WriteLine("File Read Successfully");
        }
        public void WriteInJsonFile(Dictionary<string, List<Contact>> addressBookDict)
        {
            string res = JsonConvert.SerializeObject(addressBookDict);
            File.WriteAllText(jsonpath, res);
            Console.WriteLine("File Written Successfully");
        }
        public void ReadJsonFile()
        {
            string data = File.ReadAllText(jsonpath);
            Dictionary<string, List<Contact>> addbook = JsonConvert.DeserializeObject<Dictionary<string, List<Contact>>>(data);
            foreach (KeyValuePair<string, List<Contact>> user in addbook)
            {
                Console.WriteLine("\nName of Address Book: " + user.Key);
                foreach (Contact contact in user.Value)
                {
                    Console.WriteLine(contact);
                }
            }
        }
    }
}
