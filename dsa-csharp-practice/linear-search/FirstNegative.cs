//First Negative Number
using System;

class FirstNegative{
	static void Main(){
		int[] arr= {5,3,-2,7,-4};
		
		for(int i=0;i<arr.Length;i++){
			if(arr[i]<0){
				Console.WriteLine(arr[i]);
				break;
			}
		}
	}
}
