using System;
class FlashDealzMain{
	static void Main(){
		Console.Write("Enter number of products: ");
		int size= Convert.ToInt32(Console.ReadLine());
		FlashDealzUtility deals= new FlashDealzUtility(size);
		while(true){
			Console.WriteLine("\n1. Add Product");
			Console.WriteLine("2. Sort by Discount");
			Console.WriteLine("3. Show Top Deals");
			Console.WriteLine("0. Exit");
			
			Console.Write("Enter choice: ");
			int choice= Convert.ToInt32(Console.ReadLine());
			
			switch(choice){
				case 1:
					Console.Write("Product name: ");
					string name= Console.ReadLine();
					Console.Write("Discount (%): ");
					int discount= Convert.ToInt32(Console.ReadLine());
					deals.AddProduct(name, discount);
					break;
					
				case 2:
					deals.SortByDiscount();
					break;
					
				case 3:
					Console.Write("How many top deals to show: ");
					int count= Convert.ToInt32(Console.ReadLine());
					deals.DisplayTopDeals(count);
					break;
					
				case 0:
                Console.WriteLine("Exiting...");
					return;
					
				default:
					Console.WriteLine("Invalid choice.");
					break;
			}
		}
	}
}
