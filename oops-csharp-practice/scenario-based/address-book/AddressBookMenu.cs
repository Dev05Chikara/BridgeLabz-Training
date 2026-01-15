using System;

class AddressBookMenu
{
    public void Start()
    {
        IAddressBook address= new AddressBookUtility();
        Console.WriteLine("\n---------- Select the function ----------");
        Console.WriteLine("1. Add Details");
        Console.WriteLine("2. Exit");
        Console.Write("Enter your choice: ");
        int choice= int.Parse(Console.ReadLine());
        switch(choice){
            case 1:
                address.AddDetails();
                break;
            case 2:
                Console.WriteLine("Thanks for Visiting!");
                Console.WriteLine("------------------------------------------");
                break;
        }
    }
}