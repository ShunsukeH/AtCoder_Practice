using System;
using System.Linq;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int[] res = new int[n];
            for (int i = 0; i < n; i++)
            {
                for (int j = b.Length - 1; j >= 0; j--)
                {
                    if (b[j] == j + 1)
                    {
                        res[i] = b[j];
                        b = b.Where((e, k) => k != j).ToArray();
                        break;
                    }
                }
            }
            if (b.Length != 0)
            {
                Console.WriteLine(-1);
            }
            else
            {
                foreach (var item in res.Reverse())
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
