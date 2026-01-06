using System;
class CallLog{
	public string PhoneNumber;
	public string Message;
	public DateTime TimeStamp;
	
	static CallLog[] logs = new CallLog[50];
    static int logCount = 0;
	
	public static void AddCallLog(){
		if (logCount >= logs.Length){
            Console.WriteLine("Log storage full!");
            return;
        }

        CallLog log = new CallLog();
        Console.Write("Enter Phone Number: ");
        log.PhoneNumber = Console.ReadLine();

        Console.Write("Enter Message: ");
        log.Message = Console.ReadLine();

        log.TimeStamp = DateTime.Now;

        logs[logCount] = log;
        logCount++;

        Console.WriteLine("Call log added successfully.\n");
	}
	public static void SearchByKeyword(){
		Console.Write("Enter to search: ");
		string searchKeyword= Console.ReadLine();
		
		bool found= false;
		
		for(int i=0; i<logCount; i++){
			if(logs[i].Message.ToLower().Contains(searchKeyword.ToLower())){
				Display(logs[i]);
				found= true;
			}
		}
		if(!found) Console.WriteLine("No log found!");
	}
	public static void FilterByTime(){
		Console.Write("Enter start date & time(yyyy-MM-dd HH:mm): ");
		DateTime start= DateTime.Parse(Console.ReadLine());
		
		Console.Write("Enter end date & time(yyyy-MM-dd HH:mm): ");
		DateTime end= DateTime.Parse(Console.ReadLine());
		
		bool found= false;
		for(int i=0; i<logCount; i++){
			if(logs[i].TimeStamp >= start && logs[i].TimeStamp <= end){
				Display(logs[i]);
				found= true;
			}
		}
		if(!found) Console.WriteLine("No log found!");
	}
	public static void Display(CallLog log){
		Console.WriteLine("Here are the details:");
		Console.WriteLine("- Phone Number: "+log.PhoneNumber);
		Console.WriteLine("- Message     : "+log.Message);
		Console.WriteLine("- Time Stamp  : "+log.TimeStamp);
		Console.WriteLine("----------------------------------\n");
	}
}

class Program{
	static void Main(){
		bool menu= true;
		do{
			Console.WriteLine("\n---MENU---");
			Console.WriteLine("1. Add Call Log");
            Console.WriteLine("2. Search Log by Keyword");
            Console.WriteLine("3. Filter Logs by Time Range");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("");
			switch(choice){
				case 1:
					CallLog.AddCallLog();
					break;
					
				case 2:
					CallLog.SearchByKeyword();
					break;
					
				case 3:
					CallLog.FilterByTime();
					break;
					
				case 4:
					menu=false;
					Console.WriteLine("Exiting Application...");
                    break;
					
				default:
					Console.WriteLine("Invalid choice!\n");
                    break;
			}
		}while(menu==true);
	}
}