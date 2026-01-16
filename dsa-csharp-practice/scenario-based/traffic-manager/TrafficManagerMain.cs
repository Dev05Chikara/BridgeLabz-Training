using System;
class TrafficManagerMain{
	static void Main(){
		Roundabout roundabout= new Roundabout();
		VehicleQueue waitingQueue= new VehicleQueue();
        int choice;
		do{
			Console.WriteLine("\n1. Vehicle Enter City");
			Console.WriteLine("2. Vehicle Exit Roundabout");
			Console.WriteLine("3. Allow Vehicle from Queue");
			Console.WriteLine("4. Display Roundabout");
			Console.WriteLine("0. Exit");
			Console.Write("\nEnter choice: ");
			choice= Convert.ToInt32(Console.ReadLine());
			switch(choice){
				case 1:
					Console.Write("Enter vehicle number: ");
					waitingQueue.Enqueue(Console.ReadLine());
					break;
				case 2:
					Console.Write("Enter vehicle number to exit: ");
					roundabout.RemoveVehicle(Console.ReadLine());
					break;
				case 3:
					if(!waitingQueue.IsEmpty()){
						string vehicle= waitingQueue.Dequeue();
						if(vehicle!=null){
							roundabout.AddVehicle(vehicle);
						}
					}
					break;
				case 4:
					roundabout.DisplayRoundabout();
					break;
				case 0:
					Console.WriteLine("---Exiting---");
                    break;
				default:
					Console.WriteLine("---Invalid choice---");
					break;
			}
		}while(choice != 0);
	}
}
