using System;
using System.Collections.Generic;

interface ILoanable{
	void ApplyForLoan();
	double CalculateLoanEligibility();
}

abstract class BankAccount{
	private string accountNumber;
	protected double balance;

	public BankAccount(string acc, double bal){
		this.accountNumber= acc;
		this.balance= bal;
	}

	public void Deposit(double amount){
		balance+= amount;
	}

	public abstract double CalculateInterest();
}

class SavingsAccount : BankAccount{
	public SavingsAccount(string acc, double bal)
		: base(acc, bal){}

	public override double CalculateInterest(){
		return balance * 0.04;
	}
}

class Program{
	static void Main(){
		List<BankAccount> accounts= new List<BankAccount>();
		accounts.Add(new SavingsAccount("SB101", 50000));
		accounts.Add(new SavingsAccount("SB102", 200000));

		foreach(BankAccount acc in accounts){
			Console.WriteLine("Interest: "+acc.CalculateInterest());
		}
	}
}
