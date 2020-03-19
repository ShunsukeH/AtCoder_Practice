using System;
using System.Linq;

namespace Panasonic2020B
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            long[] hw = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long w = (long)Math.Ceiling((double)hw[1] / 2);
            long h = hw[0];
            long res;
            if (hw[0] == 1 || hw[1] == 1)
            {
                res = 1;
            }
            else if (h % 2 == 0)
            {
                res = hw[1] * (h / 2);
            }
            else
            {
                res = hw[1] * (h / 2) + w;
            }

            Console.WriteLine(res);
        }
    }
}
