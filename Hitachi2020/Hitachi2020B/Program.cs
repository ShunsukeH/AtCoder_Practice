using System;
using System.Linq;

namespace Hitachi2020B
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] abm = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] b = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int min = a.Min() + b.Min();
            int[][] ms = new int[abm[2]][];

            for (int i = 0; i < abm[2]; i++)
            {
                // ms[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
                var m = Console.ReadLine().Split().Select(int.Parse).ToArray();
                ChangeMin(ref min, a[m[0]-1] + b[m[1]-1] - m[2]);
            }

            Console.WriteLine(min);
        }

        static bool ChangeMin(ref int a, int b)
        {
            if (a > b)
            {
                a = b;
                return true;
            }
            return false;
        }

    }
}
