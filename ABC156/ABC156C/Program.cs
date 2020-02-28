using System;
using System.Linq;

namespace ABC156C
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] x = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int min = x.Min();
            int max = x.Max();
            int center = (int) Math.Ceiling(x.Average());

            long ans = long.MaxValue;
            for (int i = 1; i <= center; i++)
            {
                long sum = 0;
                foreach (var item in x)
                {
                    sum += (long)Math.Pow((item - i), 2);
                }
                ans = Math.Min(ans, sum);
            }

            Console.WriteLine(ans);
        }
    }
}
