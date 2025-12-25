using System;
class OTPGenerator{
    static Random R = new Random();
    static int GenerateOTP(){
        return R.Next(100000,1000000);
    }
    static bool IsUnique(int[] Otp){
        for(int i=0;i<Otp.Length;i++){
            for(int j=i+1;j<Otp.Length;j++){
                if(Otp[i] == Otp[j]) return false;
            }
        }
        return true;
    }
    static void Main(){
        int[] Otp = new int[10];
        for(int i=0;i<10;i++){
            Otp[i] = GenerateOTP();
            Console.WriteLine(Otp[i]);
        }
        Console.WriteLine("All Unique: "+IsUnique(Otp));
    }
}
