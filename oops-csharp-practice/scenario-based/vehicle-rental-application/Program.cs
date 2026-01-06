using System;
class Program{
	static void Main(){
		Vehicle vehicle= null;
		Customer customer= null;
		
		while(true){
			Console.WriteLine("\n--- Vehicle Rental Application ---");
			Console.WriteLine("1. Rent Bike");
			Console.WriteLine("2. Rent Car");
			Console.WriteLine("3. Rent Truck");
			Console.WriteLine("4. Display Rental Details");
			Console.WriteLine("5. Exit");
			Console.Write("Enter your choice: ");
			
			int choice= Convert.ToInt32(Console.ReadLine());
			
			if(choice>=1 && choice<=3){
				Console.Write("Enter Customer Name: ");
				string cname= Console.ReadLine();
				
				Console.Write("Enter Rental Days: ");
				int days= Convert.ToInt32(Console.ReadLine());
				
				customer= new Customer(cname, days);
				
				if(choice==1){
					vehicle= new Bike("BIKE101", "Honda", 300);
				}
				else if(choice==2){
					vehicle= new Car("CAR202", "Hyundai", 800);
				}
				else if(choice==3){
					vehicle= new Truck("TRUCK303", "Tata", 1500);
				}
				
				Console.WriteLine("Vehicle Rented Successfully.");
			}
			
			else if(choice==4){
				if(vehicle!=null && customer!=null){
					customer.DisplayCustomer();
					vehicle.DisplayInfo();
					
					if(vehicle is IRentable){
						double bill= ((IRentable)vehicle).CalculateRent(customer.days);
						Console.WriteLine("Total Rent Amount: "+bill);
					}
				}
				else{
					Console.WriteLine("No rental record found.");
				}
			}
			
			else if(choice==5){
				Console.WriteLine("Exiting Application...");
				break;
			}
			
			else{
				Console.WriteLine("Invalid Choice!");
			}
		}
	}
}
