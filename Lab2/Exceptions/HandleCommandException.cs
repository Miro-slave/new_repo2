using System;

namespace Lab2.Exceptions;

public class HandleCommandException : Exception
{
    public HandleCommandException()
    {
    }

    public HandleCommandException(string message)
        : base(message)
    {
    }

    public HandleCommandException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
