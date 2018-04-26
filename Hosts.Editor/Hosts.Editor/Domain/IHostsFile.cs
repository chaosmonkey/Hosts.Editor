namespace Hosts.Editor.Domain
{
    public interface IHostsFile
    {
        bool DefaultFileExists { get; }
        string Content { get; set; }
        void Load(string filePath);
        void LoadFromDefaultLocation();
        void Save(string filePath);
        void SaveToDefaultLocation();
    }
}