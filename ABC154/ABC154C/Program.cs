using System;
using System.Collections.Generic;
using System.Linq;
namespace ABC154C
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            HashSet<int> dic = new HashSet<int>();
            string res = "YES";
            foreach (var item in a)
            {
                if (!dic.Add(item))
                {
                    res = "NO";
                    break;
                }
            }
            Console.WriteLine(res);
        }
    }
}
