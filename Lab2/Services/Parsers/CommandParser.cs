using System.Collections.Generic;
using Lab2.Entities;
using Lab2.Models;
using Lab2.Models.Commands;
using Lab2.Models.Handlers.CommandParserHandlers;

namespace Lab2.Services.Parsers;
public class CommandParser : ICommandParser
{
    private ICommandParserHandler _mainHandler;

    public CommandParser()
    {
        _mainHandler = new ParentHandler();
    }

    public ICommand Parse(List<Lexeme> lexemes, FileSystem fileSystem)
    {
        Guard.NotNull(lexemes, nameof(lexemes));
        Guard.NotNull(fileSystem, nameof(fileSystem));

        List<Lexeme>.Enumerator enumerator = lexemes.GetEnumerator();

        enumerator.MoveNext();

        ICommand result = _mainHandler.Handle(enumerator, fileSystem);

        return Guard.NotNull(result, nameof(result));
    }
}
