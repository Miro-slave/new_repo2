using System.Collections.Generic;

namespace Lab2.Services.Parsers;
internal class PathParser : IPathParser
{
    private readonly char _separator = '\\';
    public IEnumerable<string> Parse(string path)
    {
        return path.Split(_separator);
    }
}
