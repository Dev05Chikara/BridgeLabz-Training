using System;
using System.Collections.Generic;

class IBookImpl : IBook
{
    List<string> books = new List<String>();
    Dictionary<string,List<int>> dict = new Dictionary<string, List<int>>();

    public void addBook(string title, string author)
    {
        String book = title + "-" + author;
        books.Add(book);
        Console.WriteLine("Book '"+book+"' added successfully.");
        if (!dict.ContainsKey(author))
            dict[author] = new List<int>();

        dict[author].Add(books.Count - 1);

    }

    public void searchByAuthor(String author)
    {
        if (dict.ContainsKey(author))
        {
            List<int> indexes = dict[author];
            int size = indexes.Count;
            Console.WriteLine("\nFollowing(s) are the book of "+author+":");
            for(int i = 0; i < size; i++)
            {
                   Console.WriteLine(books[indexes[i]]);
            }
        } 

        else throw new Exception("No book Find");
    } 

    public void swap(int i, int j, List<string> books)
    {
        string s = books[i];
        books[i] = books[j];
        books[j]  = s;
    }

    public void sortBookByAlphabetically()
    {
        for(int i = 0; i < books.Count; i++)
        {
            for(int j = i + 1; j < books.Count; j++)
            {
                string bookITitle = books[i].Split('-')[0];
                string bookJTitle = books[j].Split('-')[0];
                int a = string.Compare(bookITitle , bookJTitle , true);
                if(a > 0) swap(i , j , books);
            }
        }
    }

    public void Display()
    {
        int size = books.Count;
        Console.WriteLine("\nBook List in Alphabetical order:");
        for(int i = 0; i < size; i++)
        {
            System.Console.WriteLine(books[i]);
        }
    }
}