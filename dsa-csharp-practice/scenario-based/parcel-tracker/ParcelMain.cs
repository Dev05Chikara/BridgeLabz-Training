using System;
class ParcelMain
{
    static void Main()
    {
        Console.Write("--- Track your Parcel ---");
        ParcelUtility parcel= new ParcelUtility();
        int choice;
        do
        {
            Console.WriteLine("\n1. View Parcel Tracking");
            Console.WriteLine("2. Add Checkpoint");
            Console.WriteLine("3. Mark parcel as Lost");
            Console.WriteLine("0. Exit");

            Console.Write("Enter your choice: ");
            choice= int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    parcel.DisplayTracking();
                    break;
                
                case 2:
                    Console.Write("Enter old Stage: ");
                    string oldStage= Console.ReadLine();

                    Console.Write("Enter new Stage: ");
                    string newStage= Console.ReadLine();

                    parcel.AddCheckpoint(oldStage, newStage);
                    break;

                case 3:
                    parcel.MarkParcelLost();
                    break;

                case 0:
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid Choice!");
                    break;
            }
        }while(choice!=0);
    }
}