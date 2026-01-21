using System;
using System.Collections.Generic;

class Patient{
	public string Name;
	public int Severity;
	
	public Patient(string n,int s){
		Name=n; Severity=s;
	}
}

class HospitalTriage{
	static void Main(){
		List<Patient> list= new List<Patient>(){
			new Patient("John",3),
			new Patient("Alice",5),
			new Patient("Bob",2)
		};
		list.Sort((a,b)=> b.Severity.CompareTo(a.Severity));
		foreach(Patient p in list)
			Console.WriteLine(p.Name);
	}
}
