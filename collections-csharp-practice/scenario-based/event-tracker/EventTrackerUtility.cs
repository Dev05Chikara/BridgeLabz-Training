using System;
using System.Reflection;
using System.Text;

public class EventTrackerUtility
{
    public static void TrackEvents(object obj)
    {
        Type type = obj.GetType();
        MethodInfo[] methods = type.GetMethods();

        Console.WriteLine("\n--- AUDIT LOGS (JSON) ---\n");

        foreach (MethodInfo method in methods)
        {
            object[] attributes = method.GetCustomAttributes(typeof(AuditTrailAttribute), false);

            if (attributes.Length > 0)
            {
                AuditTrailAttribute audit =
                    (AuditTrailAttribute)attributes[0];

                method.Invoke(obj, null);

                AuditLog log = new AuditLog();
                log.Action = audit.ActionName;
                log.MethodName = method.Name;
                log.TimeStamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                Console.WriteLine(ConvertToJson(log));
            }
        }
    }

    static string ConvertToJson(AuditLog log)
    {
        StringBuilder sb = new StringBuilder();

        sb.Append("{ ");
        sb.Append("\"action\": \"" + log.Action + "\", ");
        sb.Append("\"method\": \"" + log.MethodName + "\", ");
        sb.Append("\"timestamp\": \"" + log.TimeStamp + "\" ");
        sb.Append("}");

        return sb.ToString();
    }
}
