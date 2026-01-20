abstract class WarehouseItem{
	internal string name;
	protected int quantity;
	
	public WarehouseItem(string name, int quantity){
		this.name= name;
		this.quantity= quantity;
	}
	
	public abstract string GetCategory();
	
	public string GetDetails(){
		return "Item: "+name+" | Qty: "+quantity+" | Category: "+GetCategory();
	}
}
