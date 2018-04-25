namespace Hosts.Editor.Domain
{
    public interface IHostsFile
    {
        string Content { get; set; }

        bool CheckIfDefaultFileExists();
        void Load(string filePath);
        void LoadFromDefaultLocation();
        void Save(string filePath);
        void SaveToDefaultLocation();
    }
}