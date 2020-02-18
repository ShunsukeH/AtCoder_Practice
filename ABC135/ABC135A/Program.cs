using System;
using System.Linq;

namespace ABC135A
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] ab = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long n = ab[0] + ab[1];
            Console.WriteLine(n % 2 == 0 ? (n / 2).ToString() : "IMPOSSIBLE");
        }
    }
}