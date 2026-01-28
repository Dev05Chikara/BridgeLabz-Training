using System;
class CustomLinkedList
{
   Node head;

   public void Add(int data)
    {
        Node newNode= new Node(data);
        if (head == null)
        {
            head= newNode;
            return;
        }
        Node temp= head;
        while(temp.next != null)
        {
            temp=temp.next;
        }
        temp.next= newNode;
    } 

    public void RemoveNthFromEnd(int nNode)
    {
        Node temp= new Node(0);
        temp.next= head;

        Node demo1= temp;
        Node demo2= temp;

        for(int i=0; i<nNode; i++)
        {
            if(demo1.next == null)
            {
                Console.WriteLine("\n!! Invalid n value !!\n");
                return;
            }
            demo1=demo1.next;
        }

        while (demo1.next != null)
        {
            demo1=demo1.next;
            demo2=demo2.next;
        }

        demo2.next=demo2.next.next;
        head= temp.next;
    }

    public void Display()
    {
        Node temp= head;
        while(temp != null)
        {
            Console.Write(temp.data+" -> ");
            temp=temp.next;
        }
        Console.WriteLine("null");
    }
}