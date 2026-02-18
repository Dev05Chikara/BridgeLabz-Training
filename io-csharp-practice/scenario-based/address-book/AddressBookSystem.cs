using System;
using System.Collections.Generic;

class AddressBookSystem
{
    private Dictionary<string, AddressBookUtility> addressBooks =
        new Dictionary<string, AddressBookUtility>();

    public void AddAddressBook()
    {
        Console.Write("Enter Address Book Name: ");
        string name = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Invalid Address Book name.");
            return;
        }

        if (addressBooks.ContainsKey(name))
        {
            Console.WriteLine("Address Book already exists.");
            return;
        }

        addressBooks.Add(name, new AddressBookUtility());
        Console.WriteLine("Address Book '" + name + "' created successfully.");
    }

    public AddressBookUtility SelectAddressBook()
    {
        if (addressBooks.Count == 0)
        {
            Console.WriteLine("No Address Books available.");
            return null;
        }

        Console.Write("Enter Address Book Name: ");
        string name = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Invalid name.");
            return null;
        }

        if (addressBooks.ContainsKey(name))
        {
            return addressBooks[name];
        }

        Console.WriteLine("Address Book not found.");
        return null;
    }

    public void DisplayAddressBooks()
    {
        if (addressBooks.Count == 0)
        {
            Console.WriteLine("No Address Books created yet.");
            return;
        }

        Console.WriteLine("\nAvailable Address Books:");
        foreach (string key in addressBooks.Keys)
        {
            Console.WriteLine("- " + key);
        }
    }

    public void SearchByCityOrState(string value, bool searchByCity)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            Console.WriteLine("Invalid search value.");
            return;
        }

        bool found = false;

        foreach (var entry in addressBooks)
        {
            List<ContactDetails> contacts = entry.Value.GetContacts();

            for (int i = 0; i < contacts.Count; i++)
            {
                if ((searchByCity &&
                     contacts[i].City.Equals(value, StringComparison.OrdinalIgnoreCase))
                    ||
                    (!searchByCity &&
                     contacts[i].State.Equals(value, StringComparison.OrdinalIgnoreCase)))
                {
                    Console.WriteLine("[" + entry.Key + "] " + contacts[i].ToString());
                    found = true;
                }
            }
        }

        if (!found)
        {
            Console.WriteLine("No matching records found.");
        }
    }

    public void CountByCityOrState(string value, bool countByCity)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            Console.WriteLine("Invalid value.");
            return;
        }

        int totalCount = 0;

        foreach (var entry in addressBooks)
        {
            List<ContactDetails> contacts = entry.Value.GetContacts();

            for (int i = 0; i < contacts.Count; i++)
            {
                if ((countByCity &&
                     contacts[i].City.Equals(value, StringComparison.OrdinalIgnoreCase))
                    ||
                    (!countByCity &&
                     contacts[i].State.Equals(value, StringComparison.OrdinalIgnoreCase)))
                {
                    totalCount++;
                }
            }
        }

        if (countByCity)
            Console.WriteLine("Total contacts in city '" + value + "': " + totalCount);
        else
            Console.WriteLine("Total contacts in state '" + value + "': " + totalCount);
    }
}
