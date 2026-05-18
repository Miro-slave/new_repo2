using System.Collections.Generic;
using Lab2.Entities;
using Lab2.Exceptions;
using Lab2.Models.Commands;
using Lab2.Services.Parsers;

namespace Lab2.Models.Handlers.CommandParserHandlers;
public class TreeCommandHandler : ICommandParserHandler
{
    private IEnumerable<ICommandParserHandler> _successors;

    public TreeCommandHandler(IEnumerable<ICommandParserHandler> successors)
    {
        Guard.NotNull(successors, nameof(successors));
        _successors = successors;
    }

    public ICommand Handle(IEnumerator<Lexeme> lexemeIterator, FileSystem fileSystem)
    {
        Guard.NotNull(lexemeIterator, nameof(lexemeIterator));
        if (lexemeIterator.Current.Value == "tree" && lexemeIterator.Current.Type is LexemeType.Command)
        {
            lexemeIterator.MoveNext();
            Lexeme argument1 = lexemeIterator.Current;
            if (argument1.Value == "goto")
            {
                lexemeIterator.MoveNext();
                Lexeme argument2 = lexemeIterator.Current;
                return new TreeGotoCommand(argument2);
            }
            else if (argument1.Value == "list")
            {
                lexemeIterator.MoveNext();
                Lexeme argument2 = lexemeIterator.Current;
                lexemeIterator.MoveNext();
                Lexeme argument3 = lexemeIterator.Current;
                lexemeIterator.MoveNext();
                Lexeme argument4 = lexemeIterator.Current;
                return new TreeListCommand(argument2, argument3, argument4);
            }
        }

        return null;
    }
}
