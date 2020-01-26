using System;
using System.Linq;
namespace ABC153E
{
    public class EmptyClass
    {
        public static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            double[][] attacks = new double[n[1]][];
            for (int i = 0; i < n[1]; i++)
            {
                attacks[i] = new double[3];
                int[] inp = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                attacks[i][0] = inp[0];
                attacks[i][1] = inp[1];
                attacks[i][2] = attacks[i][0] / attacks[i][1];
            }
            double h = n[0];
            double cnt = 0;
            attacks = attacks.OrderBy(e => e[2]).ThenByDescending(e => e[1]).ToArray();
            int s = (int) h / (int) attacks[n[1] - 1][0];
            h -= (int)attacks[n[1] - 1][0] * s;
            cnt = (int)attacks[n[1] - 1][1] * s;
            cnt += (int) attacks.Where(e => e[0] >= h).Min(e => e[1]);
            Console.WriteLine(cnt);
            //while (h > 0)
            //{
            //    int index = attacks.ToList().FindLastIndex(e => e[0] <= h);
            //    if (index <= 0) {
            //        cnt += attacks.Min(e => e[1]);
            //        break;
            //    };
            //    h -= attacks[index][0];
            //    cnt += attacks[index][1];
            //}

            //Console.WriteLine((long) cnt);
        }
    }
}
