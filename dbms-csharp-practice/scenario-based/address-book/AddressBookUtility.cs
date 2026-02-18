using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class AddressBookUtility : IAddressBook
{
    private List<ContactDetails> contacts = new List<ContactDetails>();

    private bool IsDuplicate(string firstName, string lastName)
    {
        for (int i = 0; i < contacts.Count; i++)
        {
            if (contacts[i].FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase) &&
                contacts[i].LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
        }
        return false;
    }

    public void AddDetails()
    {
        Console.Write("How many contacts do you want to add? ");

        int count;
        if (!int.TryParse(Console.ReadLine(), out count))
        {
            Console.WriteLine("Invalid number.");
            return;
        }

        for (int k = 0; k < count; k++)
        {
            try
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

                ContactDetails contact = new ContactDetails(
                    firstName, lastName, address,
                    city, state, zip, phoneNumber, email);

                contacts.Add(contact);

                Console.WriteLine("Contact added successfully.");
            }
            catch (InvalidContactException ex)
            {
                Console.WriteLine("Validation Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected Error: " + ex.Message);
            }
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
            Console.WriteLine((i + 1) + ". " + contacts[i].ToString());
        }
    }

    public void EditContact()
    {
        if (contacts.Count == 0)
        {
            Console.WriteLine("Address book is empty.");
            return;
        }

        Console.Write("Enter first name of contact to edit: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter last name of contact to edit: ");
        string lastName = Console.ReadLine();

        for (int i = 0; i < contacts.Count; i++)
        {
            if (contacts[i].FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase) &&
                contacts[i].LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase))
            {
                try
                {
                    Console.Write("Enter new last name: ");
                    string newLastName = Console.ReadLine();

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

                    contacts[i] = new ContactDetails(
                        contacts[i].FirstName,
                        newLastName,
                        address,
                        city,
                        state,
                        zip,
                        phoneNumber,
                        email);

                    Console.WriteLine("Contact updated successfully.");
                }
                catch (InvalidContactException ex)
                {
                    Console.WriteLine("Validation Error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Unexpected Error: " + ex.Message);
                }

                return;
            }
        }

        Console.WriteLine("Contact not found.");
    }

    public void DeleteContact()
    {
        if (contacts.Count == 0)
        {
            Console.WriteLine("Address book is empty.");
            return;
        }

        Console.Write("Enter first name of contact to delete: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter last name of contact to delete: ");
        string lastName = Console.ReadLine();

        for (int i = 0; i < contacts.Count; i++)
        {
            if (contacts[i].FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase) &&
                contacts[i].LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase))
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
                string name1 = contacts[j].FirstName + contacts[j].LastName;
                string name2 = contacts[j + 1].FirstName + contacts[j + 1].LastName;

                if (string.Compare(name1, name2, StringComparison.OrdinalIgnoreCase) > 0)
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
                if (string.Compare(contacts[j].City,
                                   contacts[j + 1].City,
                                   StringComparison.OrdinalIgnoreCase) > 0)
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
                if (string.Compare(contacts[j].State,
                                   contacts[j + 1].State,
                                   StringComparison.OrdinalIgnoreCase) > 0)
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
                if (string.Compare(contacts[j].Zip,
                                   contacts[j + 1].Zip,
                                   StringComparison.OrdinalIgnoreCase) > 0)
                {
                    ContactDetails temp = contacts[j];
                    contacts[j] = contacts[j + 1];
                    contacts[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Contacts sorted by Zip.");
    }

    public void SaveData(IAddressBookStorage storage, string source)
    {
        storage.Save(contacts, source);
        Console.WriteLine("Data saved successfully.");
    }

    public void LoadData(IAddressBookStorage storage, string source)
    {
        contacts = storage.Load(source);
        Console.WriteLine("Data loaded successfully.");
    }


}
