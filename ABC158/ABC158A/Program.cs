using System;
using System.Linq;

namespace ABC158A
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();

            Console.WriteLine(s.Distinct().Count() == 1 ? "No" : "Yes");
        }
    }
}
