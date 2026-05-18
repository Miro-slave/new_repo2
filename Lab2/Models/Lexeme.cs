using Lab2.Services.Parsers;

namespace Lab2.Models;
public class Lexeme
{
    public Lexeme(string value, LexemeType type)
    {
        Guard.NotNull(value, nameof(value));
        Guard.NotNull(type, nameof(type));
        Value = value;
        Type = type;
    }

    public string Value { get; }
    public LexemeType Type { get; }
}
