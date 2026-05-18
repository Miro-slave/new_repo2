using Lab2.Entities;

namespace Lab2.Adapters;
public interface IConsoleUserAdapter
{
    public void RunCommand(string input, FileSystem fileSystem);
}
