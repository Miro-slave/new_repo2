using System.Collections.Generic;
using Lab2.Entities;
using Lab2.Models;
using Lab2.Services;
using Lab2.Services.Parsers;

namespace Lab2.Adapters;
public class ConsoleUserAdapter : IConsoleUserAdapter
{
    private LexemeParser _lexemeParser;
    private ICommandInvoker _commandInvoker;

    public ConsoleUserAdapter()
    {
        _lexemeParser = new LexemeParser();
        _commandInvoker = new CommandInvoker();
    }

    public void RunCommand(string input, FileSystem fileSystem)
    {
        Guard.NotNull(input, nameof(input));
        IEnumerable<string> rawLexemes = input.Split(' ');
        List<Lexeme> lexemes = _lexemeParser.Parse(rawLexemes);
        _commandInvoker.SetCommand(lexemes, fileSystem);
        _commandInvoker.Invoke();
    }
}
