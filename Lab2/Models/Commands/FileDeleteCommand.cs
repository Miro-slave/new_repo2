using Lab2.Entities;

namespace Lab2.Models.Commands;
public class FileDeleteCommand : ICommand
{
    private readonly Lexeme _filePath;
    public FileDeleteCommand(Lexeme filePath)
    {
        _filePath = Guard.NotNull(filePath, nameof(filePath));
    }

    public void Execute(FileSystem fileSystem)
    {
        Guard.NotNull(fileSystem, nameof(fileSystem));
        FileSystemNode file = fileSystem.FindNode(_filePath.Value);
        System.IO.File.Delete(file.Name);
    }
}
