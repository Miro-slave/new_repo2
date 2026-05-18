using System.IO;
using Lab2.Exceptions;
using Lab2.Services.Parsers;

namespace Lab2.Entities;
public class FileSystem : IFileSystem
{
    private readonly string _separatorString;
    private IPathParser _pathParser;

    public FileSystem(string absolutePath)
    {
        Guard.NotNull(absolutePath, nameof(absolutePath));
        WorkingDirectory = new WorkingDirectory(absolutePath, string.Empty);
        _pathParser = new PathParser();
        _separatorString = $"{Path.DirectorySeparatorChar}";
    }

    public FileSystemMode? Mode { get; set; }

    public WorkingDirectory? WorkingDirectory { get; set; }

    public Directory FindDirectory(string path)
    {
        if (WorkingDirectory is null)
        {
            throw new UndefinedWorkingDirectoryException();
        }

        string fullFilePath =
            WorkingDirectory.AbsolutePath +
            _separatorString +
            WorkingDirectory.ContextPath +
            _separatorString +
            path;

        if (!System.IO.File.Exists(fullFilePath))
        {
            throw new FileNotFoundException(fullFilePath);
        }
        else
        {
            Guard.NotNull(System.IO.Path.GetFileName(fullFilePath), "GetFileName( fullFilePath )");
            return new Directory(Path.GetFileName(fullFilePath), fullFilePath);
        }
    }

    public FileSystemNode FindNode(string path)
    {
        if (WorkingDirectory is null)
        {
            throw new UndefinedWorkingDirectoryException();
        }

        /*string fullFilePath =
            WorkingDirectory.AbsolutePath +
            _separatorString +
            WorkingDirectory.ContextPath +
            _separatorString +
            path;*/

        if (!System.IO.Directory.Exists(path) && !System.IO.File.Exists(path))
        {
            throw new FileNotFoundException(path);
        }
        else if (System.IO.Directory.Exists(path))
        {
            Guard.NotNull(System.IO.Path.GetDirectoryName(path), "GetDirectoryName( path )");
            return new Directory(Path.GetFileName(path), path);
        }
        else
        {
            Guard.NotNull(System.IO.Path.GetFileName(path), "GetFileName( path )");
            return new File(Path.GetFileName(path), path);
        }
    }
}
