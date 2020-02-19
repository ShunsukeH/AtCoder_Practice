using System;
using System.Linq;

namespace ABC134B
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] nd = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int checkable = (nd[1] * 2) + 1;
            Console.WriteLine(Math.Ceiling((double)nd[0] / checkable));
        }
    }
}
