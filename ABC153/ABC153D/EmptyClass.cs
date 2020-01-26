using System;
namespace ABC153D
{
    public class EmptyClass
    {
        public static void Main(string[] args)
        {
            long h = long.Parse(Console.ReadLine());
            long cnt = 0;
            long i = 0;
            while (h>0)
            {
                h /= 2;
                cnt += (long) Math.Pow(2, i);
                i++;
            }
            Console.WriteLine(cnt);
        }
    }
}
