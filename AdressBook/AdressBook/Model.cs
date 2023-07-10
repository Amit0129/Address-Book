using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AdressBook
{
    public class Model
    {
        public string firstName;
        public string lastName;
        public string address;
        public string city;
        public string state;
        public string zip;
        public string phoneNumber;
        public string eMail;
       
        public Model(string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber, string eMail) 
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNumber = phoneNumber;
            this.eMail = eMail;

        }
    }
}
