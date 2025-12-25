using System;
class HandshakesDirect{
    static void Main(){
        Console.Write("Enter number of students: ");
        int NumberOfStudents = Convert.ToInt32(Console.ReadLine());
        int Handshakes = (NumberOfStudents * (NumberOfStudents - 1)) / 2;
        Console.WriteLine("Maximum number of handshakes: "+Handshakes);
    }
}
