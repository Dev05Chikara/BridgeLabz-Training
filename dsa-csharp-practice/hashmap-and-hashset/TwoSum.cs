using System;
using System.Collections.Generic;

class TwoSum{
	static void FindIndices(int[] arr, int target){
		Dictionary<int,int> map= new Dictionary<int,int>();
		
		for(int i=0;i<arr.Length;i++){
			if(map.ContainsKey(target-arr[i])){
				Console.WriteLine(map[target-arr[i]]+" "+i);
				return;
			}
			map[arr[i]]= i;
		}
	}
	
	static void Main(){
		int[] arr= {2,7,11,15};
		FindIndices(arr, 9);
	}
}
