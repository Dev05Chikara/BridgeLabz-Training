using System;

public class UserActions
{
    [AuditTrail("User Login")]
    public void Login()
    {
        Console.WriteLine("User logged in");
    }

    [AuditTrail("File Upload")]
    public void UploadFile()
    {
        Console.WriteLine("File uploaded");
    }

    [AuditTrail("Delete File")]
    public void DeleteFile()
    {
        Console.WriteLine("File deleted");
    }

    public void ViewDashboard()
    {
        Console.WriteLine("Dashboard viewed (no audit)");
    }
}
