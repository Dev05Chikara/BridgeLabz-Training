using System;

class TextEditor{
	public string Content;
	public TextEditor next;
	public TextEditor prev;
	
	static TextEditor head= null;
	static TextEditor current= null;
	static int count= 0;
	static int limit= 10;
	
	public static void AddState(){
		TextEditor t= new TextEditor();
		
		Console.Write("Enter Text: ");
		t.Content= Console.ReadLine();
		
		if(current!= null && current.next!= null){
			current.next= null;
		}
		
		if(head== null){
			head= current= t;
		}else{
			current.next= t;
			t.prev= current;
			current= t;
		}
		
		count++;
		if(count> limit){
			head= head.next;
			head.prev= null;
			count--;
		}
		
		Console.WriteLine("State added.\n");
	}
	
	public static void Undo(){
		if(current!= null && current.prev!= null){
			current= current.prev;
			Console.WriteLine("Undo successful.");
			DisplayCurrent();
			return;
		}
		Console.WriteLine("No undo available!");
	}
	
	public static void Redo(){
		if(current!= null && current.next!= null){
			current= current.next;
			Console.WriteLine("Redo successful.");
			DisplayCurrent();
			return;
		}
		Console.WriteLine("No redo available!");
	}
	
	public static void DisplayCurrent(){
		if(current== null){
			Console.WriteLine("No text available!");
			return;
		}
		Console.WriteLine("Current Text: "+current.Content+"\n");
	}
}

class Program{
	static void Main(){
		bool menu= true;
		
		do{
			Console.WriteLine("\n---UNDO / REDO MENU---");
			Console.WriteLine("1. Add Text");
			Console.WriteLine("2. Undo");
			Console.WriteLine("3. Redo");
			Console.WriteLine("4. Display Current");
			Console.WriteLine("5. Exit");
			Console.Write("Enter choice: ");
			
			int ch= Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("");
			
			switch(ch){
				case 1: TextEditor.AddState(); break;
				case 2: TextEditor.Undo(); break;
				case 3: TextEditor.Redo(); break;
				case 4: TextEditor.DisplayCurrent(); break;
				case 5: menu= false; break;
				default: Console.WriteLine("Invalid choice!"); break;
			}
		}while(menu== true);
	}
}
