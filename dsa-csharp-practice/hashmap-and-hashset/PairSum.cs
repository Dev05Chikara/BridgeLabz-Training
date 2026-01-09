using System;
using System.Collections.Generic;

class PairSum{
	static void CheckPair(int[] arr, int target){
		Dictionary<int,bool> map= new Dictionary<int,bool>();
		
		foreach(int num in arr){
			if(map.ContainsKey(target-num)){
				Console.WriteLine("Pair Found");
				return;
			}
			map[num]= true;
		}
		
		Console.WriteLine("Pair Not Found");
	}
	
	static void Main(){
		int[] arr= {8,7,2,5,3,1};
		CheckPair(arr, 10);
	}
}
