using System;
class Employee{
    protected string name;
    protected int id;
    protected double salary;

    public Employee(string name, int id, double salary){
        this.name = name;
        this.id = id;
        this.salary = salary;
    }

    public virtual void DisplayDetails(){
        Console.WriteLine("\nName: " + name);
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Salary: " + salary);
    }
}

class Manager : Employee{
    private int teamSize;

    public Manager(string name, int id, double salary, int teamSize)
        : base(name, id, salary){
        this.teamSize = teamSize;
    }

    public override void DisplayDetails(){
        base.DisplayDetails();
        Console.WriteLine("Team Size: " + teamSize);
    }
}

class Developer : Employee{
    private string programmingLanguage;

    public Developer(string name, int id, double salary, string language)
        : base(name, id, salary){
        programmingLanguage = language;
    }

    public override void DisplayDetails(){
        base.DisplayDetails();
        Console.WriteLine("Language: " + programmingLanguage);
    }
}

class Intern : Employee{
    private string duration;

    public Intern(string name, int id, double salary, string duration)
        : base(name, id, salary){
        this.duration = duration;
    }

    public override void DisplayDetails(){
        base.DisplayDetails();
        Console.WriteLine("Internship Duration: " + duration);
    }
}

class Program{
    static void Main(){
        Manager m = new Manager("Dev", 1, 60000, 5);
        Developer d = new Developer("Krishna", 2, 50000, "C#");
        Intern i = new Intern("Abhishek", 3, 15000, "6 Months");

        m.DisplayDetails();
        d.DisplayDetails();
        i.DisplayDetails();
    }
}
