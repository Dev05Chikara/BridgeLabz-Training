using System;

class TaskScheduler{
	public int Id;
	public string Name;
	public int Priority;
	public TaskScheduler next;
	
	static TaskScheduler head= null;
	
	public static void AddTaskScheduler(){
		TaskScheduler t= new TaskScheduler();
		
		Console.Write("Enter TaskScheduler ID: ");
		t.Id= Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter TaskScheduler Name: ");
		t.Name= Console.ReadLine();
		
		Console.Write("Enter Priority: ");
		t.Priority= Convert.ToInt32(Console.ReadLine());
		
		if(head== null){
			head= t;
			t.next= head;
			return;
		}
		
		TaskScheduler temp= head;
		while(temp.next!= head){
			temp= temp.next;
		}
		temp.next= t;
		t.next= head;
		
		Console.WriteLine("TaskScheduler added.\n");
	}
	
	public static void Display(){
		if(head== null) return;
		
		TaskScheduler temp= head;
		do{
			Console.WriteLine(temp.Id+" "+temp.Name+" "+temp.Priority);
			temp= temp.next;
		}while(temp!= head);
	}
}

class Program{
	static void Main(){
		bool menu= true;
		do{
			Console.WriteLine("\n---TaskScheduler MENU---");
			Console.WriteLine("1. Add TaskScheduler");
			Console.WriteLine("2. Display TaskSchedulers");
			Console.WriteLine("3. Exit");
			Console.Write("Enter choice: ");
			
			int ch= Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("");
			
			switch(ch){
				case 1: TaskScheduler.AddTaskScheduler(); break;
				case 2: TaskScheduler.Display(); break;
				case 3: menu= false; break;
			}
		}while(menu== true);
	}
}
