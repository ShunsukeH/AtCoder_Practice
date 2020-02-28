using System;
using System.Linq;

namespace ABC156A
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] nk = Console.ReadLine().Split().Select(int.Parse).ToArray();
        
            Console.WriteLine(nk[0] >= 10 ? nk[1] : nk[1] + (100 * (10 - nk[0])));
        }
    }
}
