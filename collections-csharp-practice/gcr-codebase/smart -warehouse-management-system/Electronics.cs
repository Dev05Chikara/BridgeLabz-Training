class Electronics : WarehouseItem{
	public Electronics(string name, int quantity) : base(name, quantity){}
	
	public override string GetCategory(){
		return "Electronics";
	}
}
