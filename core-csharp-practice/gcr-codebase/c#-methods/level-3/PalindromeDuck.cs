using System;
class PalindromeDuck{
    static int[] StoreDigits(int Number){
        int L = Number.ToString().Length;
        int[] D = new int[L];
        for(int i=L-1;i>=0;i--){
            D[i] = Number % 10;
            Number /= 10;
        }
        return D;
    }
    static int[] ReverseArray(int[] A){
        int[] R = new int[A.Length];
        for(int i=0;i<A.Length;i++){
            R[i] = A[A.Length-1-i];
        }
        return R;
    }
    static bool CompareArrays(int[] A,int[] B){
        for(int i=0;i<A.Length;i++){
            if(A[i] != B[i]) return false;
        }
        return true;
    }
    static bool IsPalindrome(int[] Digits){
        return CompareArrays(Digits,ReverseArray(Digits));
    }
    static bool IsDuck(int[] Digits){
        for(int i=0;i<Digits.Length;i++){
            if(Digits[i] != 0) return true;
        }
        return false;
    }
    static void Main(){
        Console.Write("Enter Number: ");
        int N = int.Parse(Console.ReadLine());
        int[] D = StoreDigits(N);
        Console.WriteLine("Palindrome: "+IsPalindrome(D));
        Console.WriteLine("Duck: "+IsDuck(D));
    }
}
