using System;

namespace ABC138A
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            Console.WriteLine(a >= 3200 ? s : "red");
        }
    }
}
