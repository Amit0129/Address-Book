using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressBook
{
    public class AddressBookBuilder
    {
        Dictionary<string,Model> addressBook = new Dictionary<string,Model>();

        public void Add_AddressBook(string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber, string eMail)
        {
            Model model = new Model(firstName,lastName,address,city,state,zip,phoneNumber,eMail);
            addressBook.Add(firstName, model);
        }
        public void AddressDisplay()
        {
            foreach (var item in addressBook)
            {
                Console.WriteLine($"{item.Key} Contact Details");
                Console.WriteLine("First Name is : " + item.Value.firstName);
                Console.WriteLine("Last Name is  : " + item.Value.lastName);
                Console.WriteLine("Address is    : " + item.Value.address);
                Console.WriteLine("City is       : " + item.Value.city);
                Console.WriteLine("State is      : " + item.Value.state);
                Console.WriteLine("Zip is        : " + item.Value.zip);
                Console.WriteLine("Phone Num is  : " + item.Value.phoneNumber);
                Console.WriteLine("E-Mail is     : " + item.Value.eMail);
            }
        }
    }
}
