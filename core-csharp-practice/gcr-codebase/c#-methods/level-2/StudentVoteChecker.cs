using System;
class StudentVoteChecker{
    static bool CanStudentVote(int Age){
        if(Age < 0) return false;
        if(Age >= 18) return true;
        return false;
    }
    static void Main(){
        int[] Ages = new int[10];
        for(int i=0;i<10;i++){
            Console.Write("Enter age: ");
            Ages[i] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(CanStudentVote(Ages[i]));
        }
    }
}
