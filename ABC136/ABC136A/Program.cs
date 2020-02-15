using System;
using System.Linq;

namespace ABC136A
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] abc = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int cap = abc[0] - abc[1];
            Console.WriteLine(cap >= abc[2] ? 0 : abc[2] - cap);
        }
    }
}
