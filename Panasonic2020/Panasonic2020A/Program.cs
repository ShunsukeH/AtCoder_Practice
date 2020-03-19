using System;
using System.Linq;

namespace Panasonic2020A
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] arr = "1, 1, 1, 2, 1, 2, 1, 5, 2, 2, 1, 5, 1, 2, 1, 14, 1, 5, 1, 5, 2, 2, 1, 15, 2, 2, 5, 4, 1, 4, 1, 51".Split(',').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(arr[n - 1]);
        }
    }
}
