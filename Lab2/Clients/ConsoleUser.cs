using Lab2.Adapters;
using Lab2.Entities;

namespace Lab2.Clients;
public class ConsoleUser
{
    private IConsoleUserAdapter _consoleAdapter;

    public ConsoleUser(IConsoleUserAdapter consoleAdapter)
    {
        _consoleAdapter = consoleAdapter;
    }

    public bool TryRunCommand(string input, FileSystem fileSystem)
    {
        Guard.NotNull(input, nameof(input));

        _consoleAdapter.RunCommand(input, fileSystem);

        return true;
    }
}
