using System;
using System.Collections.Generic;

namespace ABC155C
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> dic = new Dictionary<string, int>();
            int max = 0;
            for (int i = 0; i < n; i++)
            {
                var str = Console.ReadLine();
                if (dic.ContainsKey(str)) dic[str]++;
                else dic.Add(str, 1);
                max = Math.Max(max, dic[str]);
            }

            var res = new List<string>();
            foreach (var x in dic)
                if (max == x.Value) res.Add(x.Key);
            res.Sort(StringComparer.OrdinalIgnoreCase);
            Console.WriteLine(string.Join("\n", res));
        }
    }
}