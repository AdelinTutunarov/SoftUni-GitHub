using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._Articles
{
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

        public void Edit(string content) => this.content = content;
        public void ChangeAuthor(string author) => this.author = author;
        public void Rename(string title) => this.title = title;
        public override string ToString() => $"{title} - {content}: {author}";
    }
}
