using System.Collections.Generic;
using Lab2.Models;
using Lab2.Models.Handlers.LexemeParserHandlers;

namespace Lab2.Services.Parsers;
public class LexemeParser : ILexemeParser
{
    private ILexemeParserHandler? _mainLexemeParserHandler;

    public LexemeParser()
    {
        _mainLexemeParserHandler = new ParentLexemeHandler();
    }

    public List<Lexeme> Parse(IEnumerable<string> input)
    {
        Guard.NotNull(input, nameof(input));

        var result = new List<Lexeme>();
        foreach (string rawLexeme in input)
        {
            Guard.NotNull(rawLexeme, nameof(rawLexeme));
            if (_mainLexemeParserHandler is not null)
            {
                result.Add(_mainLexemeParserHandler.Handle(rawLexeme));
            }
        }

        return result;
    }
}
