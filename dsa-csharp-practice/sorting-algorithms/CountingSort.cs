//Sort Student Ages
using System;
class CountingSort{
	static void Sort(int[] arr){
		int max= 18;
		int min= 10;
		int[] count= new int[max-min+1];
		for(int i=0;i<arr.Length;i++) count[arr[i]-min]++;
		int index=0;
		for(int i=0;i<count.Length;i++){
			while(count[i]>0){
				arr[index]= i+min;
				index++;
				count[i]--;
			}
		}
	}
	
	static void Main(){
		int[] ages= {12,15,10,18,14,11,16};
		Sort(ages);
		foreach(int a in ages) Console.Write(a+" ");
	}
}
