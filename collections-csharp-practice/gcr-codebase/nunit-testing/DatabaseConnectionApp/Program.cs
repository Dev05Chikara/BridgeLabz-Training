using System;

namespace DatabaseConnectionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DatabaseConnection db = new DatabaseConnection();

            db.Connect();
            Console.WriteLine("Connected: " + db.IsConnected);

            db.Disconnect();
            Console.WriteLine("Connected: " + db.IsConnected);

            Console.ReadLine();
        }
    }
}
