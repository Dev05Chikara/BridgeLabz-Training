//Challenge Problem: Linear+Binary Search
using System;

class Challenge{
	static void Main(){
		int[] arr= {3,4,-1,1};
		
		bool[] visited= new bool[arr.Length+1];
		
		foreach(int num in arr){
			if(num>0 && num<=arr.Length){
				visited[num]= true;
			}
		}
		
		for(int i=1;i<=arr.Length;i++){
			if(!visited[i]){
				Console.WriteLine("Missing: "+i);
				break;
			}
		}
		
		Array.Sort(arr);
		int target= 4;
		int low=0, high=arr.Length-1;
		
		while(low<=high){
			int mid= (low+high)/2;
			
			if(arr[mid]==target){
				Console.WriteLine("Index: "+mid);
				return;
			}else if(arr[mid]<target){
				low= mid+1;
			}else{
				high= mid-1;
			}
		}
		
		Console.WriteLine("-1");
	}
}
