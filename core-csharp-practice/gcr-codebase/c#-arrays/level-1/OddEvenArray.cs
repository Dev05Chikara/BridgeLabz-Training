using System;
class OddEvenArray{
    static void Main(){
        Console.Write("Enter a number: ");
        int Number= int.Parse(Console.ReadLine());
        if (Number <= 0){
			Console.WriteLine("Error: Please enter a natural number.");
			return;
		}
        int Size= (Number/2)+1;
        int[] OddNumbers= new int[Size];
        int[] EvenNumbers= new int[Size];
        int OddIndex= 0;
        int EvenIndex= 0;
        for (int i=1; i<=Number; i++){
            if (i%2 == 0){
                EvenNumbers[EvenIndex]= i;
                EvenIndex++;
            }
            else{
                OddNumbers[OddIndex]= i;
                OddIndex++;
            }
        }
		Console.Write("\nOdd Numbers: ");
        for (int i=0; i<OddIndex; i++) Console.Write(OddNumbers[i]+" ");
        Console.Write("\nEven Numbers: ");
        for (int i=0; i<EvenIndex; i++) Console.Write(EvenNumbers[i]+" ");
    }
}
