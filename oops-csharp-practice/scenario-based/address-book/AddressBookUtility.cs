//first and last names, address, city, state, zip, phone number and email...
using System;
using System.Diagnostics.Contracts;
class AddressBookUtility : IAddressBook
{
    ContactDetails [] contacts= new ContactDetails[10];
    int totalContacts=0;
    public void AddDetails()
    {
        if(totalContacts>=contacts.Length)
        {
            Console.WriteLine("Address book is full. Cannot add more contacts.");
            return;
        }
        Console.WriteLine("------------------------------------------");
        Console.Write("Enter first name: ");
        string firstName= Console.ReadLine();

        Console.Write("Enter last name: ");
        string lastName= Console.ReadLine();

        Console.Write("Enter address: ");
        string address= Console.ReadLine();

        Console.Write("Enter city: ");
        string city= Console.ReadLine();

        Console.Write("Enter state: ");
        string state= Console.ReadLine();

        Console.Write("Enter zip: ");
        string zip= Console.ReadLine();

        Console.Write("Enter phone number: ");
        string phoneNumber= Console.ReadLine();

        Console.Write("Enter e-mail: ");
        string email= Console.ReadLine();

        ContactDetails contact= new ContactDetails(
            firstName,
            lastName,
            address,
            city,
            state,
            zip,
            phoneNumber,
            email
        );

        contacts[totalContacts]= contact;
        totalContacts++;
        Console.WriteLine("\n-Contact added-");
        Console.WriteLine(contact.ToString());
        Console.WriteLine("------------------------------------------");

    }

    public void DisplayAll()
    {
        if(totalContacts==0)
        {
            Console.WriteLine("Address book is empty. Add contacts.");
            return;
        }
        Console.WriteLine("\n-Available contacts-");
        for(int i=0; i<totalContacts; i++)
        {
            Console.WriteLine((i+1)+". "+contacts[i].ToString());
        }
        Console.WriteLine("------------------------------------------");
    }
}