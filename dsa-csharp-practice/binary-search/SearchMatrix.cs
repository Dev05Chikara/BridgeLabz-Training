//Search in 2D Sorted Matrix
using System;

class SearchMatrix{
	static void Main(){
		int[,] mat= {
			{1,3,5},
			{7,9,11},
			{13,15,17}
		};
		
		int target= 9;
		int r=0, c=2;
		
		while(r<3 && c>=0){
			if(mat[r,c]==target){
				Console.WriteLine("Found");
				return;
			}else if(mat[r,c]>target){
				c--;
			}else{
				r++;
			}
		}
		
		Console.WriteLine("Not Found");
	}
}
