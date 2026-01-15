//first and last names, address, city, state, zip, phone number and email...
using System;
class AddressBookUtility : IAddressBook
{
    public void AddDetails()
    {
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

        Console.WriteLine(contact.ToString());
        Console.WriteLine("------------------------------------------");

    }
}