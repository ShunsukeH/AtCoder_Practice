using System;
using System.Linq;

namespace ABC133A
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] nab = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(nab[0] * nab[1] > nab[2] ? nab[2] : nab[0] * nab[1]);
        }
    }
}
