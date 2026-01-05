using System;
class OutPatient : Patient, IPayable{
	
	public OutPatient(int id, string name, int age, Doctor doctor)
		: base(id, name, age, doctor){
	}
	
	public double CalculateBill(){
		return doctor.fee;
	}
	
	public override void DisplayInfo(){
		Console.WriteLine("\nOutPatient Details:");
		Console.WriteLine("ID: "+id);
		Console.WriteLine("Name: "+name);
		Console.WriteLine("Age: "+age);
		doctor.DisplayDoctor();
		Console.WriteLine("Total Bill: "+CalculateBill());
	}
}
