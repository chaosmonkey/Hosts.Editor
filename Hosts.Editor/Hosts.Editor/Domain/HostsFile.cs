using ChaosMonkey.Guards;
using System;

namespace Hosts.Editor.Domain
{
    public class HostsFile : IHostsFile
    {
        public HostsFile(IFileManager fileManager)
        {
            Guard.IsNotNull(fileManager, nameof(fileManager));
            FileManager = fileManager;
        }

        public const string DefaultFileName = "hosts";
        public static readonly string DefaultPath = $"{Environment.GetFolderPath(Environment.SpecialFolder.System)}\\drivers\\etc\\";
        public static readonly string DefaultLocation = $"{DefaultPath}{DefaultFileName}";
        

        protected IFileManager FileManager { get; }

        public string Content { get; set; }

        public void Load(string filePath)
        {
            Guard.IsNotNullOrWhiteSpace(filePath, nameof(filePath));
            Content = FileManager.Load(filePath);
        }

        public void Save(string filePath)
        {
            Guard.IsNotNullOrWhiteSpace(filePath, nameof(filePath));
            FileManager.Save(Content, filePath);
        }

        public bool CheckIfDefaultFileExists()
        {
            return FileManager.CheckIfFileExists(DefaultLocation);
        }

        public void LoadFromDefaultLocation()
        {
            Load(DefaultLocation);
        }

        public void SaveToDefaultLocation()
        {
            Save(DefaultLocation);
        }
    }
}