using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressBook
{
    public class AddressBookBuilder
    {
        Dictionary<string, Model> addressBook = new Dictionary<string, Model>();

        public void Add_AddressBook()
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
            Model model = new Model(firstName, lastName, address, city, state, zip, phoneNumber, eMail);
            addressBook.Add(firstName, model);
        }
        public void EditContact()
        {
            Console.WriteLine("Enter the name of the person you want to change");
            string name = Console.ReadLine();
            foreach (var item in addressBook)
            {
                if (item.Key == name)
                {
                    Console.WriteLine("Choose The Option :\n 1) First Name\n 2) last name\n 3) for adress\n 4) for city\n 5) for state\n 6) for zip\n 7) for phone number\n 8) for email ");
                    int change = Convert.ToInt32(Console.ReadLine());

                    switch (change)
                    {
                        case 1:
                            Console.WriteLine("Enter the first name");
                            item.Value.firstName = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Enter the last name");
                            item.Value.lastName = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Enter the address");
                            item.Value.address = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Enter the city");
                            item.Value.city = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Enter the state");
                            item.Value.state = Console.ReadLine();
                            break;
                        case 6:
                            Console.WriteLine("Enter the zip");
                            item.Value.zip = Console.ReadLine();
                            break;
                        case 7:
                            Console.WriteLine("Enter the phone number");
                            item.Value.phoneNumber = Console.ReadLine();
                            break;
                        case 8:
                            Console.WriteLine("Enter the email");
                            item.Value.eMail = Console.ReadLine();
                            break;

                    }
                }
            }
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
        public void DeleteContact()
        {
            Console.WriteLine("Enter the name of the person you want to change");
            string name = Console.ReadLine();
            foreach (var item in addressBook)
            {
                if (item.Key == name)
                {
                    addressBook.Remove(item.Key);
                }
            }
        }
    }
}