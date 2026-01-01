using System;
class Cafeteria{
	public void VeggyCafeteria(){
		Console.WriteLine("=====X===== Welcome to Veggy-Cafeteria =====X=====");
		Console.WriteLine("\n...Today's Menu...");
		string[] menuItems = {
			"Veg Sandwich",
			"Cheese Burger",
			"Paneer Wrap",
			"French Fries",
			"Veg Roll",
			"Masala Dosa",
			"Pav Bhaji",
			"Veg Paratha",
			"Cold Coffee",
			"Chocolate Ice Cream"
		};
		for(int i=0; i<menuItems.Length; i++) Console.WriteLine((i+1)+". "+menuItems[i]);
		Order(menuItems);
	}
	
	public void Order(string[] menuItems){
		string[] orderedItems = new string[menuItems.Length];
		int count = 0;
		char choice;
		do{
			Console.Write("\nEnter item number to order: ");
			int itemNo = Convert.ToInt32(Console.ReadLine());
			if(itemNo < 1 || itemNo > menuItems.Length) Console.WriteLine("Invalid choice! Please select a valid item number.");
			else{
				Console.WriteLine("You have ordered: " + menuItems[itemNo-1]);
				orderedItems[count] = menuItems[itemNo-1];
				count++;
			}
			Console.Write("\nDo you want to order anything else? (Y/N): ");
			choice = Convert.ToChar(Console.ReadLine());
		}while(choice == 'Y' || choice == 'y');
		Console.WriteLine("\n===== Your Order Summary =====");
		for(int i=0; i<count; i++) Console.WriteLine((i+1)+". "+orderedItems[i]);
		Console.WriteLine("\nThank you for ordering from Veggy-Cafeteria!");
	}
}

class Program{
	static void Main(){
		Cafeteria cafeteria= new Cafeteria();
		cafeteria.VeggyCafeteria();
	}
}
