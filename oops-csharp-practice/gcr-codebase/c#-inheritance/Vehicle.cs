using System;
class Vehicle{
    protected int maxSpeed;
    protected string fuelType;

    public Vehicle(int maxSpeed, string fuelType){
        this.maxSpeed = maxSpeed;
        this.fuelType = fuelType;
    }

    public virtual void DisplayInfo(){
        Console.WriteLine("Max Speed: " + maxSpeed);
        Console.WriteLine("Fuel Type: " + fuelType);
    }
}

class Car : Vehicle{
    private int seatCapacity;

    public Car(int speed, string fuel, int seats)
        : base(speed, fuel){
        seatCapacity = seats;
    }

    public override void DisplayInfo(){
        base.DisplayInfo();
        Console.WriteLine("Seats: " + seatCapacity);
    }
}

class Truck : Vehicle{
    private int payload;

    public Truck(int speed, string fuel, int payload)
        : base(speed, fuel){
        this.payload = payload;
    }

    public override void DisplayInfo(){
        base.DisplayInfo();
        Console.WriteLine("Payload Capacity: " + payload);
    }
}

class Motorcycle : Vehicle{
    private bool hasSidecar;

    public Motorcycle(int speed, string fuel, bool sidecar)
        : base(speed, fuel){
        hasSidecar = sidecar;
    }

    public override void DisplayInfo(){
        base.DisplayInfo();
        Console.WriteLine("Has Sidecar: " + hasSidecar);
    }
}

class Program{
    static void Main(){
        Vehicle[] vehicles = {
            new Car(180, "Petrol", 5),
            new Truck(120, "Diesel", 5000),
            new Motorcycle(160, "Petrol", false)
        };

        foreach(Vehicle v in vehicles){
            Console.WriteLine("\nVehicle Info:");
            v.DisplayInfo();
        }
    }
}
