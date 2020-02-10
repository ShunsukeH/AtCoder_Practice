using System;
using System.Linq;

namespace ABC139C
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] h = Console.ReadLine().Split(' ').Select(e => int.Parse(e)).ToArray();
            int last = 0;
            int cnt = 0;
            int max = 0;
            for (int i = 0; i < n; i++)
            {
                if (last >= h[i]) cnt++;
                else
                {
                    max = Math.Max(max, cnt);
                    cnt = 0;
                }
                last = h[i];
            }
            Console.WriteLine(Math.Max(max, cnt));
        }
    }
}