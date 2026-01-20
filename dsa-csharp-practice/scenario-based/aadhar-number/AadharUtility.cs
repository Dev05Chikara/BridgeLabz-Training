using System;
class AadharUtility{
	private long[] aadharNumbers;
	private int total;
	
	public AadharUtility(int size){
		aadharNumbers= new long[size];
		total= 0;
	}
	
	public void AddAadhar(long number){
		if(total==aadharNumbers.Length){
			Console.WriteLine("Storage full.");
			return;
		}
		aadharNumbers[total++]= number;
	}
	
	public void RadixSort(){
        if (total == 0)
        {
            Console.WriteLine("\nNo Aadhar-card available! Can't operate sort.");
            return;
        }
		long max= GetMax();
		
		for(long exp=1; max/exp>0; exp*=10){
			CountingSort(exp);
		}
		
		Console.WriteLine("Aadhar numbers sorted successfully.");
	}
	
	private void CountingSort(long exp){
		long[] output= new long[total];
		int[] count= new int[10];
		
		for(int i=0;i<total;i++){
			int digit= (int)((aadharNumbers[i]/exp)%10);
			count[digit]++;
		}
		
		for(int i=1;i<10;i++){
			count[i]+= count[i-1];
		}
		
		for(int i=total-1;i>=0;i--){
			int digit= (int)((aadharNumbers[i]/exp)%10);
			output[count[digit]-1]= aadharNumbers[i];
			count[digit]--;
		}
		
		for(int i=0;i<total;i++){
			aadharNumbers[i]= output[i];
		}
	}
	
	private long GetMax(){
		long max= aadharNumbers[0];
		for(int i=1;i<total;i++){
			if(aadharNumbers[i]>max){
				max= aadharNumbers[i];
			}
		}
		return max;
	}
	
	public int BinarySearch(long target){
		int low= 0, high= total-1;
		
		while(low<=high){
			int mid= (low+high)/2;
			
			if(aadharNumbers[mid]==target){
				return mid;
			}
			if(aadharNumbers[mid]<target){
				low= mid+1;
			}else{
				high= mid-1;
			}
		}
		return -1;
	}
	
	public void DisplayAll(){
        if (total == 0)
        {
            Console.WriteLine("\nNo Aadhar-card available.");
            return;
        }
		Console.WriteLine("\nAadhar Numbers:");
		for(int i=0;i<total;i++){
			Console.WriteLine(aadharNumbers[i]);
		}
	}
}
