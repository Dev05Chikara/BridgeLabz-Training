using System;
class BookNode
{
    public string bookName;
    public string author;
    public BookNode next;

    public BookNode(string bookName, string author)
    {
        this.bookName=bookName;
        this.author=author;
        next=null;
    }
}