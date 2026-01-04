using System;
class BankAccount{
	public string accountNumber;
	protected string accountHolder;
	private int balance;
	
	public BankAccount(string accountNumber, string accountHolder, int balance){
		this.accountNumber= accountNumber;
		this.accountHolder= accountHolder;
		this.balance= balance;
	}
	
	public void Deposit(int amount){
		balance+= amount;
	}
	
	public void GetBalance(){
		Console.WriteLine("Balance: "+balance);
	}
}
class SavingsAccount: BankAccount{
	public SavingsAccount(string accountNumber, string accountHolder, int balance)
		: base(accountNumber, accountHolder, balance){
	}
	
	public void DisplayAccountInfo(){
		Console.WriteLine("Account Number: "+accountNumber);
		Console.WriteLine("Account Holder: "+accountHolder);
	}
}
class Program{
	static void Main(){
		SavingsAccount acc= new SavingsAccount("ACC101", "Dev Chikara", 5000);
		acc.DisplayAccountInfo();
		acc.GetBalance();
	}
}
