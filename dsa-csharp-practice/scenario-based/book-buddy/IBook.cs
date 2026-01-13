using System;
interface IBook
{
     void addBook(String Title, String Author);
     void searchByAuthor(String Author);

     void sortBookByAlphabetically();

     void Display();
}