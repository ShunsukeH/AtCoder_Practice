using System;
using System.Linq;

namespace ABC132A
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            char first = s[0];
            Console.WriteLine(s.Distinct().Count() == 2 && s.Where(e => e == first).Count() == 2 ? "Yes" : "No");
        }
    }
}
