using System;
class FizzBuzzArray{
    static void Main(){
        Console.Write("Enter a positive number: ");
        int Number= int.Parse(Console.ReadLine());
        if (Number <= 0)
        {
            Console.WriteLine("Invalid input. Enter a positive integer.");
            return;
        }
        string[] Results= new string[Number+1];
        for(int i=0; i<Results.Length; i++){
            if (i == 0) Results[i]= "0";
            else if(i%3 == 0 && i%5 == 0) Results[i]= "FizzBuzz";
            else if (i % 3 == 0) Results[i]= "Fizz";
            else if (i % 5 == 0) Results[i]= "Buzz";
            else Results[i] = i.ToString();
        }
        for(int i=1; i<=Number; i++) Console.WriteLine("Position "+i+" = "+Results[i]);
    }
}
