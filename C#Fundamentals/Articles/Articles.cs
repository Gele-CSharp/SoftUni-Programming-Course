using System;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] articleInfo = Console.ReadLine().Split(new string[] { ", "}, StringSplitOptions.RemoveEmptyEntries);
            string title = articleInfo[0];
            string content = articleInfo[1];
            string author = articleInfo[2];

            Article article = new Article(title, content, author);

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split(new string[] {": "}, StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Edit")
                {
                    string newContent = command[1];
                    article = article.Edit(article, newContent);
                }
                else if (command[0] == "ChangeAuthor")
                {
                    string newAuthor = command[1];
                    article = article.ChangeAuthor(article, newAuthor);
                }
                else if (command[0] == "Rename")
                {
                    string newTitle = command[1];
                    article = article.Rename(article, newTitle);
                }
            }

            Console.WriteLine(article);
        }

        class Article
        {
            public Article(string title, string content, string author)
            {
                Title = title;
                Content = content;
                Author = author;
            }

            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }

            public Article Edit(Article article, string newContent)
            {
                article.Content = newContent;
                return article;
            }

            public Article ChangeAuthor(Article article, string newAuthor)
            {
                article.Author = newAuthor;
                return article;
            }

            public Article Rename(Article article, string newTitle)
            {
                article.Title = newTitle;
                return article;
            }

            public override string ToString()
            {
                return ($"{Title} - {Content}: {Author}").ToString();
            }
        }
    }
}
