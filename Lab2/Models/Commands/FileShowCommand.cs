using Lab2.Entities;

namespace Lab2.Models.Commands;
public class FileShowCommand : ICommand
{
    private readonly Lexeme _address;
    private readonly Lexeme? _flag;
    private readonly Lexeme? _outputMode;
    public FileShowCommand(
        Lexeme address,
        Lexeme? flag,
        Lexeme? outputMode)
    {
        _address = Guard.NotNull(address, nameof(address));
        // _flag = Guard.NotNull(flag, nameof(flag));
        // _outputMode = Guard.NotNull(outputMode, nameof(outputMode));
    }

    public void Execute(FileSystem fileSystem)
    {
        Guard.NotNull(fileSystem, nameof(fileSystem));
        Guard.NotNull(fileSystem.WorkingDirectory, nameof(fileSystem.WorkingDirectory));

        Console.WriteLine(System.IO.File.ReadAllText(_address.Value));
    }
}
