using System;

class TicketReservation{
	public int TicketReservationId;
	public string Customer;
	public string Movie;
	public int Seat;
	public DateTime Time;
	public TicketReservation next;
	
	static TicketReservation head= null;
	
	public static void BookTicketReservation(){
		TicketReservation t= new TicketReservation();
		
		Console.Write("Enter TicketReservation ID: ");
		t.TicketReservationId= Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter Customer Name: ");
		t.Customer= Console.ReadLine();
		
		Console.Write("Enter Movie Name: ");
		t.Movie= Console.ReadLine();
		
		Console.Write("Enter Seat No: ");
		t.Seat= Convert.ToInt32(Console.ReadLine());
		
		t.Time= DateTime.Now;
		
		if(head== null){
			head= t;
			t.next= head;
			Console.WriteLine("TicketReservation booked.\n");
			return;
		}
		
		TicketReservation temp= head;
		while(temp.next!= head){
			temp= temp.next;
		}
		temp.next= t;
		t.next= head;
		
		Console.WriteLine("TicketReservation booked.\n");
	}
	
	public static void RemoveTicketReservation(){
		if(head== null){
			Console.WriteLine("No TicketReservations booked!");
			return;
		}
		
		Console.Write("Enter TicketReservation ID: ");
		int id= Convert.ToInt32(Console.ReadLine());
		
		if(head.TicketReservationId== id){
			TicketReservation temp= head;
			while(temp.next!= head){
				temp= temp.next;
			}
			if(temp== head){
				head= null;
			}else{
				temp.next= head.next;
				head= head.next;
			}
			Console.WriteLine("TicketReservation cancelled.\n");
			return;
		}
		
		TicketReservation cur= head;
		while(cur.next!= head && cur.next.TicketReservationId!= id){
			cur= cur.next;
		}
		
		if(cur.next!= head){
			cur.next= cur.next.next;
			Console.WriteLine("TicketReservation cancelled.\n");
		}else{
			Console.WriteLine("TicketReservation not found!");
		}
	}
	
	public static void DisplayTicketReservations(){
		if(head== null){
			Console.WriteLine("No TicketReservations found!");
			return;
		}
		
		TicketReservation temp= head;
		do{
			Display(temp);
			temp= temp.next;
		}while(temp!= head);
	}
	
	public static void Display(TicketReservation t){
		Console.WriteLine("TicketReservation Details:");
		Console.WriteLine("- ID       : "+t.TicketReservationId);
		Console.WriteLine("- Customer : "+t.Customer);
		Console.WriteLine("- Movie    : "+t.Movie);
		Console.WriteLine("- Seat     : "+t.Seat);
		Console.WriteLine("- Time     : "+t.Time);
		Console.WriteLine("---------------------\n");
	}
}

class Program{
	static void Main(){
		bool menu= true;
		
		do{
			Console.WriteLine("\n---TicketReservation MENU---");
			Console.WriteLine("1. Book TicketReservation");
			Console.WriteLine("2. Cancel TicketReservation");
			Console.WriteLine("3. Display TicketReservations");
			Console.WriteLine("4. Exit");
			Console.Write("Enter choice: ");
			
			int ch= Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("");
			
			switch(ch){
				case 1: TicketReservation.BookTicketReservation(); break;
				case 2: TicketReservation.RemoveTicketReservation(); break;
				case 3: TicketReservation.DisplayTicketReservations(); break;
				case 4: menu= false; break;
				default: Console.WriteLine("Invalid choice!"); break;
			}
		}while(menu== true);
	}
}
