using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressBook
{
    public class WorkContacts
    {

        private ArrayList contactList;
        private Dictionary<string, Model> contacts;
        public WorkContacts()
        {
            contactList = new ArrayList();
            contacts = new Dictionary<string, Model>();
        }
        public void AddContact()
        {
            Console.WriteLine("Enter First Name");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter Address");
            string address = Console.ReadLine();

            Console.WriteLine("Enter City Name");
            string city = Console.ReadLine();


            Console.WriteLine("Enter State Name");
            string state = Console.ReadLine();

            Console.WriteLine("Enter  Zip number");
            string zip = Console.ReadLine();

            Console.WriteLine("Enter Phone Number");
            string phoneNumber = Console.ReadLine();

            Console.WriteLine("Enter Email");
            string eMail = Console.ReadLine();

            Model addresses = new Model(firstName, lastName, address, city, state, zip, phoneNumber, eMail);
            contactList.Add(addresses);
            contacts.Add(firstName, addresses);
        }
        public void GetContact()
        {
            foreach (KeyValuePair<string, Model> item in contacts)
            {
                Console.WriteLine(item.Value);
            }
        }
        public void EditContacts(string key)
        {
            Console.WriteLine("Key is " + key);
            if (contacts.ContainsKey(key))
            {
                Console.WriteLine("Enter First Name");
                string firstName = Console.ReadLine();

                Console.WriteLine("Enter Last Name");
                string lastName = Console.ReadLine();

                Console.WriteLine("Enter Address");
                string address = Console.ReadLine();

                Console.WriteLine("Enter City Name");
                string city = Console.ReadLine();


                Console.WriteLine("Enter State Name");
                string state = Console.ReadLine();

                Console.WriteLine("Enter  Zip number");
                string zip = Console.ReadLine();

                Console.WriteLine("Enter Phone Number");
                string phoneNumber = Console.ReadLine();

                Console.WriteLine("Enter Email");
                string eMail = Console.ReadLine();
                Model addresses = new Model(firstName, lastName, address, city, state, zip, phoneNumber, eMail);

                contactList.Add(addresses);
                contacts[key] = addresses;
            }
            else
            {
                Console.WriteLine("Key doesnt exist");
            }
        }
        public void DeleteContacts()
        {
            Console.WriteLine("Enter first name to Delete");
            string input = Console.ReadLine();
            if (contacts.ContainsKey(input))
            {
                contacts.Remove(input);
            }
            else
            {
                Console.WriteLine("first name doesnt exist");
            }
        }
    }
}
