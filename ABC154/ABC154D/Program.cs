using System;

namespace ABC154D
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nk = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            long[] p = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);

            double[] sums = new double[nk[0] + nk[1]];
            double temp = 0;
            for (int i = 0; i < nk[0]; i++)
            {
                sums[i] = temp + ((double)(p[i] + 1) / 2);
                temp = sums[i];
            }

            double res = sums[0 + nk[1] - 1];
            for (int i = 1; i < nk[0]; i++)
            {
                res = Math.Max(res, sums[i + nk[1] - 1] - sums[i - 1]);
            }
            Console.WriteLine(res);
        }
    }
}