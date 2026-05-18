using System.Collections.Generic;
using Lab2.Entities;
using Lab2.Models;

namespace Lab2.Services;
public interface ICommandInvoker
{
    public void SetCommand(List<Lexeme> lexemes, FileSystem fileSystem);

    public void Invoke();
}
