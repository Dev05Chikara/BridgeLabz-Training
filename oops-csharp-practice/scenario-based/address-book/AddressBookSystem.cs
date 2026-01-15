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

    public void SearchByCityOrState(string value, bool searchByCity)
    {
        bool found = false;
        for (int i = 0; i < totalBooks; i++)
        {
            ContactDetails[] contacts = books[i].GetContacts();
            int count = books[i].GetTotalContacts();

            for (int j = 0; j < count; j++)
            {
                if ((searchByCity && contacts[j].GetCity().Equals(value, StringComparison.OrdinalIgnoreCase))
                 || (!searchByCity && contacts[j].GetState().Equals(value, StringComparison.OrdinalIgnoreCase)))
                {
                    Console.WriteLine("[" + bookNames[i] + "] " + contacts[j]);
                    found = true;
                }
            }
        }

        if (!found)
            Console.WriteLine("No matching records found.");
    }

    public void CountByCityOrState(string value, bool countByCity)
    {
        int totalCount = 0;
        for (int i = 0; i < totalBooks; i++)
        {
            ContactDetails[] contacts = books[i].GetContacts();
            int count = books[i].GetTotalContacts();

            for (int j = 0; j < count; j++)
            {
                if ((countByCity && contacts[j].GetCity().Equals(value, StringComparison.OrdinalIgnoreCase)) ||
                    (!countByCity && contacts[j].GetState().Equals(value, StringComparison.OrdinalIgnoreCase)))
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
