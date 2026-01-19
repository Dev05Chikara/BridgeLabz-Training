using System;
class ParcelUtility
{
    private ParcelNode head;
    
    public ParcelUtility()
    {
        head= new ParcelNode("Packed");
        head.next= new ParcelNode("Shipped");
        head.next.next= new ParcelNode("In transit");
        head.next.next.next= new ParcelNode("Delivered");
    }

    public void DisplayTracking()
    {
        if (head == null)
        {
            Console.WriteLine("Parcel is lost! tracking unavailable.");
            return;
        }
        Console.WriteLine("\nParcel tracking Status:");
        ParcelNode temp=head;
        while (temp != null)
        {
            Console.Write("-> "+temp.parcelStage);
            temp=temp.next;
        }Console.WriteLine();
    }

    public void AddCheckpoint(string oldStage, string newStage)
    {
        if (head == null)
        {
            Console.WriteLine("Parcel is lost! Can't add checkpoint.");
            return;
        }
        ParcelNode temp= head;
        while (temp != null)
        {
            if (temp.parcelStage.Equals(oldStage))
            {
                ParcelNode newNode= new ParcelNode(newStage);
                newNode.next= temp.next;
                temp.next= newNode;

                Console.WriteLine("Checkpoint added successfully.");
                return;
            }
            temp=temp.next;
        }Console.WriteLine("Can't add! Stage not found.");
    }

    public void MarkParcelLost()
    {
        head=null;
        Console.WriteLine("Parcel marked lost.");
    }
}