using System;
using System.Collections.Generic;

interface IMedicalRecord{
	void AddRecord(string record);
	void ViewRecords();
}

abstract class Patient{
	private int patientId;
	private string name;
	protected int age;

	public Patient(int id, string name, int age){
		this.patientId= id;
		this.name= name;
		this.age= age;
	}

	public abstract double CalculateBill();

	public void GetPatientDetails(){
		Console.WriteLine("\nID: "+patientId);
		Console.WriteLine("Name: "+name);
	}
}

class InPatient : Patient{
	public InPatient(int id, string name, int age)
		: base(id, name, age){}

	public override double CalculateBill(){
		return 5000;
	}
}

class Program{
	static void Main(){
		List<Patient> patients= new List<Patient>();
		patients.Add(new InPatient(1, "Dev", 22));

		foreach(Patient p in patients){
			p.GetPatientDetails();
			Console.WriteLine("Bill: "+p.CalculateBill());
		}
	}
}
