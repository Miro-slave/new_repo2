using Lab2.Entities;

namespace Lab2.Clients;
public interface IConsoleUser
{
    public void RunCommand(string input, FileSystem fileSystem);
}
