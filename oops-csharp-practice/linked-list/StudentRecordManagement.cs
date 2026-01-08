using System;

class StudentRecordManagement{
	public int RollNo;
	public string Name;
	public int Age;
	public string Grade;
	public StudentRecordManagement next;
	
	static StudentRecordManagement head= null;
	
	public static void AddAtBeginning(){
		StudentRecordManagement s= new StudentRecordManagement();
		
		Console.Write("Enter Roll No: ");
		s.RollNo= Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter Name: ");
		s.Name= Console.ReadLine();
		
		Console.Write("Enter Age: ");
		s.Age= Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter Grade: ");
		s.Grade= Console.ReadLine();
		
		s.next= head;
		head= s;
		
		Console.WriteLine("StudentRecordManagement added successfully.\n");
	}
	
	public static void AddAtEnd(){
		StudentRecordManagement s= new StudentRecordManagement();
		
		Console.Write("Enter Roll No: ");
		s.RollNo= Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter Name: ");
		s.Name= Console.ReadLine();
		
		Console.Write("Enter Age: ");
		s.Age= Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter Grade: ");
		s.Grade= Console.ReadLine();
		
		s.next= null;
		
		if(head== null){
			head= s;
			return;
		}
		
		StudentRecordManagement temp= head;
		while(temp.next!= null){
			temp= temp.next;
		}
		temp.next= s;
		
		Console.WriteLine("StudentRecordManagement added successfully.\n");
	}
	
	public static void DeleteByRoll(){
		if(head== null){
			Console.WriteLine("List is empty!");
			return;
		}
		
		Console.Write("Enter Roll No to delete: ");
		int roll= Convert.ToInt32(Console.ReadLine());
		
		if(head.RollNo== roll){
			head= head.next;
			Console.WriteLine("StudentRecordManagement deleted.\n");
			return;
		}
		
		StudentRecordManagement temp= head;
		while(temp.next!= null && temp.next.RollNo!= roll){
			temp= temp.next;
		}
		
		if(temp.next== null){
			Console.WriteLine("StudentRecordManagement not found!");
		}else{
			temp.next= temp.next.next;
			Console.WriteLine("StudentRecordManagement deleted.\n");
		}
	}
	
	public static void Search(){
		Console.Write("Enter Roll No to search: ");
		int roll= Convert.ToInt32(Console.ReadLine());
		
		StudentRecordManagement temp= head;
		while(temp!= null){
			if(temp.RollNo== roll){
				Display(temp);
				return;
			}
			temp= temp.next;
		}
		
		Console.WriteLine("StudentRecordManagement not found!");
	}
	
	public static void UpdateGrade(){
		Console.Write("Enter Roll No: ");
		int roll= Convert.ToInt32(Console.ReadLine());
		
		StudentRecordManagement temp= head;
		while(temp!= null){
			if(temp.RollNo== roll){
				Console.Write("Enter new Grade: ");
				temp.Grade= Console.ReadLine();
				Console.WriteLine("Grade updated.\n");
				return;
			}
			temp= temp.next;
		}
		
		Console.WriteLine("StudentRecordManagement not found!");
	}
	
	public static void DisplayAll(){
		if(head== null){
			Console.WriteLine("No records found!");
			return;
		}
		
		StudentRecordManagement temp= head;
		while(temp!= null){
			Display(temp);
			temp= temp.next;
		}
	}
	
	public static void Display(StudentRecordManagement s){
		Console.WriteLine("StudentRecordManagement Details:");
		Console.WriteLine("- Roll No : "+s.RollNo);
		Console.WriteLine("- Name    : "+s.Name);
		Console.WriteLine("- Age     : "+s.Age);
		Console.WriteLine("- Grade   : "+s.Grade);
		Console.WriteLine("-------------------------\n");
	}
}

class Program{
	static void Main(){
		bool menu= true;
		
		do{
			Console.WriteLine("\n---StudentRecordManagement MENU---");
			Console.WriteLine("1. Add at Beginning");
			Console.WriteLine("2. Add at End");
			Console.WriteLine("3. Delete by Roll No");
			Console.WriteLine("4. Search StudentRecordManagement");
			Console.WriteLine("5. Update Grade");
			Console.WriteLine("6. Display All");
			Console.WriteLine("7. Exit");
			Console.Write("Enter choice: ");
			
			int choice= Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("");
			
			switch(choice){
				case 1:
					StudentRecordManagement.AddAtBeginning();
					break;
					
				case 2:
					StudentRecordManagement.AddAtEnd();
					break;
					
				case 3:
					StudentRecordManagement.DeleteByRoll();
					break;
					
				case 4:
					StudentRecordManagement.Search();
					break;
					
				case 5:
					StudentRecordManagement.UpdateGrade();
					break;
					
				case 6:
					StudentRecordManagement.DisplayAll();
					break;
					
				case 7:
					menu= false;
					Console.WriteLine("Exiting...");
					break;
					
				default:
					Console.WriteLine("Invalid choice!");
					break;
			}
		}while(menu== true);
	}
}
