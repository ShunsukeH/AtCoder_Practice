using System;
using System.Linq;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nkq = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] ansCnt = new int[nkq[0]];
            ansCnt = ansCnt.Select(e => e = 0).ToArray();
            for (int i = 0; i < nkq[2]; i++)
            {
                int idx = int.Parse(Console.ReadLine());
                ansCnt[idx - 1]++;
            }


            foreach (var item in ansCnt)
            {
                Console.WriteLine(nkq[1] - (nkq[2] - item) > 0 ? "Yes" : "No");
            }
        }
    }
}