using System;
using System.Collections.Generic;
using System.Linq;
namespace ABC148D
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            var res = new List<int>();
            int i = 0;
            int idx = 0;
            while (i < n)
            {
                for (int j = idx; j < a.Length; j++)
                {
                    if (a[j] == i + 1)
                    {
                        res.Add(a[j]);
                        idx = j;
                        break;
                    }
                }
                if (res.Count() != i + 1)
                    break;
                else i++;
            }

            Console.WriteLine(res.Count() == 0 ? -1 : n - res.Count());

        }
    }
}