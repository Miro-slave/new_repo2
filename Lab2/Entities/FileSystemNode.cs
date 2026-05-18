namespace Lab2.Entities;
public abstract class FileSystemNode
{
    private readonly string _path;
    private readonly string _name;
    protected FileSystemNode(string path, string name)
    {
        Guard.NotNull(path, nameof(path));
        Guard.NotNull(name, nameof(name));
        _path = path;
        _name = name;
    }

    public string Path { get { return _path; } }
    public string Name { get { return _name; } }
}
