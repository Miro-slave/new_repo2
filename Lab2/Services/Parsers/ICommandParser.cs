using System.Collections.Generic;
using Lab2.Entities;
using Lab2.Models;
using Lab2.Models.Commands;

namespace Lab2.Services.Parsers;
public interface ICommandParser
{
    public ICommand Parse(List<Lexeme> lexemes, FileSystem fileSystem);
}
