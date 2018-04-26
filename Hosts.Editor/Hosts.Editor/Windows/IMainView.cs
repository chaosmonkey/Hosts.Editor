namespace Hosts.Editor.Windows
{
    public interface IMainView
    {
        string Content { get; set; }
        bool HasChanges { get; set; }
    }
}