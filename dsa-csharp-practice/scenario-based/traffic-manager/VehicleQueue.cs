using System;
class VehicleQueue{
	private string[] queue= new string[5];
	private int front= 0;
	private int rear= -1;
	private int count= 0;
	
	public void Enqueue(string vehicle){
		if(count == queue.Length){
			Console.WriteLine("---No Space available---");
			return;
		}
		rear= (rear+1) % queue.Length;
		queue[rear]= vehicle;
		count++;
		Console.WriteLine("---Vehicle "+vehicle+" added to waiting queue---");
	}
	
	public string Dequeue(){
		if(count==0){
			Console.WriteLine("---No vehicles waiting---");
			return null;
		}
		string vehicle= queue[front];
		front= (front+1) % queue.Length;
		count--;
		
		return vehicle;
	}
	
	public bool IsEmpty(){
		return count == 0;
	}
}
