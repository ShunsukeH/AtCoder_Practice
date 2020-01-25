using System;
namespace ABC143A
{
    public class EmptyClass
    {
        public static void Main(string[] args)
        {
            int[] inp = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int x = inp[1] * 2;
            Console.WriteLine(x >= inp[0] ? 0 : inp[0] - x);
        }
    }
}
