using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ABC135B
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] p = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int cnt = 0;
            for (int i = 0; i < n; i++)
            {
                if (p[i] != i + 1)
                {
                    cnt++;
                }
            }
            Console.WriteLine(cnt > 2 ? "NO" : "YES");
        }
    }
}