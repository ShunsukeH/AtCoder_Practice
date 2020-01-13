using System;
namespace ABC151A
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            string inp = Console.ReadLine();
            char c = inp.ToCharArray()[0];
            int ascii = (int)c;
            ascii += 1;
            Console.WriteLine((char)ascii);
        }
    }
}
