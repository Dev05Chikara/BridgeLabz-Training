using System;

class SocialMedia{
	public int SocialMediaId;
	public string Name;
	public int Friends;
	public SocialMedia next;
	
	static SocialMedia head= null;
	
	public static void AddSocialMedia(){
		SocialMedia u= new SocialMedia();
		
		Console.Write("Enter SocialMedia ID: ");
		u.SocialMediaId= Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter Name: ");
		u.Name= Console.ReadLine();
		
		u.Friends= 0;
		u.next= head;
		head= u;
		
		Console.WriteLine("SocialMedia added.\n");
	}
	
	public static void AddFriend(){
		Console.Write("Enter SocialMedia ID: ");
		int id= Convert.ToInt32(Console.ReadLine());
		
		SocialMedia temp= head;
		while(temp!= null){
			if(temp.SocialMediaId== id){
				temp.Friends++;
				Console.WriteLine("Friend added.\n");
				return;
			}
			temp= temp.next;
		}
		Console.WriteLine("SocialMedia not found!");
	}
	
	public static void Display(){
		SocialMedia temp= head;
		while(temp!= null){
			Console.WriteLine(temp.SocialMediaId+" "+temp.Name+" Friends: "+temp.Friends);
			temp= temp.next;
		}
	}
}

class Program{
	static void Main(){
		bool menu= true;
		do{
			Console.WriteLine("\n---SOCIAL MENU---");
			Console.WriteLine("1. Add SocialMedia");
			Console.WriteLine("2. Add Friend");
			Console.WriteLine("3. Display SocialMedias");
			Console.WriteLine("4. Exit");
			Console.Write("Enter choice: ");
			
			int ch= Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("");
			
			switch(ch){
				case 1: SocialMedia.AddSocialMedia(); break;
				case 2: SocialMedia.AddFriend(); break;
				case 3: SocialMedia.Display(); break;
				case 4: menu= false; break;
			}
		}while(menu== true);
	}
}
