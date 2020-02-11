using System;
using System.Linq;

namespace ABC138B
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = Console.ReadLine().Split(' ').Select(e => int.Parse(e)).ToArray();

            double d = a.Select(e => (double)1 / e).Sum();
            Console.WriteLine((double)1 / d);
        }
    }
}
