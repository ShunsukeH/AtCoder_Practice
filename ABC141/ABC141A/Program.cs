using System;
namespace ABC141A
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            Console.WriteLine(
                s == "Sunny" ? "Cloudy"
                : s == "Cloudy" ? "Rainy"
                : s == "Rainy" ? "Sunny" : ""
            );
        }
    }