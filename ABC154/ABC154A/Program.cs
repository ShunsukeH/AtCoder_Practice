using System;

namespace ABC154A
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');
            int[] ab = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            string u = Console.ReadLine();
            for (int i = 0; i < 2; i++)
            {
                if (arr[i] == u)
                {
                    ab[i]--;
                }
            }
            Console.Write("{0} {1}", ab[0], ab[1]);
        }
    }
}
