using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Field)]
class MaxLengthAttribute : Attribute{
    public int Length;
    public MaxLengthAttribute(int len){
        Length= len;
    }
}

class User{
    [MaxLength(5)]
    public string Username;

    public User(string name){
        FieldInfo f= typeof(User).GetField("Username");
        MaxLengthAttribute m=
            (MaxLengthAttribute)Attribute.GetCustomAttribute(
                f, typeof(MaxLengthAttribute));

        if(name.Length>m.Length){
            throw new ArgumentException("Username too long");
        }
        Username= name;
    }
}

class MaxLengthDemo{
    static void Main(){
        User u= new User("Dev");
        Console.WriteLine(u.Username);
    }
}
