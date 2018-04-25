using System.IO;
using System.Text;

namespace Hosts.Editor.Domain
{
    public class FileManager : IFileManager
    {
        public void Save(string content, string fileName)
        {
            using (var writer = new StreamWriter(fileName, false, Encoding.UTF8))
            {
                writer.Write(content);
            }
        }

        public string Load(string fileName)
        {
            using (var reader = new StreamReader(fileName, Encoding.UTF8))
            {
                return reader.ReadToEnd();
            }
        }

        public bool CheckIfFileExists(string fileName)
        {
            return File.Exists(fileName);
        }
    }
}