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
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                if (i == 0) { a[i] = b[i]; continue; }
                if (i == n - 1) { a[i] = b[i - 1]; continue; }
                a[i] = Math.Min(b[i - 1], b[i]);
            }

            Console.WriteLine(a.Sum());
        }
    }
}
