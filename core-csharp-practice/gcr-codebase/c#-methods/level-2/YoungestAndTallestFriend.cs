using System;
class YoungestAndTallestFriend{
    static int FindYoungest(int[] Ages){
        int Min = Ages[0];
        for(int i=1;i<Ages.Length;i++) if(Ages[i] < Min) Min = Ages[i];
        return Min;
    }
    static double FindTallest(double[] Heights){
        double Max = Heights[0];
        for(int i=1;i<Heights.Length;i++) if(Heights[i] > Max) Max = Heights[i];
        return Max;
    }
    static void Main(){
        int[] Ages = new int[3];
        double[] Heights = new double[3];
        for(int i=0;i<3;i++){
            Console.Write("Enter age: ");
            Ages[i] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter height: ");
            Heights[i] = double.Parse(Console.ReadLine());
        }
        Console.WriteLine("Youngest age: "+FindYoungest(Ages));
        Console.WriteLine("Tallest height: "+FindTallest(Heights));
    }
}
