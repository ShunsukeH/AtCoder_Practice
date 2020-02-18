using System;
using System.Linq;

namespace ABC135C
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[] a = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long[] b = Console.ReadLine().Split().Select(long.Parse).ToArray();

            long res = 0;
            for (int i = 0; i < n; i++)
            {
                long l = Math.Min(a[i] + a[i + 1], b[i]);
                res += l;
                if (l - a[i] > 0)
                {
                    a[i + 1] -= l - a[i];
                }
            }

            Console.WriteLine(res);
        }
    }
}
