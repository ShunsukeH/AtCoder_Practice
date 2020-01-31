using System;
using System.Collections.Generic;
using System.Linq;

namespace ABC144C
{
    public class EmptyClass
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long i = 1;
            var xys = new List<long[]>();
            while (i <= Math.Sqrt(n))
            {
                if (n % i == 0)
                {
                    var xy = new long[] { i, n / i };
                    xys.Add(xy);
                }
                i++;
            }
            long[] sums = xys.Select(e => (e[0] - 1) + (e[1] - 1)).ToArray();
            Console.WriteLine(sums.Min());
        }
    }
}
