using System.IO;

namespace NumberLogger
{
    public class FileLogger
    {
        private readonly string filePath;

        public FileLogger(string filePath)
        {
            this.filePath = filePath;
        }

        public void LogNumber(string number)
        {
            using (StreamWriter file = new StreamWriter(filePath, true))
            {
                file.WriteLine(number);
            }
        }

        public string ReadLogFile()
        {
            return File.ReadAllText(filePath);
        }
    }
}
