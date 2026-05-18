using System.Collections.Generic;
using Lab2.Entities;
using Lab2.Exceptions;
using Lab2.Models.Commands;
using Lab2.Services.Parsers;

namespace Lab2.Models.Handlers.CommandParserHandlers;
public class FileCommandHandler : ICommandParserHandler
{
    public ICommand Handle(IEnumerator<Lexeme> lexemeIterator, FileSystem fileSystem)
    {
        Guard.NotNull(lexemeIterator, nameof(lexemeIterator));

        if (lexemeIterator.Current.Value == "file" && lexemeIterator.Current.Type is LexemeType.Command)
        {
            lexemeIterator.MoveNext();
            Lexeme argument1 = lexemeIterator.Current;
            lexemeIterator.MoveNext();
            Lexeme argument2 = lexemeIterator.Current;
            lexemeIterator.MoveNext();
            Lexeme argument3 = lexemeIterator.Current;
            lexemeIterator.MoveNext();
            Lexeme argument4 = lexemeIterator.Current;

            if (argument1.Value == "show")
            {
                return new FileShowCommand(argument2, argument3, argument4);
            }
            else if (argument1.Value == "move")
            {
                return new FileMoveCommand(argument2, argument3);
            }
            else if (argument1.Value == "copy")
            {
                return new FileCopyCommand(argument2, argument3);
            }
            else if (argument1.Value == "delete")
            {
                return new FileDeleteCommand(argument2);
            }
            else if (argument1.Value == "rename")
            {
                return new TreeListCommand(argument2, argument3, argument4);
            }
        }

        return null;
    }
}
