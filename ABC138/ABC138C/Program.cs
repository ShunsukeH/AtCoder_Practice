using System;
using System.Collections.Generic;
using System.Linq;

namespace ABC138C
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<double> v = Console.ReadLine().Split(' ').Select(e => double.Parse(e)).OrderBy(e=>e).ToList();
            while (v.Count>1)
            {
                v[0] = (v[0] + v[1]) / 2;
                v.RemoveAt(1);
            }
            Console.WriteLine((double)v[0]);
        }
    }
}
