using System;
class Doctor{
	public string name;
	public string specialization;
	public double fee;
	
	public Doctor(string name, string specialization, double fee){
		this.name= name;
		this.specialization= specialization;
		this.fee= fee;
	}
	
	public void DisplayDoctor(){
		Console.WriteLine("Doctor Name: "+name);
		Console.WriteLine("Specialization: "+specialization);
		Console.WriteLine("Consultation Fee: "+fee);
	}
}
