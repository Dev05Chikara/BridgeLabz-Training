using System;
using System.Collections.Generic;

class AddressBookUtility : IAddressBook
{
    private List<ContactDetails> contacts = new List<ContactDetails>();

    private bool IsDuplicate(string firstName, string lastName)
    {
        for (int i = 0; i < contacts.Count; i++)
        {
            if (contacts[i].GetFirstName().Equals(firstName, StringComparison.OrdinalIgnoreCase) &&
                contacts[i].GetLastName().Equals(lastName, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
        }
        return false;
    }

    public void AddDetails()
    {
        Console.Write("How many contacts do you want to add? ");
        int count = int.Parse(Console.ReadLine());

        for (int k = 0; k < count; k++)
        {
            Console.WriteLine("\nEnter details for contact " + (k + 1));

            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter last name: ");
            string lastName = Console.ReadLine();

            if (IsDuplicate(firstName, lastName))
            {
                Console.WriteLine("Duplicate person not allowed.");
                continue;
            }

            Console.Write("Enter address: ");
            string address = Console.ReadLine();

            Console.Write("Enter city: ");
            string city = Console.ReadLine();

            Console.Write("Enter state: ");
            string state = Console.ReadLine();

            Console.Write("Enter zip: ");
            string zip = Console.ReadLine();

            Console.Write("Enter phone number: ");
            string phoneNumber = Console.ReadLine();

            Console.Write("Enter email: ");
            string email = Console.ReadLine();

            contacts.Add(new ContactDetails(
                firstName, lastName, address, city, state, zip, phoneNumber, email));

            Console.WriteLine("Contact added successfully.");
        }
    }

    public void DisplayAll()
    {
        if (contacts.Count == 0)
        {
            Console.WriteLine("Address book is empty.");
            return;
        }

        for (int i = 0; i < contacts.Count; i++)
        {
            Console.WriteLine((i + 1) + ". " + contacts[i]);
        }
    }

    public void EditContact()
    {
        Console.Write("Enter first name of contact to edit: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter last name of contact to edit: ");
        string lastName = Console.ReadLine();

        for (int i = 0; i < contacts.Count; i++)
        {
            if (contacts[i].GetFirstName().Equals(firstName, StringComparison.OrdinalIgnoreCase) &&
                contacts[i].GetLastName().Equals(lastName, StringComparison.OrdinalIgnoreCase))
            {
                Console.Write("Enter new last name: ");
                string newLastName = Console.ReadLine();

                if (!newLastName.Equals(lastName, StringComparison.OrdinalIgnoreCase) &&
                    IsDuplicate(firstName, newLastName))
                {
                    Console.WriteLine("Duplicate contact exists.");
                    return;
                }

                Console.Write("Enter new address: ");
                string address = Console.ReadLine();

                Console.Write("Enter new city: ");
                string city = Console.ReadLine();

                Console.Write("Enter new state: ");
                string state = Console.ReadLine();

                Console.Write("Enter new zip: ");
                string zip = Console.ReadLine();

                Console.Write("Enter new phone number: ");
                string phoneNumber = Console.ReadLine();

                Console.Write("Enter new email: ");
                string email = Console.ReadLine();

                contacts[i].UpdateDetails(
                    newLastName, address, city, state, zip, phoneNumber, email);

                Console.WriteLine("Contact updated successfully.");
                return;
            }
        }

        Console.WriteLine("Contact not found.");
    }

    public void DeleteContact()
    {
        Console.Write("Enter first name of contact to delete: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter last name of contact to delete: ");
        string lastName = Console.ReadLine();

        for (int i = 0; i < contacts.Count; i++)
        {
            if (contacts[i].GetFirstName().Equals(firstName, StringComparison.OrdinalIgnoreCase) &&
                contacts[i].GetLastName().Equals(lastName, StringComparison.OrdinalIgnoreCase))
            {
                contacts.RemoveAt(i);
                Console.WriteLine("Contact deleted successfully.");
                return;
            }
        }

        Console.WriteLine("Contact not found.");
    }

    public List<ContactDetails> GetContacts()
    {
        return contacts;
    }

    public void SortContactsByName()
    {
        for (int i = 0; i < contacts.Count - 1; i++)
        {
            for (int j = 0; j < contacts.Count - i - 1; j++)
            {
                string name1 = contacts[j].GetFirstName() + contacts[j].GetLastName();
                string name2 = contacts[j + 1].GetFirstName() + contacts[j + 1].GetLastName();

                if (string.Compare(name1, name2, true) > 0)
                {
                    ContactDetails temp = contacts[j];
                    contacts[j] = contacts[j + 1];
                    contacts[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Contacts sorted by Name.");
    }

    public void SortByCity()
    {
        for (int i = 0; i < contacts.Count - 1; i++)
        {
            for (int j = 0; j < contacts.Count - i - 1; j++)
            {
                if (string.Compare(contacts[j].GetCity(),
                                   contacts[j + 1].GetCity(), true) > 0)
                {
                    ContactDetails temp = contacts[j];
                    contacts[j] = contacts[j + 1];
                    contacts[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Contacts sorted by City.");
    }

    public void SortByState()
    {
        for (int i = 0; i < contacts.Count - 1; i++)
        {
            for (int j = 0; j < contacts.Count - i - 1; j++)
            {
                if (string.Compare(contacts[j].GetState(),
                                   contacts[j + 1].GetState(), true) > 0)
                {
                    ContactDetails temp = contacts[j];
                    contacts[j] = contacts[j + 1];
                    contacts[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Contacts sorted by State.");
    }

    public void SortByZip()
    {
        for (int i = 0; i < contacts.Count - 1; i++)
        {
            for (int j = 0; j < contacts.Count - i - 1; j++)
            {
                if (string.Compare(contacts[j].GetZip(),
                                   contacts[j + 1].GetZip(), true) > 0)
                {
                    ContactDetails temp = contacts[j];
                    contacts[j] = contacts[j + 1];
                    contacts[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Contacts sorted by Zip.");
    }
}
