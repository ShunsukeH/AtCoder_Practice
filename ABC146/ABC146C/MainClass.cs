using System;
namespace ABC146C
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            long[] inp = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
            long a = inp[0];
            long b = inp[1];
            long x = inp[2];

            long l = 0;
            long r = (long)(Math.Pow(10, 9) + 1);
            while (r-l>1)
            {
                long center = (l + r) / 2;
                Func<long, long> f = (c) => a * c + b * c.ToString().Length;
                if (f(center)<=x)
                {
                    l = center;
                }
                else
                {
                    r = center;
                }
            }
            Console.WriteLine(l);
        }
    }
}
