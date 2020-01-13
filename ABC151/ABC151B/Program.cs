using System;
using System.Linq;
namespace ABC151B
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            string[] inp1 = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int n = int.Parse(inp1[0]);
            int k = int.Parse(inp1[1]);
            int m = int.Parse(inp1[2]);

            int x = n * m - (arr.Sum());
            if (x < 0) x = 0;
            Console.WriteLine(x > k ? -1 : x);
        }
    }
}
