using System;
class AddressBookSystem
{
    string[] bookNames= new string[5];
    AddressBookUtility[] books= new AddressBookUtility[5];
    int totalBooks= 0;

    public void AddAddressBook()
    {
        if(totalBooks>=books.Length){
            Console.WriteLine("Address Book limit reached.");
            return;
        }

        Console.Write("Enter Address Book Name: ");
        string name= Console.ReadLine();

        for(int i=0;i<totalBooks;i++){
            if(bookNames[i].Equals(name)){
                Console.WriteLine("Address Book already exists.");
                return;
            }
        }

        bookNames[totalBooks]= name;
        books[totalBooks]= new AddressBookUtility();
        totalBooks++;

        Console.WriteLine("Address Book '"+name+"' created successfully.");
    }

    public AddressBookUtility SelectAddressBook()
    {
        if(totalBooks==0){
            Console.WriteLine("No Address Books available.");
            return null;
        }

        Console.Write("Enter Address Book Name: ");
        string name= Console.ReadLine();

        for(int i=0;i<totalBooks;i++){
            if(bookNames[i].Equals(name)){
                return books[i];
            }
        }

        Console.WriteLine("Address Book not found.");
        return null;
    }

    public void DisplayAddressBooks()
    {
        if(totalBooks==0){
            Console.WriteLine("No Address Books created yet.");
            return;
        }

        Console.WriteLine("\nAvailable Address Books:");
        for(int i=0;i<totalBooks;i++){
            Console.WriteLine((i+1)+". "+bookNames[i]);
        }
    }
}
