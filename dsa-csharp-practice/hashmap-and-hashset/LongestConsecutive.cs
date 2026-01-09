using System;
using System.Collections.Generic;

class LongestConsecutive{
	static void FindLength(int[] arr){
		HashSet<int> set= new HashSet<int>(arr);
		int max=0;
		
		foreach(int num in arr){
			if(!set.Contains(num-1)){
				int curr= num;
				int count=1;
				
				while(set.Contains(curr+1)){
					curr++;
					count++;
				}
				
				if(count>max){
					max= count;
				}
			}
		}
		
		Console.WriteLine(max);
	}
	
	static void Main(){
		int[] arr= {100,4,200,1,3,2};
		FindLength(arr);
	}
}
