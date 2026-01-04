using System;
class BankAccount{
	public static string bankName= "Lena-Dena Bank";
	private static int totalAccounts= 0;
	
	public readonly string AccountNumber;
	private string AccountHolderName;
	
	public BankAccount(string AccountHolderName, string AccountNumber){
		this.AccountHolderName= AccountHolderName;
		this.AccountNumber= AccountNumber;
		totalAccounts++;
	}
	
	public void DisplayDetails(){
		Console.WriteLine("\nAccount Details:");
		Console.WriteLine("Bank: "+bankName);
		Console.WriteLine("Holder: "+AccountHolderName);
		Console.WriteLine("Account No: "+AccountNumber);
	}
	
	public static void GetTotalAccounts(){
		Console.WriteLine("\nTotal Accounts: "+totalAccounts);
	}
}
class Program{
	static void Main(){
		object acc= new BankAccount("Dev Chikara", "ACC101");
		
		if(acc is BankAccount){
			BankAccount a1= (BankAccount)acc;
			a1.DisplayDetails();
		}
		
		BankAccount.GetTotalAccounts();
	}
}
