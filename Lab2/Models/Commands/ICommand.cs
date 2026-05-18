using Lab2.Entities;

namespace Lab2.Models.Commands;
public interface ICommand
{
    public void Execute(FileSystem fileSystem);
}
