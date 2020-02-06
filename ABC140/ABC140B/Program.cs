using System;
using System.Linq;
namespace ConsoleApp1
{
    class ABC140B
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int res = b.Sum();
            for (int i = 0; i < n - 1; i++)
            {
                if (a[i + 1] - a[i] == 1)
                {
                    res += c[a[i] - 1];
                }
            }

            Console.WriteLine(res);
        }
    }
}