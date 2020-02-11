using System;
using System.Linq;

namespace ARC015B
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] maxmin = new double[2];
            int c1 =0, c2=0, c3=0, c4=0, c5=0, c6 = 0;
            for (int i = 0; i < n; i++)
            {
                maxmin = Console.ReadLine().Split(' ').Select(e => double.Parse(e)).ToArray();
                if (35.0 <= maxmin[0]) c1++;
                if (30.0 <= maxmin[0] && maxmin[0] < 35.0) c2++;
                if (25.0 <= maxmin[0] && maxmin[0] < 30.0) c3++;
                if (25.0 <= maxmin[1]) c4++;
                if (maxmin[1]<0.0 && 0.0 <= maxmin[0]) c5++;
                if (maxmin[0] < 0.0) c6++;
            }
            Console.WriteLine("{0} {1} {2} {3} {4} {5}", c1, c2, c3, c4, c5, c6);
        }
    }
}
