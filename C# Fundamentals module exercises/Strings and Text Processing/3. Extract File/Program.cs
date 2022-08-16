using System;

namespace _3._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string file = input.Substring(input.LastIndexOf("\\") + 1);
            string extension = file.Substring(file.IndexOf('.') + 1);
            file = file.Remove(file.LastIndexOf("."));
            Console.WriteLine($"File name: {file}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
