namespace Lab2.Entities;
public interface IFileSystem
{
    public FileSystemNode FindNode(string path);
    public Directory FindDirectory(string path);
}
