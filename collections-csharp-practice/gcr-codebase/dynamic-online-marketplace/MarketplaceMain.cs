using System;
class MarketplaceMain{
	static void Main(){
		
		Product<BookCategory> book1= new Product<BookCategory>("C# Mastery", 500, new BookCategory());
		
		Product<ClothingCategory> cloth1= new Product<ClothingCategory>("Winter Jacket", 2000, new ClothingCategory());
		
		book1.Display();
		DiscountUtility.ApplyDiscount(book1, 10);
		book1.Display();
		
		Console.WriteLine();
		
		cloth1.Display();
		DiscountUtility.ApplyDiscount(cloth1, 20);
		cloth1.Display();
	}
}
