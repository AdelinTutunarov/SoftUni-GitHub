using System;
using System.Collections.Generic;

namespace _3._Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var articleList = new List<Article>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ");
                var article = new Article(input[0], input[1], input[2]);
                articleList.Add(article);
            }
            string str = Console.ReadLine();
            foreach (var i in articleList)
            {
                Console.WriteLine(i);
            }
        }
    }

    class Article
    {
        public Article(string title, string content, string author)
        {
            this.author = author;
            this.content = content;
            this.title = title;
        }
        private string title { get; set; }
        private string content { get; set; }
        private string author { get; set; }
        public override string ToString() => $"{title} - {content}: {author}";
    }
}
