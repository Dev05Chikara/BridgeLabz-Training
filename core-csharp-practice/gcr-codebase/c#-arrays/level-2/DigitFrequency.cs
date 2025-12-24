using System;
class DigitFrequency{
	static void Main(){
		Console.Write("Enter a number: ");
		long Number=Convert.ToInt64(Console.ReadLine());
		long Temp=Number;
		int Count=0;
		while(Temp!=0){
			Count++;
			Temp/=10;
		}
		int[] Digits=new int[Count];
		int Index=0;
		Temp=Number;
		while(Temp!=0){
			Digits[Index]=(int)(Temp%10);
			Temp/=10;
			Index++;
		}
		int[] Frequency=new int[10];
		for(int i=0;i<Digits.Length;i++) Frequency[Digits[i]]++;
		for(int i=0;i<10;i++) if(Frequency[i]>0) Console.WriteLine("Digit "+i+" Frequency "+Frequency[i]);
	}
}
