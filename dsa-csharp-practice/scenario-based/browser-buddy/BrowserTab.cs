using System;
class BrowserTab{
	private HistoryNode current;
	
	public BrowserTab(string homepage){
		current= new HistoryNode(homepage);
		Console.WriteLine("Opened homepage: "+homepage);
	}
	
	public void Visit(string url){
		HistoryNode newNode= new HistoryNode(url);
		
		current.next= newNode;
		newNode.prev= current;
		current= newNode;
		
		Console.WriteLine("Visited: "+url);
	}
	
	public void Back(){
		if(current.prev!=null){
			current= current.prev;
			Console.WriteLine("Back to: "+current.url);
		}else{
			Console.WriteLine("No previous page.");
		}
	}
	
	public void Forward(){
		if(current.next!=null){
			current= current.next;
			Console.WriteLine("Forward to: "+current.url);
		}else{
			Console.WriteLine("No forward page.");
		}
	}
	
	public string GetCurrentPage(){
		return current.url;
	}
}
