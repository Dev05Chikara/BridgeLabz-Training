class Furniture : WarehouseItem{
	public Furniture(string name, int quantity) : base(name, quantity){}
	
	public override string GetCategory(){
		return "Furniture";
	}
}
