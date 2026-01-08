using System;

class RoundRobin{
	public int Pid;
	public int Burst;
	public RoundRobin next;
	
	static RoundRobin head= null;
	
	public static void AddRoundRobin(){
		RoundRobin p= new RoundRobin();
		
		Console.Write("Enter RoundRobin ID: ");
		p.Pid= Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter Burst Time: ");
		p.Burst= Convert.ToInt32(Console.ReadLine());
		
		if(head== null){
			head= p;
			p.next= head;
			return;
		}
		
		RoundRobin temp= head;
		while(temp.next!= head){
			temp= temp.next;
		}
		temp.next= p;
		p.next= head;
		
		Console.WriteLine("RoundRobin added.\n");
	}
	
	public static void Display(){
		if(head== null) return;
		
		RoundRobin temp= head;
		do{
			Console.WriteLine("PID: "+temp.Pid+" Burst: "+temp.Burst);
			temp= temp.next;
		}while(temp!= head);
	}
}

class Program{
	static void Main(){
		bool menu= true;
		do{
			Console.WriteLine("\n---ROUND ROBIN MENU---");
			Console.WriteLine("1. Add RoundRobin");
			Console.WriteLine("2. Display RoundRobines");
			Console.WriteLine("3. Exit");
			Console.Write("Enter choice: ");
			
			int ch= Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("");
			
			switch(ch){
				case 1: RoundRobin.AddRoundRobin(); break;
				case 2: RoundRobin.Display(); break;
				case 3: menu= false; break;
			}
		}while(menu== true);
	}
}
