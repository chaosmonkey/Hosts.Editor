using System;

namespace Hosts.Editor.Domain
{
    public class HostsFile
    {
        public HostsFile(IFileManager fileManager)
        {
            FileManager = fileManager ?? throw new ArgumentNullException(nameof(fileManager));
        }

        public const string DefaultFileName = "hosts";
        public static readonly string DefaultPath = $"{Environment.GetFolderPath(Environment.SpecialFolder.System)}\\drivers\\etc\\";
        public static readonly string DeafultLocation = $"{DefaultPath}{DefaultFileName}";
        

        protected IFileManager FileManager { get; }

        public string Content { get; set; }

        public void Load(string filePath)
        {

        }

        public void Save(string filePath)
        {

        }
    }
}