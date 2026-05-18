using System;

namespace Lab2.Exceptions;

public class UndefinedWorkingDirectoryException : Exception
{
    public UndefinedWorkingDirectoryException()
    {
    }

    public UndefinedWorkingDirectoryException(string message)
        : base(message)
    {
    }

    public UndefinedWorkingDirectoryException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
