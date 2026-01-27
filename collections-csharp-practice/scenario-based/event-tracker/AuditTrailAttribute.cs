using System;

[AttributeUsage(AttributeTargets.Method)]
public class AuditTrailAttribute : Attribute
{
    public string ActionName { get; set; }

    public AuditTrailAttribute(string actionName)
    {
        ActionName= actionName;
    }
}
