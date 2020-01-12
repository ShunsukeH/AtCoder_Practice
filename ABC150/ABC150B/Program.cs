using System;
using System.Linq;
namespace ABC150B
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            Console.WriteLine(s.Replace("ABC", "0").Where(c => c == '0').Count());
        }
    }
}
