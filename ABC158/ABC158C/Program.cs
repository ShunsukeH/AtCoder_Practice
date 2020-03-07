using System;
using System.Linq;

namespace ABC158C
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] ab = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int res = -1;
            for (int i = 1; i <= 10000; i++)
            {
                if ((int)Math.Floor(i * 1.08)==i+ab[0] && (int)Math.Floor(i * 1.10) == i + ab[1])
                {
                    res = i;
                    break;
                }
            }
            Console.WriteLine(res);
        }
    }
}
