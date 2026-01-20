using System;
class WarehouseMain{
	static void Main(){
		Storage<Electronics> electronicsStore= new Storage<Electronics>();
		electronicsStore.AddItem(new Electronics("Laptop", 10));
		electronicsStore.AddItem(new Electronics("Mobile", 25));
		electronicsStore.DisplayItems();
		
		Storage<Groceries> groceryStore= new Storage<Groceries>();
		groceryStore.AddItem(new Groceries("Rice", 50));
		groceryStore.AddItem(new Groceries("Wheat", 40));
		groceryStore.DisplayItems();
		
		Storage<Furniture> furnitureStore= new Storage<Furniture>();
		furnitureStore.AddItem(new Furniture("Chair", 15));
		furnitureStore.AddItem(new Furniture("Table", 5));
		furnitureStore.DisplayItems();
	}
}
