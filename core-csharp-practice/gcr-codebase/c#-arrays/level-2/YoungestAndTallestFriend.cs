using System;
class YoungestAndTallestFriend{
    static void Main(){
        string[] Names= {"Amar", "Akbar", "Anthony"};
        int[] Age= new int[3];
        double[] Height= new double[3];
        for(int i=0; i<3; i++){
            Console.WriteLine("\nEnter details for "+ Names[i]);
            Console.Write("Enter Age: ");
            Age[i]= int.Parse(Console.ReadLine());
            Console.Write("Enter Height(in cm): ");
            Height[i]= Convert.ToDouble(Console.ReadLine());
        }
        int YoungestIndex= 0;
        int TallestIndex= 0;
        for(int i=1; i<3; i++){
            if(Age[i]<Age[YoungestIndex]) YoungestIndex= i;
            if(Height[i]>Height[TallestIndex]) TallestIndex= i;
        }
        Console.WriteLine("\nYoungest Friend: "+Names[YoungestIndex]);
        Console.WriteLine("Tallest Friend: "+Names[TallestIndex]);
    }
}
