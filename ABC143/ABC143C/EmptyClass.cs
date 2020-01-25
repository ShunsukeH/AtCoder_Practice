using System;
using System.Collections.Generic;

namespace ABC143C
{
    public class EmptyClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[] s = Console.ReadLine().ToCharArray();
            List<char> res = new List<char>();
            res.Add(s[0]);
            for (int i = 1; i < n; i++)
            {
                if (s[i]==res[res.Count-1])
                {
                    continue;
                }
                res.Add(s[i]);
            }
            Console.WriteLine(res.Count);
        }
    }
}
