using System;
using System.Linq;

namespace ABC133C
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            long[] lr = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long res = 2020;

            if (lr[1]-lr[0]>=2018)
            {
                Console.WriteLine(0);
                return;
            }

            for (long i = lr[0]; i <= lr[1]; i++)
            {
                for (long j = i+1; j <= lr[1]; j++)
                {
                    long tmp = (i * j) % 2019;
                    res = Math.Min(res, tmp);
                }
            }
            Console.WriteLine(res);
        }
    }
}
