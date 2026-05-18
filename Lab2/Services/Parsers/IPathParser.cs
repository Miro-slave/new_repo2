using System.Collections.Generic;

namespace Lab2.Services.Parsers;
public interface IPathParser
{
    public IEnumerable<string> Parse(string path);
}
