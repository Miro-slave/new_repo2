using System.Collections.Generic;
using Lab2.Entities;
using Lab2.Exceptions;
using Lab2.Models.Commands;
using Lab2.Services.Parsers;

namespace Lab2.Models.Handlers.CommandParserHandlers;
public class ConnectCommandHandler : ICommandParserHandler
{
    public ICommand? Handle(IEnumerator<Lexeme> lexemeIterator, FileSystem fileSystem)
    {
        Guard.NotNull(lexemeIterator, nameof(lexemeIterator));

        if (lexemeIterator.Current.Value == "connect" && lexemeIterator.Current.Type is LexemeType.Command)
        {
            lexemeIterator.MoveNext();
            Lexeme argument1 = lexemeIterator.Current;
            lexemeIterator.MoveNext();
            Lexeme argument2 = lexemeIterator.Current;
            lexemeIterator.MoveNext();
            Lexeme argument3 = lexemeIterator.Current;

            return new ConnectCommand(argument1, argument2, argument3);
        }

        return null;
    }
}
