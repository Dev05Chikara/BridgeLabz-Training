using System;

class CircularTour{
	static int FindStart(int[] petrol, int[] dist){
		int start=0, surplus=0, deficit=0;
		
		for(int i=0;i<petrol.Length;i++){
			surplus+= petrol[i]-dist[i];
			
			if(surplus<0){
				start= i+1;
				deficit+= surplus;
				surplus=0;
			}
		}
		
		return surplus+deficit>=0 ? start : -1;
	}
	
	static void Main(){
		int[] petrol= {4,6,7,4};
		int[] dist= {6,5,3,5};
		
		Console.WriteLine(FindStart(petrol, dist));
	}
}
