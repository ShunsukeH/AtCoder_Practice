using System;
using System.Linq;
namespace ABC143D
{
    public class EmptyClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] l = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            l = l.OrderBy(e=>e).ToArray();

            int cnt = 0;
            for (int i = 0; i < n - 2; i++)
            {
                for (int j = i + 1; j < n - 1; j++)
                {
                    int a = l[i];
                    int b = l[j];
                    int ab = a + b;
                    var x = LowerBound(l,j, l.Length,ab) -(j+1);
                    cnt += x;
                }
            }
            Console.WriteLine(cnt);
        }

        static int LowerBound(int[] arr, int l, int r, int value)
        {

            int center;
            while (l < r)
            {
                center = ((r - l) >> 1) + l;
                if (arr[center] < value)
                    l = center + 1;
                else
                    r = center;
            }
            return l;
        }
    }
}
