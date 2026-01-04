using System;

interface Worker{
    void PerformDuties();
}

class Person{
    protected string name;
    protected int id;

    public Person(string name, int id){
        this.name = name;
        this.id = id;
    }
}

class Chef : Person, Worker{
    public Chef(string name, int id) : base(name, id){}

    public void PerformDuties(){
        Console.WriteLine("Chef cooks food");
    }
}

class Waiter : Person, Worker{
    public Waiter(string name, int id) : base(name, id){}

    public void PerformDuties(){
        Console.WriteLine("Waiter serves food");
    }
}

class Program{
    static void Main(){
        Worker w1 = new Chef("Ram", 1);
        Worker w2 = new Waiter("Shyam", 2);

        w1.PerformDuties();
        w2.PerformDuties();
    }
}
