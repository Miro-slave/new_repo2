using Lab2.Entities;

namespace Lab2.Models.Commands;
public class TreeListCommand : ICommand
{
    private readonly Lexeme _lexeme1;
    private readonly Lexeme _lexeme2;
    private readonly Lexeme? _lexeme3;
    public TreeListCommand(
        Lexeme lexeme1,
        Lexeme lexeme2,
        Lexeme? lexeme3)
    {
        _lexeme1 = Guard.NotNull(lexeme1, nameof(lexeme1));
        _lexeme2 = Guard.NotNull(lexeme2, nameof(lexeme2));
        _lexeme3 = lexeme3;
    }

    public void Execute(FileSystem fileSystem)
    {
        throw new System.NotImplementedException();
    }
}