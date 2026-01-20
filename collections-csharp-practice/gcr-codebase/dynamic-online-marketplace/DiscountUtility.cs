using System;
class DiscountUtility{
	public static void ApplyDiscount<TCategory>(
		Product<TCategory> product,
		double percentage
	)
		where TCategory : Category{
		
		double discount= product.GetPrice()*percentage/100;
		product.SetPrice(product.GetPrice()-discount);
		
		Console.WriteLine("Discount Applied: "+percentage+"%");
	}
}
