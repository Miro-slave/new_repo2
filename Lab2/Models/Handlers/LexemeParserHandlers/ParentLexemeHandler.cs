using Lab2.Exceptions;
using Lab2.Models.Commands;
using Lab2.Models.Handlers.CommandParserHandlers;
using Lab2.Services.Parsers;

namespace Lab2.Models.Handlers.LexemeParserHandlers;
public class ParentLexemeHandler : ILexemeParserHandler
{
    private ILexemeParserHandler _headHandler;

    public ParentLexemeHandler()
    {
        ArgumentLexemeHandler argementLexemeHandler = new ArgumentLexemeHandler(null);
        FlagLexemeHandler flagLexemeHandler = new FlagLexemeHandler(argementLexemeHandler);
        CommandLexemeHandler commandLexemeHandler = new CommandLexemeHandler(flagLexemeHandler);

        _headHandler = commandLexemeHandler;
    }

    public Lexeme Handle(string rawLexeme)
    {
        Guard.NotNull(rawLexeme, nameof(rawLexeme));

        return _headHandler.Handle(rawLexeme);
    }
}
