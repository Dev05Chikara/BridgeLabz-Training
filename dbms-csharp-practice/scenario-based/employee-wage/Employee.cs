using System;

internal class Employee
{
    public int EmployeeId { get; set; }
    public string EmployeeName { get; set; }
    public int EmployeeAge { get; set; }
    public double EmployeeSalary { get; set; }

    // Constants
    public const int WAGE_PER_HOUR = 20;
    public const int FULL_DAY_HOUR = 8;
    public const int PART_TIME_HOUR = 4;
    public const int WORKING_DAYS_PER_MONTH = 20;
    public const int MAX_WORKING_HOURS = 100;
    public const int MAX_WORKING_DAYS = 20;

    public const int IS_PRESENT = 1;
    public const int IS_ABSENT = 0;
    public const int IS_PART_TIME = 2;
}
