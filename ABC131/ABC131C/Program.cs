using System;
using System.Linq;

namespace ABC131C
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            long[] abcd = Console.ReadLine().Split().Select(long.Parse).ToArray();
            
            long bCnt = abcd[1] - calc(abcd[1],abcd[2]) - calc(abcd[1], abcd[3]) + calc(abcd[1], Lcm(abcd[2], abcd[3]));
            long aCnt = abcd[0]-1 - calc(abcd[0]-1, abcd[2]) - calc(abcd[0]-1, abcd[3]) + calc(abcd[0]-1, Lcm(abcd[2], abcd[3]));

            Console.WriteLine(bCnt - aCnt);
        }

        public static long calc(long x, long y)
        {
            return (long)x / y;
        }

        public static long Lcm(long a, long b)
        {
            return (a * b) / Gcd(a, b);
        }

        public static long Gcd(long a, long b)
        {
            if (a < b) return Gcd(b, a);
            while (b != 0)
            {
                var temp = a % b;
                a = b;
                b = temp;
            }
            return a;
        }
    }
}
