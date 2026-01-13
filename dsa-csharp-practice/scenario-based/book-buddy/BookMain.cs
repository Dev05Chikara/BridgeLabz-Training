using System;
class BookMain
{
    public static void Main(String[] args)
    {
        IBook book = new IBookImpl();
        book.addBook("Life of Apes","Nikolas Jackson");
        book.addBook("Mountain of Hell","Narendra Modi");
        book.addBook("I Robot","Dev Chikara");
        book.addBook("Rich Dad Poor Dad","Dev Chikara");
        book.addBook("Orbit of Earth","Newton");
        book.addBook("Electricities","Nikolas Jackson");


        book.searchByAuthor("Nikolas Jackson");
        book.sortBookByAlphabetically();
        book.Display();
    }
}