using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            var groups = RunLengthEncoding(s).ToArray();
            var res = new List<long>();
            for (int i = 0; i < groups.Length; i += 2)
            {
                long rCnt = groups[i].Item2;
                long lCnt = groups[i + 1].Item2;
                for (int r = 0; r < rCnt - 1; r++) res.Add(0);
                if ((rCnt + lCnt) % 2 == 0)
                {
                    res.Add((rCnt + lCnt) / 2);
                    res.Add((rCnt + lCnt) / 2);
                }
                else if (rCnt % 2 == 0)
                {
                    // 全体がODDかつRがEven
                    res.Add((rCnt + lCnt - 1) / 2);
                    res.Add((rCnt + lCnt + 1) / 2);
                }
                else
                {
                    // 全体がODDかつRがOdd
                    res.Add((rCnt + lCnt + 1) / 2);
                    res.Add((rCnt + lCnt - 1) / 2);
                }
                for (int l = 0; l < lCnt - 1; l++) res.Add(0);
            }
            Console.WriteLine(string.Join(" ", res));
        }

        static IEnumerable<Tuple<char, long>> RunLengthEncoding(string s)
        {
            // initialize
            char c = s[0];
            long cnt = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (c == s[i]) cnt++;
                else
                {
                    yield return Tuple.Create(c, cnt);
                    cnt = 1;
                }
                c = s[i];
            }
            // finalize
            yield return Tuple.Create(c, cnt);
        }
    }
}
