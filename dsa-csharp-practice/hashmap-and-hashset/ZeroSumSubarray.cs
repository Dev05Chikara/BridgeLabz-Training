using System;
using System.Collections.Generic;

class ZeroSumSubarray{
	static void CheckZeroSum(int[] arr){
		Dictionary<int,int> map= new Dictionary<int,int>();
		int sum=0;
		
		for(int i=0;i<arr.Length;i++){
			sum+= arr[i];
			
			if(sum==0 || map.ContainsKey(sum)){
				Console.WriteLine("Zero Sum Subarray Found");
				return;
			}
			
			map[sum]= i;
		}
		
		Console.WriteLine("No Zero Sum Subarray");
	}
	
	static void Main(){
		int[] arr= {4,2,-3,1,6};
		CheckZeroSum(arr);
	}
}
