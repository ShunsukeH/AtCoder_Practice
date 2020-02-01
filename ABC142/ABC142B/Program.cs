using System;
using System.Linq;

namespace ABC142B
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] nk = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] h = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            Console.WriteLine(h.Where(e => e >= nk[1]).Count());
        }
    }
}
