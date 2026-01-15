using System;
class HistoryNode{
	public string url;
	public HistoryNode prev;
	public HistoryNode next;
	
	public HistoryNode(string url){
		this.url= url;
		prev= null;
		next= null;
	}
}
