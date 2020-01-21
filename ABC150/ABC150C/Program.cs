using System;
using System.Collections.Generic;

namespace ABC150C
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] p = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = i + 1;
            }

            var perms = GeneratePermutation<int>(arr);

            int pIndex = perms.FindIndex(e => {
                for (int i = 0; i < e.Length; i++)
                {
                    if (e[i] != p[i])
                    {
                        return false;
                    }
                }
                return true;
            }) + 1;
            int qIndex = perms.FindIndex(e => {
                for (int i = 0; i < e.Length; i++)
                {
                    if (e[i] != q[i])
                    {
                        return false;
                    }
                }
                return true;
            }) + 1;
            Console.WriteLine(Math.Abs(pIndex - qIndex));

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