using System;
using System.Linq;

namespace ABC133B
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] nd = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[][] x = new int[nd[0]][];
            for (int i = 0; i < nd[0]; i++)
            {
                x[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }
            int cnt = 0;
            for (int i = 0; i < nd[0]-1; i++)
            {
                for (int j = i+1; j < nd[0]; j++)
                {
                    var sum = 0.0;
                    for (int k = 0; k < nd[1]; k++)
                    {
                        sum += Math.Pow(x[i][k] - x[j][k], 2);
                    }
                    for (int l = 0; l <= sum; l++)
                    {
                        if (l * l == sum) cnt++;
                    }
                }
            }
            Console.WriteLine(cnt);
        }
    }
}
