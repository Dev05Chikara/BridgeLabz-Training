using System;
class StoreNumbersAndSum {
    static void Main(){
        double[] Numbers= new double[10];
        double Total= 0.0;
        int Index= 0;
        Console.WriteLine("Enter numbers(To stop, enter 0 or negative number):");
        while (true){
            double Input= double.Parse(Console.ReadLine());
            if(Input<=0) break;
            if (Index == 10) break;
            Numbers[Index]= Input;
            Index++;
        }
        Console.WriteLine("\nStored Numbers:");
        for(int i=0; i<Index; i++){
            Console.WriteLine(Numbers[i]);
            Total += Numbers[i];
        }
        Console.WriteLine("\nTotal Sum = " + Total);
    }
}
