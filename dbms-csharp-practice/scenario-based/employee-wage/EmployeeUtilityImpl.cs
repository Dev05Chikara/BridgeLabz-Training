using System;
using Microsoft.Data.SqlClient;

internal class EmployeeUtilityImpl : IEmployee
{
    private Random random = new Random();

    private bool IsEmployeeExists(int empId)
    {
        using (SqlConnection conn = DBConnection.GetConnection())
        {
            conn.Open();
            string query = "SELECT COUNT(*) FROM Employee WHERE EmployeeId = @id";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", empId);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
    }

    private void UpdateSalary(int empId, double amount)
    {
        using (SqlConnection conn = DBConnection.GetConnection())
        {
            conn.Open();
            string query = "UPDATE Employee SET EmployeeSalary = EmployeeSalary + @salary WHERE EmployeeId = @id";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@salary", amount);
                cmd.Parameters.AddWithValue("@id", empId);
                cmd.ExecuteNonQuery();
            }
        }
    }

    public Employee AddEmployee()
    {
        Employee employee = new Employee();

        Console.Write("Enter Name: ");
        employee.EmployeeName = Console.ReadLine();

        Console.Write("Enter Age: ");
        employee.EmployeeAge = int.Parse(Console.ReadLine());

        employee.EmployeeSalary = 0;

        using (SqlConnection conn = DBConnection.GetConnection())
        {
            conn.Open();
            string query = "INSERT INTO Employee (EmployeeName, EmployeeAge, EmployeeSalary) VALUES (@name,@age,@salary)";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@name", employee.EmployeeName);
                cmd.Parameters.AddWithValue("@age", employee.EmployeeAge);
                cmd.Parameters.AddWithValue("@salary", 0);
                cmd.ExecuteNonQuery();
            }
        }

        Console.WriteLine("Employee added successfully.");
        return employee;
    }

    public void ViewEmployees()
    {
        using (SqlConnection conn = DBConnection.GetConnection())
        {
            conn.Open();
            string query = "SELECT * FROM Employee";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("ID\tName\tAge\tSalary");
                Console.WriteLine("-------------------------------------------------");

                while (reader.Read())
                {
                    Console.WriteLine(
                        reader["EmployeeId"] + "\t" +
                        reader["EmployeeName"] + "\t" +
                        reader["EmployeeAge"] + "\t" +
                        reader["EmployeeSalary"]
                    );
                }
            }
        }
    }

    public bool CheckEmployeeAttendance()
    {
        Console.Write("Enter Employee ID: ");
        int empId = int.Parse(Console.ReadLine());

        if (!IsEmployeeExists(empId))
        {
            Console.WriteLine("Employee not found.");
            return false;
        }

        int attendance = random.Next(0, 2);

        if (attendance == Employee.IS_PRESENT)
        {
            Console.WriteLine("Employee is Present");
            return true;
        }
        else
        {
            Console.WriteLine("Employee is Absent");
            return false;
        }
    }

    public double CalculateDailyWage()
    {
        Console.Write("Enter Employee ID: ");
        int empId = int.Parse(Console.ReadLine());

        if (!IsEmployeeExists(empId))
        {
            Console.WriteLine("Employee not found.");
            return 0;
        }

        int attendance = random.Next(0, 2);
        double dailyWage = 0;

        if (attendance == Employee.IS_PRESENT)
        {
            dailyWage = Employee.WAGE_PER_HOUR * Employee.FULL_DAY_HOUR;
            UpdateSalary(empId, dailyWage);
        }

        Console.WriteLine("Daily Wage: " + dailyWage);
        return dailyWage;
    }

    public double CalculatePartTimeWage()
    {
        Console.Write("Enter Employee ID: ");
        int empId = int.Parse(Console.ReadLine());

        if (!IsEmployeeExists(empId))
        {
            Console.WriteLine("Employee not found.");
            return 0;
        }

        double wage = Employee.WAGE_PER_HOUR * Employee.PART_TIME_HOUR;
        UpdateSalary(empId, wage);

        Console.WriteLine("Part Time Wage: " + wage);
        return wage;
    }

    public double CalculateWageUsingSwitchCase()
    {
        Console.Write("Enter Employee ID: ");
        int empId = int.Parse(Console.ReadLine());

        if (!IsEmployeeExists(empId))
        {
            Console.WriteLine("Employee not found.");
            return 0;
        }

        int empType = random.Next(0, 3);
        int hoursWorked = 0;

        switch (empType)
        {
            case Employee.IS_PRESENT:
                hoursWorked = Employee.FULL_DAY_HOUR;
                break;
            case Employee.IS_PART_TIME:
                hoursWorked = Employee.PART_TIME_HOUR;
                break;
        }

        double dailyWage = hoursWorked * Employee.WAGE_PER_HOUR;
        UpdateSalary(empId, dailyWage);

        Console.WriteLine("Daily Wage: " + dailyWage);
        return dailyWage;
    }

    public double CalculateMonthlyWage()
    {
        Console.Write("Enter Employee ID: ");
        int empId = int.Parse(Console.ReadLine());

        if (!IsEmployeeExists(empId))
        {
            Console.WriteLine("Employee not found.");
            return 0;
        }

        double monthlyWage = 0;

        for (int day = 1; day <= Employee.WORKING_DAYS_PER_MONTH; day++)
        {
            int empType = random.Next(0, 3);
            int hoursWorked = 0;

            switch (empType)
            {
                case Employee.IS_PRESENT:
                    hoursWorked = Employee.FULL_DAY_HOUR;
                    break;
                case Employee.IS_PART_TIME:
                    hoursWorked = Employee.PART_TIME_HOUR;
                    break;
            }

            monthlyWage += hoursWorked * Employee.WAGE_PER_HOUR;
        }

        UpdateSalary(empId, monthlyWage);

        Console.WriteLine("Total Monthly Wage: " + monthlyWage);
        return monthlyWage;
    }

    public double CalculateWageTillCondition()
    {
        Console.Write("Enter Employee ID: ");
        int empId = int.Parse(Console.ReadLine());

        if (!IsEmployeeExists(empId))
        {
            Console.WriteLine("Employee not found.");
            return 0;
        }

        int totalHours = 0;
        int totalDays = 0;
        double totalWage = 0;

        while (totalHours < Employee.MAX_WORKING_HOURS &&
               totalDays < Employee.MAX_WORKING_DAYS)
        {
            totalDays++;
            int empType = random.Next(0, 3);
            int hoursWorked = 0;

            switch (empType)
            {
                case Employee.IS_PRESENT:
                    hoursWorked = Employee.FULL_DAY_HOUR;
                    break;
                case Employee.IS_PART_TIME:
                    hoursWorked = Employee.PART_TIME_HOUR;
                    break;
            }

            totalHours += hoursWorked;
            totalWage += hoursWorked * Employee.WAGE_PER_HOUR;
        }

        UpdateSalary(empId, totalWage);

        Console.WriteLine("Total Working Days: " + totalDays);
        Console.WriteLine("Total Working Hours: " + totalHours);
        Console.WriteLine("Total Wage: " + totalWage);

        return totalWage;
    }
}
