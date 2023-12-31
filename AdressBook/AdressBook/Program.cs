﻿namespace AdressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            do
            {
                Console.WriteLine("Choose 1: Work contacts");
                Console.WriteLine("Choose 2: Family contacts");
                Console.WriteLine("Choose 0: Exit");

                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        var work = new WorkContacts();
                        int option = 0;
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
                                case 1:
                                    work.AddContact();

                                    continue;
                                case 2:
                                    work.GetContact();
                                    continue;
                                case 3:
                                    Console.WriteLine("Enter first name");
                                    string key = Console.ReadLine();
                                    work.EditContacts(key);
                                    break;
                                case 4:
                                    work.DeleteContacts();
                                    break;
                                case 0:
                                    Console.WriteLine("Good Day");
                                    break;
                                default:
                                    Console.WriteLine("Choose valid Option");
                                    break;
                            }


                        } while (option != 0);
                        break;
                    case 2:
                        var familyContacts = new FamilyContacts();
                        int options = 0;
                        do
                        {
                            Console.WriteLine("Choose 1: To Add a Contact");
                            Console.WriteLine("Choose 2: To get Contacts");
                            Console.WriteLine("Choose 3: To Edit a contact");
                            Console.WriteLine("Choose 4: To Delete a Contact");
                            Console.WriteLine("Choose 0: To Exit");

                            options = int.Parse(Console.ReadLine());
                            switch (options)
                            {
                                case 1:
                                    familyContacts.AddContact();
                                    continue;
                                case 2:
                                    familyContacts.GetContact();
                                    continue;
                                case 3:
                                    Console.WriteLine("Enter first name");
                                    string key = Console.ReadLine();
                                    familyContacts.EditContacts(key);
                                    break;
                                case 4:
                                    familyContacts.DeleteContacts();
                                    break;
                                case 0:
                                    Console.WriteLine("Good Day");
                                    break;
                                default:
                                    Console.WriteLine("Choose valid Option");
                                    break;
                            }


                        } while (options != 0);
                        break;
                }
            } while (input != 0);
        }
    }
}