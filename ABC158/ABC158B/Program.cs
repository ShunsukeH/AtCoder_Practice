using System;
using System.Linq;

namespace ABC158B
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            long[] nab = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long sumAb = nab[1] + nab[2];
            long cnt = nab[0] / sumAb;
            long mod = nab[0] % sumAb;
            long res = nab[1] * cnt;
            res += mod > nab[1] ? nab[1] : mod;
            Console.WriteLine(res);
        }
    }
}
