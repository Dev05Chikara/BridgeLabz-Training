using System;
class AadharMain{
	static void Main(){
		Console.Write("Enter number of Aadhar entries: ");
		int n= Convert.ToInt32(Console.ReadLine());
		
		AadharUtility util= new AadharUtility(n);
		
		while(true){
			Console.WriteLine("\n1. Add Aadhar Number");
			Console.WriteLine("2. Sort Aadhar Numbers");
			Console.WriteLine("3. Search Aadhar Number");
			Console.WriteLine("4. Display All");
			Console.WriteLine("0. Exit");
			
			Console.Write("Enter choice: ");
			int choice= Convert.ToInt32(Console.ReadLine());
			
			switch(choice){
				case 1:
					Console.Write("Enter 12-digit Aadhar: ");
					util.AddAadhar(Convert.ToInt64(Console.ReadLine()));
					break;
					
				case 2:
					util.RadixSort();
					break;
					
				case 3:
					Console.Write("Enter Aadhar to search: ");
					long target= Convert.ToInt64(Console.ReadLine());
					int index= util.BinarySearch(target);
					
					if(index!=-1){
						Console.WriteLine("Aadhar found at index: "+index);
					}else{
						Console.WriteLine("Aadhar not found.");
					}
					break;
					
				case 4:
					util.DisplayAll();
					break;
					
				case 0:
					return;
					
				default:
					Console.WriteLine("Invalid choice.");
					break;
			}
		}
	}
}
