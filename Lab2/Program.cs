using Lab2.Adapters;
using Lab2.Clients;
using Lab2.Entities;


/*var consoleAdapter = new ConsoleUserAdapter();

var user = new ConsoleUser(consoleAdapter);

var fileSystem = new FileSystem(string.Empty);

bool result1 = user.TryRunCommand(@"file copy C:\Users\YF\Desktop\Texts\SAS1\a.txt C:\Users\YF\Desktop\Texts\SAS2\a.txt", fileSystem);

bool result2 = user.TryRunCommand(@"file delete C:\Users\YF\Desktop\Texts\SAS1\a.txt", fileSystem);

bool result3 = user.TryRunCommand(@"file move C:\Users\YF\Desktop\Texts\SAS2\a.txt C:\Users\YF\Desktop\Texts\SAS1\a.txt", fileSystem);

bool result4 = user.TryRunCommand(@"file show C:\Users\YF\Desktop\Texts\SAS1\a.txt", fileSystem);

bool result5 = user.TryRunCommand(@"file delete C:\Users\YF\Desktop\Texts\SAS1\a.txt", fileSystem);*/

internal static class Program
{
    private static void Main(string[] args)
    {
        var consoleAdapter = new ConsoleUserAdapter();

        var user = new ConsoleUser(consoleAdapter);

        var fileSystem = new FileSystem(string.Empty);

        user.TryRunCommand(string.Join(" ", args), fileSystem);
    }
}
