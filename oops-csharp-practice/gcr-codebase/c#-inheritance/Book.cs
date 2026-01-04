using System;
class Book{
    protected string title;
    protected int year;

    public Book(string title, int year){
        this.title = title;
        this.year = year;
    }
}

class Author : Book{
    private string name;
    private string bio;

    public Author(string title, int year, string name, string bio)
        : base(title, year){
        this.name = name;
        this.bio = bio;
    }

    public void DisplayInfo(){
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Year: " + year);
        Console.WriteLine("Author: " + name);
        Console.WriteLine("Bio: " + bio);
    }
}

class Program{
    static void Main(){
        Author a = new Author("C# Basics", 2025, "Dev", "Software Developer");
        a.DisplayInfo();
    }
}
