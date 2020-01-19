using System;

namespace ABC152
{
    public class EmptyClass
    {
        public static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long[] p = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);

            long min = n;
            long cnt = 0;
            for (int i = 0; i < n; i++)
            {
                if (p[i] <= min)
                {
                    min = p[i];
                    cnt++;
                    if (min == 1) break;
                    continue;
                }
            }
            Console.WriteLine(cnt);
        }
    }
}
