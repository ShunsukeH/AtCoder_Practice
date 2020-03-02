using System;
using System.Linq;

namespace ABC157C
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] nm = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[][] sc = new int[nm[1]][];
            for (int i = 0; i < nm[1]; i++)
            {
                sc[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }
            int res = 0;
            int[] resArr = new int[nm[0]];
            resArr = resArr.Select(e => e = -1).ToArray();
            for (int i = 0; i < nm[1]; i++)
            {
                int s = sc[i][0];
                int c = sc[i][1];
                if (s>nm[0])
                {
                    res = -1;
                    break;
                }

                if (resArr[s-1] == -1 || resArr[s-1] == c)
                {
                    resArr[s-1] = c;
                }
                else
                {
                    res = -1; break;
                }
            }


            if (res == 0)
            {
                if (resArr[0] == -1 && nm[0]>1)
                {
                    resArr[0] = 1;
                }
                if (resArr[0] == 0 && nm[0] > 1)
                {
                    res = -1;
                }

               for (int i = resArr.Length-1; i >= 0; i--)
                {
                    if (resArr[i] == -1)
                    {
                        resArr[i] = 0;
                    }
                    res += resArr[(nm[0]-1) - i] * (int)Math.Pow(10, i);
                }
            }
            Console.WriteLine(res);
        }
    }
}
