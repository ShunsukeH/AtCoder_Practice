using System;
using System.Linq;

namespace ABC157A
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n%2 == 0?n / 2:(n/2)+1);

            
        }
    }
}
