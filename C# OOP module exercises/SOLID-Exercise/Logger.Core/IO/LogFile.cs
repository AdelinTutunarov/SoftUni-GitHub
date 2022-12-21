namespace Logger.Core.IO
{
    using System.Text;
    using Interfaces;
    using Exceptions;
    using Logger.Core.Utilities;
    
    public class LogFile : ILogFile
    {
        private string? name;
        private string? path;
        private readonly StringBuilder content;

        private LogFile()
        {
            content = new StringBuilder();
        }

        public LogFile(string name, string path) : this()
        {
            Name = name;
            Path = path;
        }

        public string Name
        {
            get { return name!; }
            private set
            {
                if (string.IsNullOrEmpty(value)) throw new InvalidFileNameException();
                name = value;
            }
        }

        public string Path
        {
            get { return path!; }
            private set
            {
                if (!PathValidator.PathExists(value)) throw new InvalidPathException();
                path = System.IO.Path.GetFullPath(value);
            }
        }

        public string Content => content.ToString();

        public int Size => content.Length;


        public void Write(string text)
        {
            content.Append(text);
        }

        public void WriteLine(string text)
        {
            content.AppendLine(text);
        }

        public void SaveContent()
        {
            File.WriteAllText(Path, Content);
            content.Clear();
        }
    }
}
