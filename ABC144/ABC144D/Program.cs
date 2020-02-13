using System;
using System.Linq;

namespace ABC144D
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] abx = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            decimal fillRate = (decimal) abx[2] / (abx[0] * abx[0] * abx[1]);
            Console.WriteLine((decimal)90*(1-fillRate));
        }
    }
}
