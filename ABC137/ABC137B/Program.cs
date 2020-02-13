using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] kx = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int min = kx[1] - (kx[0] - 1);
            int max = kx[1] + (kx[0] - 1);

            for (int i = min; i <= max; i++)
            {
                Console.Write(i);
                if (i != max) { Console.Write(' '); }
            }
        }
    }
}