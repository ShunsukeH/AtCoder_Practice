using System;
using System.Linq;

namespace ABC156B
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] nk = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            Console.WriteLine(IntToNString(nk[0],nk[1]).Length);
        }

        public static string IntToNString(int x, int n)
        {
            var nstring = "";
            var numbers = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "a", "b", "c", "d", "e", "f" };
            int r = 1;  // 余り
            int q = x;  // 商

            // 商が0になるまでループ
            while (q > 0)
            {
                r = q % n;
                nstring += numbers[r];
                q = q / n;
            }
            return string.Join("", nstring.Reverse());
        }
    }
}
