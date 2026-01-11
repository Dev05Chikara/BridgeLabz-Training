//Sort Book Prices
using System;
class MergeSort{
	static void Merge(int[] arr, int l, int m, int r){
		int n1= m-l+1;
		int n2= r-m;
		int[] L= new int[n1];
		int[] R= new int[n2];
		for(int i=0;i<n1;i++){
			L[i]= arr[l+i];
		}
		for(int j=0;j<n2;j++){
			R[j]= arr[m+1+j];
		}
		int i1=0, i2=0, k=l;
		while(i1<n1 && i2<n2){
			if(L[i1]<=R[i2]){
				arr[k]= L[i1];
				i1++;
			}else{
				arr[k]= R[i2];
				i2++;
			}
			k++;
		}
		while(i1<n1){
			arr[k]= L[i1];
			i1++; k++;
		}
		while(i2<n2){
			arr[k]= R[i2];
			i2++; k++;
		}
	}
	
	static void Sort(int[] arr, int l, int r){
		if(l<r){
			int m= (l+r)/2;
			Sort(arr, l, m);
			Sort(arr, m+1, r);
			Merge(arr, l, m, r);
		}
	}
	
	static void Main(){
		int[] prices= {299,499,199,399,149};
		Sort(prices, 0, prices.Length-1);
		foreach(int p in prices) Console.Write(p+" ");
	}
}
