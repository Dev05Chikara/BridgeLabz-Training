using System;
public class InvalidContactException : Exception
{
    public InvalidContactException(string message) : base(message)
    {
    }
}
