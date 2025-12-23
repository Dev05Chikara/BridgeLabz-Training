using System;
class Calculator{
    static void Main(){
        Console.Write("Enter first number: ");
        double First = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter second number: ");
        double Second = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter operator (+, -, *, /): ");
        string Op = Console.ReadLine();
        switch(Op)
        {
            case "+":
                Console.WriteLine("Result: "+(First+Second));
                break;
            case "-":
                Console.WriteLine("Result: "+(First-Second));
                break;
            case "*":
                Console.WriteLine("Result: "+(First*Second));
                break;
            case "/":
                if(Second != 0) Console.WriteLine("Result: "+(First/Second));
                else Console.WriteLine("Division by zero not allowed");
                break;
            default:
                Console.WriteLine("Invalid Operator");
                break;
        }
    }
}
