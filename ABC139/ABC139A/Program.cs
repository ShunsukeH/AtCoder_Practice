using System;

namespace ABC139A
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] s = Console.ReadLine().ToCharArray();
            char[] t = Console.ReadLine().ToCharArray();
            int res = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == t[i])
                {
                    res++;
                }
            }

            Console.WriteLine(res);
        }
    }
}