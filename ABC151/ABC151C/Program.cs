using System;
using System.Linq;
namespace ABC151C
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            string[] inp = Console.ReadLine().Split(' ');
            int n = int.Parse(inp[0]);
            int m = int.Parse(inp[1]);

            int[] ac = new int[n];
            int[] wa = new int[n];
            while (m-->0)
            {
                string[] inp2 = Console.ReadLine().Split(' ');
                int number = int.Parse(inp2[0])-1;
                string res = inp2[1];

                if (ac[number]>0) continue;

                if (res == "AC")
                {
                    ac[number] += 1;
                }
                else
                {
                    wa[number] += 1;
                }
            }
            int acCnt = ac.Sum();
            int waCnt = wa.Where((e,i) => ac[i]>0).Sum();
            
            Console.WriteLine($"{acCnt} {waCnt}");
        }
    }
}
