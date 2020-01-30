using System;
using System.Collections.Generic;

namespace ABC145C
{
    public class EmptyClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var indexs = new int[n];
            int[][] xy = new int[n][];
            for (int i = 0; i < n; i++)
            {
                xy[i] = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                indexs[i] = i;
            }
            var perms = GeneratePermutation(indexs);
            double total = 0;
            foreach (var item in perms)
            {
                double subTotal = 0;
                for (int i = 0; i < item.Length-1; i++)
                {
                    subTotal += Math.Sqrt(Math.Pow(xy[item[i]][0] - xy[item[i + 1]][0], 2) + Math.Pow(xy[item[i]][1] - xy[item[i + 1]][1], 2));
                }
                total += subTotal;
            }
            Console.WriteLine(total / perms.Count);

        }

        static List<T[]> GeneratePermutation<T>(params T[] array) where T : IComparable
        {
            var a = new List<T>(array).ToArray();
            var res = new List<T[]>
            {
                new List<T>(a).ToArray()
            };
            var n = a.Length;
            var next = true;
            while (next)
            {
                next = false;
                int i;
                for (i = n - 2; i >= 0; i--)
                {
                    if (a[i].CompareTo(a[i + 1]) < 0)
                        break;
                }
                if (i < 0)
                    break;

                var j = n;
                do
                {
                    j--;
                } while (a[i].CompareTo(a[j]) > 0);

                if (a[i].CompareTo(a[j]) < 0)
                {
                    var tmp = a[i];
                    a[i] = a[j];
                    a[j] = tmp;
                    Array.Reverse(a, i + 1, n - i - 1);
                    res.Add(new List<T>(a).ToArray());
                    next = true;
                }
            }
            return res;
        }
    }
}
