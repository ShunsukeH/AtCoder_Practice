using System;
using System.Linq;
namespace ABC153B
{
    public class EmptyClass
    {
        public static void Main(string[] args)
        {
            long[] n = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
            long[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
            Console.WriteLine(arr.Sum() >= n[0] ? "Yes" : "No");
        }
    }
}
