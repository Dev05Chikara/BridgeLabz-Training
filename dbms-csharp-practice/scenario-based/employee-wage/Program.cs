using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Employee Wage Computation Program");
        EmployeeMenu menu = new EmployeeMenu();
        menu.DisplayMenu();
    }
}