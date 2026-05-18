using System.Collections.Generic;
using Lab2.Entities;
using Lab2.Models.Commands;

namespace Lab2.Models.Handlers.CommandParserHandlers;
public interface ICommandParserHandler
{
    public ICommand Handle(IEnumerator<Lexeme> lexemeIterator, FileSystem fileSystem);
}
