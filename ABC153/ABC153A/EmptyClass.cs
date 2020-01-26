using System;
namespace ABC153A
{
    public class EmptyClass
    {
        public static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int h = n[0];
            int a = n[1];
            int c = 0;
            while (h>0)
            {
                h -= a;
                c++;
            }
            Console.WriteLine(c);
        }
    }
}
