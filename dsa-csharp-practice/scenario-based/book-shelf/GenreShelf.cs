using System;
class GenreShelf
{
    public string genreName;
    private BookNode head;

    public GenreShelf(string genreName)
    {
        this.genreName=genreName;
        head= null;
    }

    public void AddBook(string bookName, string author)
    {
        BookNode newBook= new BookNode(bookName, author);
        if (head == null)
        {
            head= newBook;
        }
        else
        {
            BookNode temp= head;
            while(temp.next != null)
            {
                temp=temp.next;
            }
            temp.next=newBook;
        }
        Console.WriteLine("--- Book added ---");
    }

    public void RemoveBook(string bookname, string author)
    {
        if (head == null)
        {
            Console.WriteLine("--- Genre Shelf is empty ---");
            return;
        }
        if(head.bookName.Equals(bookname) && head.author.Equals(author))
        {
            head=head.next;
            Console.WriteLine("--- Book removed ---");
            return;
        }

        BookNode prev= head;
        BookNode curr=head.next;

        while(curr != null)
        {
            if(curr.bookName.Equals(bookname) && curr.author.Equals(author))
            {
                prev.next=curr.next;
                Console.WriteLine("--- Book removed ---");
                return;
            }
            prev=curr;
            curr=curr.next;
        }
        Console.WriteLine("--- Book not found ---");
    }
}