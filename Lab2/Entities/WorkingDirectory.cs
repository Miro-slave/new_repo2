namespace Lab2.Entities;
public class WorkingDirectory
{
    public WorkingDirectory(string absolutePath, string contextPath)
    {
        AbsolutePath = Guard.NotNull(absolutePath, nameof(absolutePath));
        ContextPath = Guard.NotNull(contextPath, nameof(contextPath));
    }

    public string AbsolutePath { get; set; }
    public string ContextPath { get; set; }
}
