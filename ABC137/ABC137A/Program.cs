using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ab = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int ans = ab[0] + ab[1];
            ans = Math.Max(ans, ab[0] - ab[1]);
            ans = Math.Max(ans, ab[0] * ab[1]);
            Console.WriteLine(ans);
        }
    }
}