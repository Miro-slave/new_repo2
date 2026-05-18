using Lab2.Entities;

namespace Lab2.Models.Commands;
public class FileCopyCommand : ICommand
{
    private readonly Lexeme _filePath;
    private readonly Lexeme _fileDestinationPath;
    public FileCopyCommand(
        Lexeme filePath,
        Lexeme fileDestinationPath)
    {
        _filePath = Guard.NotNull(filePath, nameof(filePath));
        _fileDestinationPath = Guard.NotNull(fileDestinationPath, nameof(fileDestinationPath));
    }

    public void Execute(FileSystem fileSystem)
    {
        Guard.NotNull(fileSystem, nameof(fileSystem));
        System.IO.File.Copy(_filePath.Value, _fileDestinationPath.Value);
    }
}
