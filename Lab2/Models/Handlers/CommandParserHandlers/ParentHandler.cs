using System.Collections.Generic;
using Lab2.Entities;
using Lab2.Models.Commands;

namespace Lab2.Models.Handlers.CommandParserHandlers;
public class ParentHandler : ICommandParserHandler
{
    private IEnumerable<ICommandParserHandler> _successors;

    public ParentHandler()
    {
        _successors = new List<ICommandParserHandler>() { new FileCommandHandler() };
    }

    public ICommand Handle(IEnumerator<Lexeme> lexemeIterator, FileSystem fileSystem)
    {
        Guard.NotNull(lexemeIterator, nameof(lexemeIterator));

        foreach (ICommandParserHandler handler in _successors)
        {
            ICommand? result = handler.Handle(lexemeIterator, fileSystem);

            if (result is not null)
            {
                return result;
            }
        }

        return new DefaultCommand();
    }
}
