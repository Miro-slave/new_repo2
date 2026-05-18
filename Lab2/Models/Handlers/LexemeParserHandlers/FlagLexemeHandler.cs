using System.Collections.Generic;
using System.Linq;
using Lab2.Exceptions;
using Lab2.Services.Parsers;

namespace Lab2.Models.Handlers.LexemeParserHandlers;
public class FlagLexemeHandler : ILexemeParserHandler
{
    private List<char> _bannedSymbols = new List<char>() { '@', '<', '>', '\"', '|', '\'', '\\', '/' };

    private ILexemeParserHandler? _successor;

    public FlagLexemeHandler(ILexemeParserHandler? successor)
    {
        _successor = successor;
    }

    public Lexeme Handle(string rawLexeme)
    {
        Guard.NotNull(rawLexeme, nameof(rawLexeme));

        bool containsBannedSymbols = rawLexeme.Any(c => _bannedSymbols.Contains(c));
        if ((rawLexeme[0] == '-' && char.IsLower(rawLexeme[1]))
            || !containsBannedSymbols)
        {
            return new Lexeme(rawLexeme, new LexemeType.Flag());
        }
        else if (_successor is not null)
        {
            return _successor.Handle(rawLexeme);
        }
        else
        {
            throw new UnknownLexemeException();
        }
    }
}
