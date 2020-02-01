using System;
using System.Collections.Generic;
using System.Linq;

namespace ABC142D
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            long[] ab = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
            long gcd = Gcd(ab[0], ab[1]);
            var primes = FactorizePrimes(gcd);
            Console.WriteLine(primes.Distinct().Count() + 1);
        }

        public static long Gcd(long a, long b)
        {
            Func<long, long, long> gcd = null;
            gcd = (x, y) => y == 0 ? x : gcd(y, x % y);
            return a > b ? gcd(a, b) : gcd(b, a);
        }

        static IEnumerable<long> FactorizePrimes(long n)
        {
            long i = 2;
            long temp = n;
            while (i < Math.Sqrt(n))
            {
                if (temp % i == 0)
                {
                    temp /= i;
                    yield return i;
                }
                else i++;
            }
            if (temp != 1) yield return temp;
        }
    }
}
