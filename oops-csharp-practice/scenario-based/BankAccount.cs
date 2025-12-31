using System;
class BankAccount{
    public string AccountNumber;
    public double Balance;
	
    public BankAccount(string accNo, double initialBalance){
        AccountNumber = accNo;
        Balance = initialBalance;
    }

    public void Deposit(double amount){
        if (amount <= 0){
            Console.WriteLine("Invalid deposit amount.");
            return;
        }
        Balance = Balance + amount;
        Console.WriteLine("Deposit successful.");
    }

    public void Withdraw(double amount){
        if (amount <= 0){
            Console.WriteLine("Invalid withdrawal amount.");
            return;
        }
        if (amount > Balance){
            Console.WriteLine("Withdrawal failed! Insufficient balance.");
        }
        else{
            Balance = Balance - amount;
            Console.WriteLine("Withdrawal successful.");
        }
    }

    public void CheckBalance(){
        Console.WriteLine("Current Balance: " + Balance);
    }
}

class Program{
    static void Main(){
        Console.Write("Enter Account Number: ");
        string accNo=Console.ReadLine();

        BankAccount account=new BankAccount(accNo,2000); //Using Initial Balance as 2000...

        bool run=true;
        while(run){
            Console.WriteLine("\n1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Check Balance");
            Console.WriteLine("0. Exit");
            Console.Write("Choose option: ");
            int choice=int.Parse(Console.ReadLine());

            if(choice==1){
                Console.Write("Enter deposit amount: ");
                double amt=double.Parse(Console.ReadLine());
                account.Deposit(amt);
            }
            else if(choice==2){
                Console.Write("Enter withdrawal amount: ");
                double amt=double.Parse(Console.ReadLine());
                account.Withdraw(amt);
            }
            else if(choice==3){
                account.CheckBalance();
            }
            else if(choice==0){
                run=false;
                Console.WriteLine("Thank you!");
            }
            else{
                Console.WriteLine("Invalid choice.");
            }
        }
    }
}
