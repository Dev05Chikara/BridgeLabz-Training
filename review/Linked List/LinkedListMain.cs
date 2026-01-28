using System;
class LinkedListMain
{
    static void Main()
    {
        CustomLinkedList myList= new CustomLinkedList();
        Console.WriteLine("------Welcome------");

        Console.Write("\nEnter the number of elements: ");
        int length= Convert.ToInt32(Console.ReadLine());

        for(int i=0; i<length; i++)
        {
            Console.Write("Enter element "+(i+1)+": ");
            int val= Convert.ToInt32(Console.ReadLine());
            myList.Add(val);
        }

        Console.Write("\nEnter N(node to remove from the end): ");
        int nNode= Convert.ToInt32(Console.ReadLine());

        Console.Write("\nOriginal Linked-List: ");
        myList.Display();

        myList.RemoveNthFromEnd(nNode);

        Console.Write("Nth-Removed Linked-List: ");
        myList.Display();


    }
}