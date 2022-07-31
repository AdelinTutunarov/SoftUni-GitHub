using System;

namespace _2._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            var article = new Article(input[0], input[1], input[2]);
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(": ");
                if (command[0] == "Edit") article.Edit(command[1]);
                else if (command[0] == "ChangeAuthor") article.ChangeAuthor(command[1]);
                else if (command[0] == "Rename") article.Rename(command[1]);
            }
            Console.WriteLine(article);
        }
    }
}
