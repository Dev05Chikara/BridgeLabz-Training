abstract class Category{
	protected string categoryName;
	
	public Category(string categoryName){
		this.categoryName= categoryName;
	}
	
	public string GetCategoryName(){
		return categoryName;
	}
}
