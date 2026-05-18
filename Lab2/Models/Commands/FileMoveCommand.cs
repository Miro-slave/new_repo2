using Lab2.Entities;

namespace Lab2.Models.Commands;
public class FileMoveCommand : ICommand
{
    private readonly Lexeme _filePath;
    private readonly Lexeme _fileDestinationPath;
    public FileMoveCommand(
        Lexeme filePath,
        Lexeme fileDestinationPath)
    {
        _filePath = Guard.NotNull(filePath, nameof(filePath));
        _fileDestinationPath = Guard.NotNull(fileDestinationPath, nameof(fileDestinationPath));
    }

    public void Execute(FileSystem fileSystem)
    {
        /*Guard.NotNull(fileSystem, nameof(fileSystem));
        FileSystemNode file = fileSystem.FindNode(_filePath.Value);
        string fullPath = file.Path + "\\" + file.Name;*/
        System.IO.File.Copy(_filePath.Value, _fileDestinationPath.Value);
        System.IO.File.Delete(_filePath.Value);
    }
}