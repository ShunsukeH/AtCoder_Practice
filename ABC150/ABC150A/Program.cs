using System;
namespace ABC150A
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            int[] inp = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            Console.WriteLine(500 * inp[0] >= inp[1] ? "Yes" : "No");
        }
    }
}
