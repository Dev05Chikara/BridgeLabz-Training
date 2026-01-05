using System;
abstract class Patient{
	public int id;
	public string name;
	public int age;
	public Doctor doctor;
	
	public Patient(int id, string name, int age, Doctor doctor){
		this.id= id;
		this.name= name;
		this.age= age;
		this.doctor= doctor;
	}
	
	public abstract void DisplayInfo();
}
