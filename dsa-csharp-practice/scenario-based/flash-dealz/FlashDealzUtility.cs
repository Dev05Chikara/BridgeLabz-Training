using System;
class FlashDealzUtility{
	private Product[] products;
	private int totalProducts;
	
	public FlashDealzUtility(int size){
		products= new Product[size];
		totalProducts= 0;
	}
	
	public void AddProduct(string name, int discount){
		if(totalProducts==products.Length){
			Console.WriteLine("Product storage full.");
			return;
		}
		products[totalProducts++]= new Product(name, discount);
	}
	
	public void SortByDiscount(){
		QuickSort(0, totalProducts-1);
		Console.WriteLine("Products sorted by highest discount.");
	}

	private void QuickSort(int low, int high){
		if(low<high){
			int pivotIndex= Partition(low, high);
			QuickSort(low, pivotIndex-1);
			QuickSort(pivotIndex+1, high);
		}
	}
	
	private int Partition(int low, int high){
		int pivot= products[high].GetDiscount();
		int i= low-1;
		for(int j=low;j<high;j++){
			if(products[j].GetDiscount()>pivot){
				i++;
				Swap(i, j);
			}
		}
		Swap(i+1, high);
		return i+1;
	}
	
	private void Swap(int i, int j){
		Product temp= products[i];
		products[i]= products[j];
		products[j]= temp;
	}
	
	public void DisplayTopDeals(int count){
		if(totalProducts==0){
			Console.WriteLine("No products available.");
			return;
		}
		if(count>totalProducts){
			count= totalProducts;
		}
		Console.WriteLine("\n--- Top Discounted Products ---");
		for(int i=0;i<count;i++){
			Console.WriteLine((i+1)+". "+products[i].GetProductName()+" - "+products[i].GetDiscount()+"%");
		}
	}
}
