using System;
class Invoice{
	public string[] ParseInvoice(string input){
		string[] tasks= input.Split(',');
		return tasks;
	}
	
	public int GetTotalAmount(string[] tasks){
        int total = 0;
        for (int i = 0; i < tasks.Length; i++){
            string task = tasks[i];
            string[] parts = task.Split('-');
            if (parts.Length == 2){
                string amountPart = parts[1];
                string numberStr = "";
                for (int j = 0; j < amountPart.Length; j++){
                    char ch = amountPart[j];
                    if (ch >= '0' && ch <= '9') numberStr += ch;
                }
                int amount = Convert.ToInt32(numberStr);
                total += amount;
            }
        }
        return total;
    }
}

class Program{
	static void Main(){
		Invoice invoice= new Invoice();
		
		Console.WriteLine("Enter invoice details:");
        Console.WriteLine("Example: Logo Design - 3000 INR, Web Page - 4500 INR\n");
		string input= Console.ReadLine();
		
		string[] tasks= invoice.ParseInvoice(input);
		Console.WriteLine("\nInvoice Breakdown:");
        for (int i = 0; i < tasks.Length; i++) Console.WriteLine("Task " + (i + 1) + ": " + tasks[i]);
		int totalAmount = invoice.GetTotalAmount(tasks);
        Console.WriteLine("\nTotal Invoice Amount: " + totalAmount + " INR");
	}
}