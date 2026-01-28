using System;
class LibraryUtility : ILibrary
{
    string[] title= new string[10];
    string[] author= new string[10];
    string[] status= new string[10];
    int totalBooks=0;
    public void AddBook()
    {
        if(totalBooks == 10)
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Sorry! Storage is full.");
            return;
        }
        Console.WriteLine("--------------------------------------");
        Console.Write("Enter the title: ");
        string titleOfBook= Console.ReadLine();
        title[totalBooks]= titleOfBook;

        Console.Write("Enter the author: ");
        string authorOfBook= Console.ReadLine();
        author[totalBooks]= authorOfBook; 

        Console.Write("Enter the status: ");
        string statusOfBook= Console.ReadLine();
        status[totalBooks]= statusOfBook;

        Console.WriteLine("--------------------------------------");
         Console.WriteLine("Book is added Successfully\nTitle: '"+title[totalBooks]+"'\nAuthor: '"+author[totalBooks]+"'\nStatus: '"+status[totalBooks]+"'");

        totalBooks++;
    }
    public void SearchBook()
    {
        if(totalBooks == 0)
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("No book available. Add the book first!");
            return;
        }
        Console.WriteLine("--------------------------------------");
        Console.Write("Enter the title: ");
        string searchedBook= Console.ReadLine();
        bool gotBook= false;
        for(int i=0; i<totalBooks; i++)
        {
            if (title[i].ToLower().Contains(searchedBook.ToLower()))
            {
                Console.WriteLine("Got your Book: "+title[i]);
                gotBook= true;
            }
        }
        Console.WriteLine("--------------------------------------");
        if (!gotBook)
        {
            Console.WriteLine("Sorry! Book not found.");
            Console.WriteLine("--------------------------------------");
        }
    }
    public void CheckoutBook()
    {
        if(totalBooks == 0)
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("No book available.");
            return;
        }
        Console.WriteLine("--------------------------------------");
        Console.Write("Which book you wanna borrow?: ");
        string borrowBook= Console.ReadLine();
        int foundBook= -1;
        for(int i=0; i<totalBooks; i++)
        {
            if (title[i].ToLower() == borrowBook.ToLower())
            {
                Console.WriteLine("Got your Book!");
                foundBook= i;
                if(status[i] == "Available")
                {
                    Console.WriteLine("Book '"+title[i]+"' is successfully borrowed to you.");
                    Console.WriteLine("--------------------------------------");
                    status[i]= "Checkout";
                }
                else
                {
                    Console.WriteLine("Sorry! Book '"+title[i]+"' is already borrowed.");
                    Console.WriteLine("--------------------------------------");
                }
            }
            else
            {
                Console.WriteLine("Sorry! Book not found.");
            }
        }
        Console.Write("Wanna borrow another book?(y/n): ");
        string borrowAnother= Console.ReadLine();
        if(borrowAnother == "y")
        {
            CheckoutBook();
        }
    }
    public void DisplayBooks()
    {
        if(totalBooks == 0)
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("No book available");
            return;
        }
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Available Books: ");
        for(int i=0; i<totalBooks; i++)
        {
            Console.WriteLine("\t"+(i+1)+". Title: '"+title[i]+"'\n\tAuthor: '"+author[i]+"'\n\tStatus: '"+status[i]+"'\n");
        }
        Console.WriteLine("--------------------------------------");
    }
}