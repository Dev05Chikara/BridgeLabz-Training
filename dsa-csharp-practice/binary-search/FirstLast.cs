//First & Last Occurrence
using System;

class FirstLast{
	static int Find(int[] arr, int target, bool first){
		int low=0, high=arr.Length-1, res=-1;
		
		while(low<=high){
			int mid= (low+high)/2;
			
			if(arr[mid]==target){
				res= mid;
				if(first) high= mid-1;
				else low= mid+1;
			}else if(arr[mid]<target){
				low= mid+1;
			}else{
				high= mid-1;
			}
		}
		
		return res;
	}
	
	static void Main(){
		int[] arr= {1,2,2,2,3,4};
		
		Console.WriteLine(Find(arr,2,true));
		Console.WriteLine(Find(arr,2,false));
	}
}
