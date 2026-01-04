using System;
class BankAccount{
    protected int accountNumber;
    protected double balance;

    public BankAccount(int accNo, double balance){
        accountNumber = accNo;
        this.balance = balance;
    }
}

class SavingsAccount : BankAccount{
    private double interestRate;

    public SavingsAccount(int accNo, double bal, double rate)
        : base(accNo, bal){
        interestRate = rate;
    }

    public void DisplayAccountType(){
        Console.WriteLine("Savings Account");
    }
}

class CheckingAccount : BankAccount{
    private int withdrawalLimit;

    public CheckingAccount(int accNo, double bal, int limit)
        : base(accNo, bal){
        withdrawalLimit = limit;
    }

    public void DisplayAccountType(){
        Console.WriteLine("Checking Account");
    }
}

class Program{
    static void Main(){
        SavingsAccount s = new SavingsAccount(101, 50000, 4.5);
        CheckingAccount c = new CheckingAccount(102, 30000, 5);

        s.DisplayAccountType();
        c.DisplayAccountType();
    }
}
