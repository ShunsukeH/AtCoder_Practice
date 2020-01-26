using System;
using System.Linq;

namespace ABC153C
{
    public class EmptyClass
    {
        public static void Main(string[] args)
        {
            long[] n = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
            long[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
            Console.WriteLine(arr.OrderByDescending(e => e).Skip((int)n[1]).Sum());

        }
    }
}
