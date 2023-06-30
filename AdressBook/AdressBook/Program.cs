namespace AdressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");

            AddressBookBuilder addressBookBuilder = new AddressBookBuilder();
            bool check = true;
            while (check)
            {
                
                Console.WriteLine("Enter 1 for adding contact to Address book");
                Console.WriteLine("Enter 2 for Disply contact in Address book");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
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

                        addressBookBuilder.Add_AddressBook(firstName, lastName, address, city, state, zip, phoneNumber, eMail);
                        //addressBookBuilder.AddressDisplay();
                        break;
                    case 2:
                        addressBookBuilder.AddressDisplay();
                        break;
                    default:
                        Console.WriteLine("Enter a valid choice");
                        break;
                }
                Console.WriteLine("Enter y if you want to do Some more operation");
                string continueOrNot = Console.ReadLine().ToLower();
                if (continueOrNot == "y")
                {
                    check = true;
                }
                else
                {
                    check = false;
                }   
            }
        }
    }
}