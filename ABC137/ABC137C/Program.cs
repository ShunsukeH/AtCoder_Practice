using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long cnt = 0;
            Dictionary<string, int> table = new Dictionary<string, int>(); ;
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                s = Sort(s);
                if (!table.ContainsKey(s))
                {
                    table.Add(s, 0);
                }
                else
                {
                    table[s]++;
                    cnt += table[s];
                }
            }

            Console.WriteLine(cnt);
        }

        static string Sort(string s)
        {
            var sb = new StringBuilder();
            foreach (var c in s.ToCharArray().OrderBy(e => e))
            {
                sb.Append(c);
            }

            return sb.ToString();
        }
    }
}