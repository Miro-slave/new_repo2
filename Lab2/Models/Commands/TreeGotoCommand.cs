using Lab2.Entities;

namespace Lab2.Models.Commands;
public class TreeGotoCommand : ICommand
{
    private readonly Lexeme _address;

    public TreeGotoCommand(Lexeme address)
    {
        _address = Guard.NotNull(address, nameof(address));
    }

    public void Execute(FileSystem fileSystem)
    {
        Guard.NotNull(fileSystem, nameof(fileSystem));

        string absolutePath = _address.Value;
        Guard.NotNull(nameof(absolutePath), absolutePath);
        fileSystem.WorkingDirectory = new WorkingDirectory(absolutePath, string.Empty);
    }
}
