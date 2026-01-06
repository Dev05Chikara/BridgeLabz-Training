using System;
class Program{
	static void Main(){
		Doctor doctor= new Doctor("Dr Sharma", "General Physician", 500);
		Patient patient= null;
		
		while(true){
			Console.WriteLine("\n--- Hospital Patient Management System ---");
			Console.WriteLine("1. Add InPatient");
			Console.WriteLine("2. Add OutPatient");
			Console.WriteLine("3. Display Patient Details");
			Console.WriteLine("4. Generate Bill");
			Console.WriteLine("5. Exit");
			Console.Write("Enter your choice: ");
			
			int choice= Convert.ToInt32(Console.ReadLine());
			
			if(choice==1){
				Console.Write("Enter ID: ");
				int id= Convert.ToInt32(Console.ReadLine());
				
				Console.Write("Enter Name: ");
				string name= Console.ReadLine();
				
				Console.Write("Enter Age: ");
				int age= Convert.ToInt32(Console.ReadLine());
				
				Console.Write("Enter Days Admitted: ");
				int days= Convert.ToInt32(Console.ReadLine());
				
				Console.Write("Enter Room Charge per Day: ");
				double charge= Convert.ToDouble(Console.ReadLine());
				
				patient= new InPatient(id, name, age, doctor, days, charge);
				Console.WriteLine("InPatient Added Successfully.");
			}
			
			else if(choice==2){
				Console.Write("Enter ID: ");
				int id= Convert.ToInt32(Console.ReadLine());
				
				Console.Write("Enter Name: ");
				string name= Console.ReadLine();
				
				Console.Write("Enter Age: ");
				int age= Convert.ToInt32(Console.ReadLine());
				
				patient= new OutPatient(id, name, age, doctor);
				Console.WriteLine("OutPatient Added Successfully.");
			}
			
			else if(choice==3){
				if(patient!=null){
					patient.DisplayInfo();
				}
				else{
					Console.WriteLine("No patient record found.");
				}
			}
			
			else if(choice==4){
				if(patient!=null && patient is IPayable){
					Bill.GenerateBill((IPayable)patient);
				}
				else{
					Console.WriteLine("No bill available.");
				}
			}
			
			else if(choice==5){
				Console.WriteLine("Exiting System...");
				break;
			}
			
			else{
				Console.WriteLine("Invalid Choice!");
			}
		}
	}
}
