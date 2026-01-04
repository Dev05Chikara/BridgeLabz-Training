using System;
class Patient{
	public static string HospitalName= "City Hospital";
	private static int totalPatients= 0;
	
	public readonly int PatientID;
	private string Name;
	private int Age;
	private string Ailment;
	
	public Patient(int PatientID, string Name, int Age, string Ailment){
		this.PatientID= PatientID;
		this.Name= Name;
		this.Age= Age;
		this.Ailment= Ailment;
		totalPatients++;
	}
	
	public void DisplayDetails(){
		Console.WriteLine("\nPatient Details:");
		Console.WriteLine("Hospital: "+HospitalName);
		Console.WriteLine("ID: "+PatientID);
		Console.WriteLine("Name: "+Name);
		Console.WriteLine("Age: "+Age);
		Console.WriteLine("Ailment: "+Ailment);
	}
	
	public static void GetTotalPatients(){
		Console.WriteLine("\nTotal Patients: "+totalPatients);
	}
}
class Program{
	static void Main(){
		object p= new Patient(1, "Ramesh", 45, "Fever");
		
		if(p is Patient){
			((Patient)p).DisplayDetails();
		}
		
		Patient.GetTotalPatients();
	}
}
