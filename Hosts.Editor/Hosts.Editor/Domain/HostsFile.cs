using System;

namespace Hosts.Editor.Domain
{
    public class HostsFile : IHostsFile
    {
        public HostsFile(IFileManager fileManager)
        {
            FileManager = fileManager ?? throw new ArgumentNullException(nameof(fileManager));
        }

        public const string DefaultFileName = "hosts";
        public static readonly string DefaultPath = $"{Environment.GetFolderPath(Environment.SpecialFolder.System)}\\drivers\\etc\\";
        public static readonly string DefaultLocation = $"{DefaultPath}{DefaultFileName}";
        
        protected IFileManager FileManager { get; }

        public bool DefaultFileExists
        {
            get
            {
                return FileManager.CheckIfFileExists(DefaultLocation);
            }
        }

        public string Content { get; set; }

        public void Load(string filePath)
        {
            Content = FileManager.Load(filePath);
        }

        public void LoadFromDefaultLocation()
        {
            Content = FileManager.Load(DefaultLocation);
        }

        public void Save(string filePath)
        {
            FileManager.Save(Content, filePath);
        }

        public void SaveToDefaultLocation()
        {
            Save(DefaultLocation);
        }

    }
}