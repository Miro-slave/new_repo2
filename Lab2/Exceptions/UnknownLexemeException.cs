using System;

namespace Lab2.Exceptions;

public class UnknownLexemeException : Exception
{
    public UnknownLexemeException()
    {
    }

    public UnknownLexemeException(string message)
        : base(message)
    {
    }

    public UnknownLexemeException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
