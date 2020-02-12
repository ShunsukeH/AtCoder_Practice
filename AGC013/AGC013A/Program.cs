using System;
using System.Collections.Generic;
using System.Linq;

namespace AGC013A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int cnt = 1;
            int status = 0;
            for (int i = 0; i < n - 1; i++)
            {

                if (status > 0 && a[i + 1] - a[i] < 0)
                {
                    cnt++;
                    status = 0;
                    continue;
                }
                if (status < 0 && a[i + 1] - a[i] > 0)
                {
                    cnt++;
                    status = 0;
                    continue;
                }
                if (a[i] < a[i + 1]) status = 1;
                if (a[i] > a[i + 1]) status = -1;
            }

            Console.WriteLine(cnt);
        }
    }
}