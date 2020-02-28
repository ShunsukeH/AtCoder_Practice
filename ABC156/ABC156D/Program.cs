using System;
using System.Collections.Generic;
using System.Linq;

namespace ABC156D
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            long[] nab = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long[] numbers = new long[nab[0]];
            for (long i = 0; i < nab[0]; i++)
            {
                numbers[i] = i + 1;
            }
            ulong res = 0;
            for (long i = 1; i <= nab[0]; i++)
            {
                if (i == nab[1]|| i==nab[2])
                {
                    continue;
                }
                var combi = Enumerate(numbers, i, false);
                res += (ulong) combi.Count();
            }
            Console.WriteLine(res % (Math.Pow(10, 9) + 7));

        }

        public static IEnumerable<T[]> Enumerate<T>(IEnumerable<T> items, long k, bool withRepetition)
        {
            if (k == 1)
            {
                foreach (var item in items)
                    yield return new T[] { item };
                yield break;
            }
            foreach (var item in items)
            {
                var leftside = new T[] { item };

                // item よりも前のものを除く （順列と組み合わせの違い)
                // 重複を許さないので、unusedから item そのものも取り除く
                var unused = withRepetition ? items : items.SkipWhile(e => !e.Equals(item)).Skip(1).ToList();

                foreach (var rightside in Enumerate(unused, k - 1, withRepetition))
                {
                    yield return leftside.Concat(rightside).ToArray();
                }
            }
        }
    }
}
