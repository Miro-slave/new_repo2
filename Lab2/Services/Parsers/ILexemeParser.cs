using System.Collections.Generic;
using Lab2.Models;

namespace Lab2.Services.Parsers;
public interface ILexemeParser
{
    List<Lexeme> Parse(IEnumerable<string> input);
}
