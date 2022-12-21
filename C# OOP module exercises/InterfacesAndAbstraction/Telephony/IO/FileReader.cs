namespace Telephony.IO
{
    using System;
    using System.IO;
    using Interfaces;
    using Telephony.Exeptions;
    public class FileReader : IReader
    {
        private string filePath;
        private string[] fileAllLines;

        public FileReader(string filePath)
        {
            FilePath = filePath;
            fileAllLines = File.ReadAllLines(filePath);
            RowNumber = 0;
        }

        public string FilePath
        {
            get { return filePath; }
            private set
            {
                if (!Directory.Exists(value)) throw new InvalidPathExeption();
                filePath = value;
            }
        }

        public int RowNumber { get; private set; }

        public string ReadLine()
        {
            if (RowNumber >= fileAllLines.Length) throw new InvalidOperationException("No more lines to read!");
            return fileAllLines[RowNumber++];
        }
    }
}
