class Groceries : WarehouseItem{
	public Groceries(string name, int quantity) : base(name, quantity){}
	
	public override string GetCategory(){
		return "Groceries";
	}
}
