using System;
class BrowserBuddyMenu{
	static void Main(){
		BrowserTab currentTab= null;
		ClosedTabsStack closedTabs= new ClosedTabsStack();
		
		while(true){
			Console.WriteLine("\n1. Open New Tab");
			Console.WriteLine("2. Visit New Page");
			Console.WriteLine("3. Back");
			Console.WriteLine("4. Forward");
			Console.WriteLine("5. Close Current Tab");
			Console.WriteLine("6. Restore Closed Tab");
			Console.WriteLine("0. Exit");
			
			Console.Write("Enter choice: ");
			int choice= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------------");
			
			switch(choice){
				case 1:
					Console.Write("Enter homepage URL: ");
					currentTab= new BrowserTab(Console.ReadLine());
					break;
				
				case 2:
					if(currentTab!=null){
						Console.Write("Enter URL: ");
						currentTab.Visit(Console.ReadLine());
					}else{
						Console.WriteLine("No tab open.");
					}
					break;
				
				case 3:
					if(currentTab!=null) currentTab.Back();
					else Console.WriteLine("No tab open.");
					break;
				
				case 4:
					if(currentTab!=null) currentTab.Forward();
					else Console.WriteLine("No tab open.");
					break;
				
				case 5:
					if(currentTab!=null){
						closedTabs.Push(currentTab);
						Console.WriteLine("Tab closed: "+currentTab.GetCurrentPage());
						currentTab= null;
					}else{
						Console.WriteLine("No tab open.");
					}
					break;
				
				case 6:
					currentTab= closedTabs.Pop();
					if(currentTab!=null){
						Console.WriteLine("Restored tab at: "+currentTab.GetCurrentPage());
					}
					break;
				
				case 0:
					return;
				
				default:
					Console.WriteLine("Invalid choice.");
					break;
			}
		}
	}
}
