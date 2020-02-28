using System;
using System.Linq;

namespace ABC132C
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] d = Console.ReadLine().Split().Select(int.Parse).OrderBy(e => e).ToArray();

            int center = (n / 2)-1;
            
            Console.WriteLine(d[center+1] - d[center]);
        }
    }
}
