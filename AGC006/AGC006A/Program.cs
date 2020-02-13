using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            string t = Console.ReadLine();
            int dupCnt = 0;
            for (int i = 0; i < n; i++)
            {
                if (t.Substring(0, i + 1) == s.Substring(n - (i + 1)))
                {
                    dupCnt = Math.Max(dupCnt, i + 1);
                }
            }
            Console.WriteLine(s.Length + t.Length - dupCnt);


        }
    }
}