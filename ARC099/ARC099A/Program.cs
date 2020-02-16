using System;
using System.Linq;

namespace ARC099A
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] nk = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = nk[0]-nk[1];
            int cnt = 1;
            while (n > 0)
            {
                n = (n + 1) - nk[1];
                cnt++;
            }
            Console.WriteLine(cnt);
        }
    }
}
