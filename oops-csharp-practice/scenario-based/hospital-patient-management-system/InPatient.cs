using System;
class InPatient : Patient, IPayable{
	private int days;
	private double roomCharge;
	
	public InPatient(int id, string name, int age, Doctor doctor, int days, double roomCharge)
		: base(id, name, age, doctor){
		this.days= days;
		this.roomCharge= roomCharge;
	}
	
	public double CalculateBill(){
		return (days * roomCharge) + doctor.fee;
	}
	
	public override void DisplayInfo(){
		Console.WriteLine("\nInPatient Details:");
		Console.WriteLine("ID: "+id);
		Console.WriteLine("Name: "+name);
		Console.WriteLine("Age: "+age);
		doctor.DisplayDoctor();
		Console.WriteLine("Days Admitted: "+days);
		Console.WriteLine("Total Bill: "+CalculateBill());
	}
}
