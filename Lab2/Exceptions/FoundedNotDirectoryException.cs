using System;

namespace Lab2.Exceptions;

public class FoundedNotDirectoryException : Exception
{
    public FoundedNotDirectoryException()
    {
    }

    public FoundedNotDirectoryException(string message)
        : base(message)
    {
    }

    public FoundedNotDirectoryException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
