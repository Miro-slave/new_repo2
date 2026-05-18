using Lab2.Entities;

namespace Lab2.Models.Commands;
public class DefaultCommand : ICommand
{
    public DefaultCommand()
    {
    }

    public void Execute(FileSystem fileSystem)
    {
        Guard.NotNull(fileSystem, nameof(fileSystem));
    }
}