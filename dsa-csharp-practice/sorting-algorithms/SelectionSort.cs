//Sort Exam Scores
using System;
class SelectionSort{
	static void Sort(int[] arr){
		for(int i=0;i<arr.Length-1;i++){
			int min= i;
			for(int j=i+1;j<arr.Length;j++){
				if(arr[j]<arr[min]) min= j;
			}
			int temp= arr[min];
			arr[min]= arr[i];
			arr[i]= temp;
		}
	}
	
	static void Main(){
		int[] scores= {88,55,92,70,60};
		Sort(scores);
		foreach(int s in scores) Console.Write(s+" ");
	}
}
