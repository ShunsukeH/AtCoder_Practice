using System;
using System.Linq;

namespace ABC131B
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] nl = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int res = 0;
            if (nl[1]>=0)
            {
                for (int i = 1; i < nl[0]; i++)
                {
                    res += nl[1] + (i + 1) - 1;
                }
            }
            else
            {
                if (Math.Abs(nl[0])> Math.Abs(nl[1]))
                {
                    for (int i = 0; i < nl[0]; i++)
                    {
                        res += nl[1] + (i + 1) - 1;
                    }
                }
                else
                {
                    for (int i = 0; i < nl[0]-1; i++)
                    {
                        res += nl[1] + (i + 1) - 1;
                    }
                }
            }
            Console.WriteLine(res);
        }
    }
}
