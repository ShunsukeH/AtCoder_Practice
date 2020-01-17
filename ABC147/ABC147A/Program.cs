using System;
using System.Linq;
namespace ABC147A
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            int[] inp = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            Console.WriteLine(inp.Sum() > 21 ? "bust" : "win");
        }
    }
}
