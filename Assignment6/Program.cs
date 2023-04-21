using System;

namespace Assignment6;
class Program
{
    static void Main(string[] args)
    {
        News news = new News();
        news.ID = 1;
        news.Title = "ABC";
        news.PublishDate = "1/2/2023";
        news.Author = "ABC";
        news.Content = "abc";
        int[] rateList = new int[] { 4, 5, 3 };
        news.Calculate(rateList);
        news.Display();
    }
}

