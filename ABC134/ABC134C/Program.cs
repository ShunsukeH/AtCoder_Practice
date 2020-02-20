using System;

namespace ABC134C
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int max = 0;
            int secound = 0;
            int maxCnt = 0;
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                if (a[i] == max) maxCnt++;
                else if (a[i] > max)
                {
                    secound = max;
                    maxCnt = 1;
                    max = a[i];
                }
                else
                {
                    secound = Math.Max(secound, a[i]);
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (a[i] < max)
                {
                    Console.WriteLine(max);
                }
                else if(a[i] == max)
                {
                    Console.WriteLine(maxCnt > 1 ? max : secound);
                }
            }
        }
    }
}
