using System;

class AddressBookMenu
{
    public void Start()
    {
        AddressBookSystem system = new AddressBookSystem();
        AddressBookUtility book = null;

        int choice;
        do
        {
            Console.WriteLine("\n========= ADDRESS BOOK SYSTEM =========");
            Console.WriteLine("1. Add Address Book");
            Console.WriteLine("2. Display Address Books");
            Console.WriteLine("3. Select Address Book");
            Console.WriteLine("4. Search Person by City");
            Console.WriteLine("5. Search Person by State");
            Console.WriteLine("6. Count Contacts by City");
            Console.WriteLine("7. Count Contacts by State");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    system.AddAddressBook();
                    break;
                case 2:
                    system.DisplayAddressBooks();
                    break;
                case 3:
                    book = system.SelectAddressBook();
                    if (book != null)
                        ContactMenu(book);
                    break;
                case 4:
                    Console.Write("Enter City: ");
                    system.SearchByCityOrState(Console.ReadLine(), true);
                    break;
                case 5:
                    Console.Write("Enter State: ");
                    system.SearchByCityOrState(Console.ReadLine(), false);
                    break;
                case 6:
                    Console.Write("Enter City: ");
                    system.CountByCityOrState(Console.ReadLine(), true);
                    break;
                case 7:
                    Console.Write("Enter State: ");
                    system.CountByCityOrState(Console.ReadLine(), false);
                    break;
                case 0:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

        } while (choice != 0);
    }

    void ContactMenu(AddressBookUtility address)
    {
        int option;
        do
        {
            Console.WriteLine("\n----- ADDRESS BOOK MENU -----");
            Console.WriteLine("1. Add Contact(s)");
            Console.WriteLine("2. Display Contacts");
            Console.WriteLine("3. Edit Contact");
            Console.WriteLine("4. Delete Contact");
            Console.WriteLine("5. Sort by Name");
            Console.WriteLine("6. Sort by City");
            Console.WriteLine("7. Sort by State");
            Console.WriteLine("8. Sort by Zip");
            Console.WriteLine("9. Write to File");
            Console.WriteLine("10. Read from File");
            Console.WriteLine("0. Back");
            Console.Write("Enter your option: ");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    address.AddDetails();
                    break;
                case 2:
                    address.DisplayAll();
                    break;
                case 3:
                    address.EditContact();
                    break;
                case 4:
                    address.DeleteContact();
                    break;
                case 5:
                    address.SortContactsByName();
                    break;
                case 6:
                    address.SortByCity();
                    break;
                case 7:
                    address.SortByState();
                    break;
                case 8:
                    address.SortByZip();
                    break;
                case 9:
                    Console.Write("Enter file name (example: data.txt): ");
                    address.WriteToFile(Console.ReadLine());
                    break;
                case 10:
                    Console.Write("Enter file name to read: ");
                    address.ReadFromFile(Console.ReadLine());
                    break;
                case 0:
                    Console.WriteLine("Returning...");
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }

        } while (option != 0);
    }
}
