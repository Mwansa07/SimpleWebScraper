using System;

namespace SimpleWebScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter which city you would like to scrape information from:");
            var craigsListCity = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Please enter the CraigsList category that you would like to scrape:");
            var craigsListCategoryName = Console.ReadLine() ?? string.Empty;
        }
    }
}
