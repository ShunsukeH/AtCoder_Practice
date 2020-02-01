using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace ABC142C
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var a = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            var res = new Dictionary<int,int>();
            for (int i = 0; i < n; i++)
            {
                res.Add(a[i], i);
            }
            
            foreach (var item in res.OrderBy(e => e.Key))
            {
                Console.Write("{0} ", item.Value + 1);
            }
        }
    }
}
