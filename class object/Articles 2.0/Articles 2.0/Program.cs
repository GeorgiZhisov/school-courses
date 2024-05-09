using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        int numArticles = int.Parse(Console.ReadLine());

        List<Article> articles = new List<Article>();

        for (int i = 0; i < numArticles; i++)
        {
            string[] articleData = Console.ReadLine().Split(", ");
            string title = articleData[0];
            string content = articleData[1];
            string author = articleData[2];

            Article article = new Article(title, content, author);
            articles.Add(article);
        }

        foreach (var article in articles)
        {
            Console.WriteLine(article);
        }
    }
}

class Article
{
    public string Title { get; private set; }
    public string Content { get; private set; }
    public string Author { get; private set; }

    public Article(string title, string content, string author)
    {
        Title = title;
        Content = content;
        Author = author;
    }

    public override string ToString()
    {
        return $"{Title} - {Content}: {Author}";
    }
}


