namespace Logger.Core.Utilities
{
    public static class PathValidator
    {
        public static bool PathExists(string path)
        {
            return Directory.Exists(path);
        }
    }
}
