using System;
using System.Linq;
namespace ABC141B
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            Console.WriteLine(!s.Where((c, i) => (i + 1) % 2 == 1).Contains('L') && !s.Where((c, i) => (i + 1) % 2 == 0).Contains('R') ? "Yes" : "No");
        }
    }
}