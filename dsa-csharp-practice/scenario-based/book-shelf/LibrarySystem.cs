using System;
class LibrarySystem
{
    private GenreShelf[] shelves= new GenreShelf[5];
    private int totalGenre=0;

    public void AddGenre(string genre)
    {
        if (totalGenre == shelves.Length)
        {
            Console.WriteLine("--- Genre-Shelf storage is full ---");
            return;
        }
        if(GetGenre(genre) != -1)
        {
            Console.WriteLine("--- This genre is already exist ---");
            return;
        }
        shelves[totalGenre++]= new GenreShelf(genre);
        Console.WriteLine("--- Genre added successfully ---"); 

    }

    public void AddBook(string genre, string bookName, string author)
    {
        int index= GetGenre(genre);
        if(index == -1)
        {
            Console.WriteLine("--- Genre not found ---");
            return;
        }
        shelves[index].AddBook(bookName, author);
    }

    public void RemoveBook(string genre, string bookName, string author)
    {
        int index=GetGenre(genre);
        if(index == -1)
        {
            Console.WriteLine("--- Genre not found ---");
            return;
        }
        shelves[index].RemoveBook(bookName, author);
    }

    private int GetGenre(string genre)
    {
        for(int i=0; i<totalGenre; i++)
        {
            if (shelves[i].genreName.Equals(genre))
            {
                return i;
            }
        }return -1;
    }
}