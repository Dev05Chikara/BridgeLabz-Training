//Sort Student Marks
using System;
class BubbleSort{
	static void Sort(int[] arr){
		for(int i=0;i<arr.Length-1;i++){
			for(int j=0;j<arr.Length-i-1;j++){
				if(arr[j]>arr[j+1]){
					int temp= arr[j];
					arr[j]= arr[j+1];
					arr[j+1]= temp;
				}
			}
		}
	}
	
	static void Main(){
		int[] marks= {45,78,12,89,34};
		Sort(marks);
		foreach(int m in marks){
			Console.Write(m+" ");
		}
	}
}
