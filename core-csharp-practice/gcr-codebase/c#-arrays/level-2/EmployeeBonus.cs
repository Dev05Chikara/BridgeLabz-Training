using System;
class EmployeeBonus{
    static void Main(){
        int EmployeeCount= 10;
        double[] Salary= new double[EmployeeCount];
        double[] YearsOfService= new double[EmployeeCount];
        double[] Bonus= new double[EmployeeCount];
        double[] NewSalary= new double[EmployeeCount];
        double TotalBonus= 0;
        double TotalOldSalary= 0;
        double TotalNewSalary= 0;
        for(int i=0; i<EmployeeCount; i++){
            Console.WriteLine("\nEnter details for Employee "+(i + 1));
            Console.Write("Enter Salary: ");
            Salary[i]= Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Years of Service: ");
            YearsOfService[i]= Convert.ToDouble(Console.ReadLine());
            if(Salary[i] <= 0 || YearsOfService[i] < 0){
                Console.WriteLine("Invalid input! Please enter again.");
                i--;
                continue;
            }
        }
        for(int i=0; i<EmployeeCount; i++){
            if (YearsOfService[i] > 5) Bonus[i]= Salary[i]*0.05;
            else Bonus[i]= Salary[i]*0.02;
            NewSalary[i]= Salary[i]+Bonus[i];
            TotalBonus += Bonus[i];
            TotalOldSalary += Salary[i];
            TotalNewSalary += NewSalary[i];
        }
        Console.WriteLine("\nTotal Old Salary: "+TotalOldSalary);
        Console.WriteLine("Total Bonus Paid: "+TotalBonus);
        Console.WriteLine("Total New Salary: "+TotalNewSalary);
    }
}
