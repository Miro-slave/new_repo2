using Lab2.Entities;
using Lab2.Models;
using Lab2.Models.Commands;
using Lab2.Services.Parsers;
using System.Collections.Generic;
using static Lab2.Services.Parsers.LexemeType;

namespace Lab2.Services;

public class CommandInvoker : ICommandInvoker
{
    private ICommandParser _commandParser;

    private FileSystem? _fileSystem;

    private ICommand? _command;

    public CommandInvoker()
    {
        _commandParser = new CommandParser();
        _fileSystem = null;
        _command = null;
    }

    public void SetCommand(List<Lexeme> lexemes, FileSystem fileSystem)
    {
        Guard.NotNull(lexemes, nameof(lexemes));
        Guard.NotNull(fileSystem, nameof(fileSystem));
        _fileSystem = fileSystem;
        _command = _commandParser.Parse(lexemes, fileSystem);
    }

    public void Invoke()
    {
        Guard.NotNull(_fileSystem, nameof(_fileSystem));
        Guard.NotNull(_command, nameof(_command));

        _command.Execute(_fileSystem);
    }
}
