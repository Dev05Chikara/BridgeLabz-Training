//Bubble Sort vs Merge Sort vs Quick Sort
using System;
using System.Diagnostics;

class SortingComparison{
	static void BubbleSort(int[] arr){
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
	
	static void MergeSort(int[] arr,int left,int right){
		if(left>=right) return;
		
		int mid= (left+right)/2;
		MergeSort(arr,left,mid);
		MergeSort(arr,mid+1,right);
		Merge(arr,left,mid,right);
	}
	
	static void Merge(int[] arr,int left,int mid,int right){
		int[] temp= new int[right-left+1];
		int i= left, j= mid+1, k=0;
		
		while(i<=mid && j<=right){
			if(arr[i]<=arr[j]) temp[k++]= arr[i++];
			else temp[k++]= arr[j++];
		}
		
		while(i<=mid) temp[k++]= arr[i++];
		while(j<=right) temp[k++]= arr[j++];
		
		for(i=left;i<=right;i++){
			arr[i]= temp[i-left];
		}
	}
	
	static void QuickSort(int[] arr,int low,int high){
		if(low>=high) return;
		
		int pivot= Partition(arr,low,high);
		QuickSort(arr,low,pivot-1);
		QuickSort(arr,pivot+1,high);
	}
	
	static int Partition(int[] arr,int low,int high){
		int pivot= arr[high];
		int i= low-1;
		
		for(int j=low;j<high;j++){
			if(arr[j]<pivot){
				i++;
				int temp= arr[i];
				arr[i]= arr[j];
				arr[j]= temp;
			}
		}
		
		int t= arr[i+1];
		arr[i+1]= arr[high];
		arr[high]= t;
		
		return i+1;
	}
	
	static void Main(){
		int n= 10000;
		int[] arr= new int[n];
		Random r= new Random();
		
		for(int i=0;i<n;i++){
			arr[i]= r.Next();
		}
		
		Stopwatch sw= new Stopwatch();
		
		int[] a1= (int[])arr.Clone();
		sw.Start();
		BubbleSort(a1);
		sw.Stop();
		Console.WriteLine("Bubble Sort Time: "+sw.ElapsedMilliseconds);
		
		int[] a2= (int[])arr.Clone();
		sw.Restart();
		MergeSort(a2,0,n-1);
		sw.Stop();
		Console.WriteLine("Merge Sort Time: "+sw.ElapsedMilliseconds);
		
		int[] a3= (int[])arr.Clone();
		sw.Restart();
		QuickSort(a3,0,n-1);
		sw.Stop();
		Console.WriteLine("Quick Sort Time: "+sw.ElapsedMilliseconds);
	}
}
