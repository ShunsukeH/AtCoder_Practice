using System;
using System.Linq;

namespace ABC132B
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] p = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int cnt = 0;
            for (int i = 1; i < n-1; i++)
            {
                int x = p[i];
                int[] subarr = { p[i - 1], p[i], p[i + 1] };
                if (subarr.OrderBy(e=>e).ToArray()[1] == x)
                {
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
        }
    }
}
