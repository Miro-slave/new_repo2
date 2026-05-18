using Lab2.Entities;

namespace Lab2.Models.Commands;
public class DisconnectCommand : ICommand
{
    public void Execute(FileSystem fileSystem)
    {
        Guard.NotNull(fileSystem, nameof(fileSystem));
        fileSystem.WorkingDirectory = null;
    }
}
