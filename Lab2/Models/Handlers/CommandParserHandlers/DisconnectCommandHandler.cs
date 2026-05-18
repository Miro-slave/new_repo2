using System.Collections.Generic;
using Lab2.Entities;
using Lab2.Exceptions;
using Lab2.Models.Commands;
using Lab2.Services.Parsers;

namespace Lab2.Models.Handlers.CommandParserHandlers;
public class DisconnectCommandHandler : ICommandParserHandler
{
    public ICommand Handle(IEnumerator<Lexeme> lexemeIterator, FileSystem fileSystem)
    {
        Guard.NotNull(lexemeIterator, nameof(lexemeIterator));

        if (lexemeIterator.Current.Value == "disconnect" && lexemeIterator.Current.Type is LexemeType.Command)
        {
            return new DisconnectCommand();
        }

        return null;
    }
}