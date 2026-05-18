namespace Lab2.Services.Parsers;
public abstract record FileSystemMode
{
    private FileSystemMode() { }
#pragma warning disable CA1034
    public sealed record Local : FileSystemMode;
#pragma warning restore CA1034
}
