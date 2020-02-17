using System;
using System.Linq;

namespace ABC155B
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(a.Where(e => e % 2 == 0).Any(e => e % 3 != 0 && e % 5 != 0) ? "DENIED" : "APPROVED");

        }
    }
}
