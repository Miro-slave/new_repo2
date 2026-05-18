namespace Lab2.Services.Parsers;
public abstract record LexemeType
{
    private LexemeType() { }
#pragma warning disable CA1034
    public sealed record Argument : LexemeType;

    public sealed record Flag : LexemeType;

    public sealed record Command : LexemeType;
#pragma warning restore CA1034
}