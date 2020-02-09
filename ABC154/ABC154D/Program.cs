using System;
using System.Linq;
namespace ABC154D
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] nk = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] p = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            double temp = 0;
            for (int i = 0; i < nk[0]-nk[1]+1; i++)
            {
                if (i !=0 && p[i-1]>= p[i+nk[1]-1])
                {
                    continue;
                }
                double sum = ((double)p.Skip(i).Take(nk[1]).Sum() / 2) + (0.5*nk[1]);
                if (sum>temp)
                {
                    temp = sum;
                }
                
            }
            Console.WriteLine(temp);
        }
    }
}
