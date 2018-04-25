namespace Hosts.Editor.Domain
{
    public interface IFileManager
    {
        void Save(string content, string fileName);
        string Load(string fileName);
        bool CheckIfFileExists(string fileName);
    }
}