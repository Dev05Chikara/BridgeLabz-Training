using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class RoleAllowedAttribute : Attribute{
    public string Role;
    public RoleAllowedAttribute(string role){
        Role= role;
    }
}

class AdminPanel{
    [RoleAllowed("ADMIN")]
    public void DeleteUser(){
        Console.WriteLine("User deleted");
    }
}

class RoleDemo{
    static void Main(){
        string currentRole= "USER";
        MethodInfo m= typeof(AdminPanel).GetMethod("DeleteUser");

        RoleAllowedAttribute r=
            (RoleAllowedAttribute)Attribute.GetCustomAttribute(
                m, typeof(RoleAllowedAttribute));

        if(r.Role==currentRole){
            m.Invoke(new AdminPanel(),null);
        }else{
            Console.WriteLine("Access Denied!");
        }
    }
}
