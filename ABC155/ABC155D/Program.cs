using System;
using System.Linq;

namespace ABC155D
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
        }
    }
}
