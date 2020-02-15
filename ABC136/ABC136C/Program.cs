using System;
using System.Linq;

namespace ABC136C
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[] h = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long max = 0;
            string res = "Yes";
            for (int i = 0; i < n; i++)
            {
                if (max > h[i])
                {
                    res = "No";
                    break;
                }
                max = Math.Max(max, h[i] - 1);
            }

            Console.WriteLine(res);
        }
    }
}
