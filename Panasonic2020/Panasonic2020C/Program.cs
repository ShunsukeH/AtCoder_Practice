using System;
using System.Linq;

namespace Panasonic2020C
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            long[] abc = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long x = abc[2] - abc[0] - abc[1];

            Console.WriteLine(x > 0 && 4 * abc[0] * abc[1] < x * x ? "Yes" : "No");
        }
    }
}
