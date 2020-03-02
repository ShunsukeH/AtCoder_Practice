using System;
using System.Linq;

namespace ABC157B
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] a1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] a2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] a3 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            string res = "No";
            bool[] b1 = new bool[3];
            bool[] b2 = new bool[3];
            bool[] b3 = new bool[3];

            for (int i = 0; i < n; i++)
            {
                int b = int.Parse(Console.ReadLine());
                for (int j = 0; j < a1.Length; j++)
                {
                    if (a1[j] == b)
                    {
                        b1[j] = true;
                    }
                    if (a2[j] == b)
                    {
                        b2[j] = true;
                    }
                    if (a3[j] == b)
                    {
                        b3[j] = true;
                    }
                }
            }

            if (b1.All(e => e == true)|| b2.All(e => e == true)|| b3.All(e => e == true))
            {
                res = "Yes";
            }

            for (int i = 0; i < a1.Length; i++)
            {
                if (b1[i]&&b2[i]&&b3[i])
                {
                    res = "Yes";
                }
            }

            if (b1[0]&&b2[1]&&b3[2])
            {
                res = "Yes";
            }
            if (b1[2] && b2[1] && b3[0])
            {
                res = "Yes";
            }
            Console.WriteLine(res);
        }
    }
}
