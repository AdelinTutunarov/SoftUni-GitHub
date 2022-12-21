namespace EvenLines
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            Console.WriteLine(ProcessLines(inputFilePath));
        }
        public static string ProcessLines(string inputFilePath)
        {
            StringBuilder sb = new StringBuilder();
            using (StreamReader streamReader = new StreamReader(inputFilePath))
            {
                string line = "";
                int count = 0;
                while (line!=null)
                {
                    line = streamReader.ReadLine();
                    if (count % 2 == 0)
                    {
                        sb.Append(ReverseWords(ReplaceSymbols(line)));
                    }
                    count++;
                }
            }
            return sb.ToString().TrimEnd();
        }
        private static string ReplaceSymbols(string line)
        {
            string[] symbolsToReplace = { "-", ",", ".", "!", "?" };

            foreach (var symbol in symbolsToReplace)
            {
                line = line.Replace(symbol, "@");
            }
            return line;
        }
        private static string ReverseWords(string replacedSymbols)
        {
            string[] reversedWords = replacedSymbols
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToArray();

            return string.Join(" ", reversedWords);
        }
    }
}
