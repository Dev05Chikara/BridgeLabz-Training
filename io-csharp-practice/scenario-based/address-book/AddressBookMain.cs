using System;
class AddressBookMain
{
    static void Main()
    {
        Console.WriteLine("---------- Welcome to Address-Book ----------");
        AddressBookMenu menu= new AddressBookMenu();
        menu.Start();
    }    
}