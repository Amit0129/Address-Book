namespace AdressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            AddressBookBuilder addressBook = new AddressBookBuilder();
            int option;
            do
            {
                Console.WriteLine("Choose 1: To Add a Contact");
                Console.WriteLine("Choose 2: To get Contacts");
                Console.WriteLine("Choose 3: To Edit a contact");
                Console.WriteLine("Choose 4: To Delete a Contact");
                Console.WriteLine("Choose 0: To Exit");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 0:
                        Console.WriteLine("Thank You");
                        break;
                    case 1:
                        addressBook.AddContact();
                        continue;
                    case 2:
                        addressBook.GetContact();
                        continue;
                    case 3:
                        Console.WriteLine("Enter first name");
                        string key = Console.ReadLine();
                        addressBook.EditContacts(key);
                        break;
                    case 4:
                        addressBook.DeleteContacts();
                        break;
                    default:
                        Console.WriteLine("Choose valid Option");
                        break;
                }

            } while (option != 0);
        }
    }
}
