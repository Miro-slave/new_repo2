using Lab2.Entities;
using Lab2.Services.Parsers;

namespace Lab2.Models.Commands;
public class ConnectCommand : ICommand
{
    private readonly Lexeme _address;
    private readonly Lexeme? _flag;
    private readonly Lexeme? _fileSystemMode;
    public ConnectCommand(
        Lexeme address,
        Lexeme? flag,
        Lexeme? fileSystemMode)
    {
        _address = Guard.NotNull(address, nameof(address));
        _flag = flag;
        _fileSystemMode = fileSystemMode;
    }

    public void Execute(FileSystem fileSystem)
    {
        Guard.NotNull(fileSystem, nameof(fileSystem));
        if (_flag is not null
            && _fileSystemMode is not null)
        {
            if (_fileSystemMode.Value == "local")
            {
                fileSystem.Mode = new FileSystemMode.Local();
            }
        }

        string absolutePath = _address.Value;
        Guard.NotNull(nameof(absolutePath), absolutePath);
        fileSystem.WorkingDirectory = new WorkingDirectory(absolutePath, string.Empty);
    }
}
