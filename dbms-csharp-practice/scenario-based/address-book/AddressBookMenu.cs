using System;

public class AddressBookMenu
{
    private DatabaseService db = new DatabaseService();

    public void Start()
    {
        while (true)
        {
            Console.WriteLine("\n===== ADDRESS BOOK MENU =====");
            Console.WriteLine("1. Create AddressBook");
            Console.WriteLine("2. Open AddressBook");
            Console.WriteLine("3. Show All AddressBooks");
            Console.WriteLine("4. Exit");

            Console.Write("Choose option: ");
            int choice = int.Parse(Console.ReadLine() ?? "0");

            switch (choice)
            {
                case 1:
                    Console.Write("Enter AddressBook name: ");
                    db.CreateAddressBook(Console.ReadLine() ?? "");
                    break;

                case 2:
                    OpenAddressBook();
                    break;

                case 3:
                    db.ShowAddressBooks();
                    break;

                case 4:
                    return;
            }
        }
    }

    private void OpenAddressBook()
    {
        Console.Write("Enter AddressBook name: ");
        string name = Console.ReadLine() ?? "";

        if (db.AddressBookExists(name))
        {
            Console.WriteLine("AddressBook opened successfully.");
            ContactMenu();
        }
        else
        {
            Console.WriteLine("AddressBook does not exist.");
        }
    }

    private void ContactMenu()
    {
        while (true)
        {
            Console.WriteLine("\n===== CONTACT MENU =====");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Show Contacts");
            Console.WriteLine("3. Update Contact");
            Console.WriteLine("4. Delete Contact");
            Console.WriteLine("5. Back to AddressBook Menu");

            Console.Write("Choose option: ");
            int choice = int.Parse(Console.ReadLine() ?? "0");

            switch (choice)
            {
                case 1:
                    AddContact();
                    break;

                case 2:
                    db.ShowContacts();
                    break;

                case 3:
                    Console.Write("Enter Contact ID: ");
                    int id = int.Parse(Console.ReadLine() ?? "0");
                    Console.Write("Enter new phone: ");
                    string phone = Console.ReadLine() ?? "";
                    db.UpdateContact(id, phone);
                    break;

                case 4:
                    Console.Write("Enter Contact ID: ");
                    db.DeleteContact(int.Parse(Console.ReadLine() ?? "0"));
                    break;

                case 5:
                    return;
            }
        }
    }

    private void AddContact()
    {
        try
        {
            Console.Write("First Name: ");
            string first = Console.ReadLine() ?? "";

            Console.Write("Last Name: ");
            string last = Console.ReadLine() ?? "";

            Console.Write("Address: ");
            string address = Console.ReadLine() ?? "";

            Console.Write("City: ");
            string city = Console.ReadLine() ?? "";

            Console.Write("State: ");
            string state = Console.ReadLine() ?? "";

            Console.Write("Zip: ");
            string zip = Console.ReadLine() ?? "";

            Console.Write("Phone: ");
            string phone = Console.ReadLine() ?? "";

            Console.Write("Email: ");
            string email = Console.ReadLine() ?? "";

            ContactDetails contact =
                new ContactDetails(first, last, address, city, state, zip, phone, email);

            db.AddContact(contact);
        }
        catch (InvalidContactException ex)
        {
            Console.WriteLine("Validation Error: " + ex.Message);
        }
    }
}
