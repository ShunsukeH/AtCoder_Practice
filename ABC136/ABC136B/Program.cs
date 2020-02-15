using System;
using System.Linq;

namespace ABC136B
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int cnt = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i.ToString().Length % 2 == 1)
                {
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
        }
    }
}
