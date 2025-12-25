using System;
class Handshakes{
    static int CalculateHandshakes(int NumberOfStudents){
        return (NumberOfStudents * (NumberOfStudents - 1)) / 2;
    }
    static void Main(){
        Console.Write("Enter number of students: ");
        int NumberOfStudents = Convert.ToInt32(Console.ReadLine());
        int Handshakes = CalculateHandshakes(NumberOfStudents);
        Console.WriteLine("Maximum number of handshakes: "+Handshakes);
    }
}
