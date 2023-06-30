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
                
                Console.WriteLine("Enter 1 for Adding contact to Address book");
                Console.WriteLine("Enter 2 for Disply contact in Address book");
                Console.WriteLine("Enter 3 for Edit contact in Address book");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        addressBookBuilder.Add_AddressBook();
                        break;
                    case 2:
                        addressBookBuilder.AddressDisplay();
                        break;
                    case 3:
                        addressBookBuilder.EditContact();
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