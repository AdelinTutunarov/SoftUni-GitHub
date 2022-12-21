namespace BorderControl.IO
{
    using Interfaces;
    using System.IO;

    public class FileWriter : IWriter
    {
        private string filePath;

        public FileWriter(string filePath)
        {
            FilePath = filePath;
        }

        public string FilePath
        {
            get { return filePath; }
            private set
            {
                //if (!Directory.Exists(value)) throw new InvalidPathExeption();
                filePath = value;
            }
        }

        public void Write(string text)
        {
            using (StreamWriter file = new StreamWriter(FilePath))
            {
                file.Write(text);
            }
        }

        public void WriteLine(string text)
        {
            using (StreamWriter file = new StreamWriter(FilePath))
            {
                file.WriteLine(text);
            }
        }
    }
}
