using System;

namespace ABC144A
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inp = Console.ReadLine().Split(' ');
            int a = int.Parse(inp[0]);
            int b = int.Parse(inp[1]);

            if (a > 9 || b > 9)
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine(a * b);
            }

        }
    }
}