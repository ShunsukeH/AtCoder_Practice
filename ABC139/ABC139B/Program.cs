using System;
using System.Linq;

namespace ABC139B
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] s = Console.ReadLine().Split(' ').Select(e => int.Parse(e)).ToArray();
            int res = 1;
            int cnt = 0;
            while (res < s[1])
            {
                cnt++;
                res = s[0] * cnt - (cnt - 1);
            }

            Console.WriteLine(cnt);
        }
    }
}
