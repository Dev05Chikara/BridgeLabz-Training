abstract class JobRole{
	protected string roleName;
	
	public JobRole(string roleName){
		this.roleName= roleName;
	}
	
	public string GetRoleName(){
		return roleName;
	}
	
	public abstract int Evaluate();
}
