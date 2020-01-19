using System;
namespace ABC152
{
    public class EmptyClass
    {
        public static void Main(string[] args)
        {
            int[] inp = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            Console.WriteLine(inp[0] == inp[1] ? "Yes" : "No");
        }
    }
}