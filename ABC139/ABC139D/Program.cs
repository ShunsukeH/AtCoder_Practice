using System;

namespace ABC139D
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }

    }
}