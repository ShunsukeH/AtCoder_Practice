using System;
namespace ABC148C
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            long[] inp = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);

            long x = inp[0] * inp[1];
            if (inp[1] > inp[0])
            {
                long tmp = inp[0];
                inp[0] = inp[1];
                inp[1] = tmp;
            }

            long r = inp[0] % inp[1];
            while (r!=0)
            {
                inp[0] = inp[1];
                inp[1] = r;
                r = inp[0] % inp[1];
            }
            Console.WriteLine(x / inp[1]);
        }
    }
}
