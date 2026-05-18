using System.Collections.Generic;
using System.Linq;
using Lab2.Exceptions;
using Lab2.Services.Parsers;

namespace Lab2.Models.Handlers.LexemeParserHandlers;
public class ArgumentLexemeHandler : ILexemeParserHandler
{
    private List<char> _bannedSymbols = new List<char>() { '@', '<', '>', '|' };

    private ILexemeParserHandler? _successor;

    public ArgumentLexemeHandler(ILexemeParserHandler? successor)
    {
        _successor = successor;
    }

    public Lexeme Handle(string rawLexeme)
    {
        Guard.NotNull(rawLexeme, nameof(rawLexeme));

        bool containsBannedSymbols = rawLexeme.Any(c => _bannedSymbols.Contains(c));
        if (!containsBannedSymbols)
        {
            return new Lexeme(rawLexeme, new LexemeType.Command());
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