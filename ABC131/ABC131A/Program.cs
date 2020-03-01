using System;

namespace ABC131A
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            char[] s = Console.ReadLine().ToCharArray();
            string res = "Good";
            for (int i = 0; i < s.Length-1; i++)
            {
                if (s[i] == s[i+1])
                {
                    res = "Bad";
                    break;
                }
            }
            Console.WriteLine(res);
        }
    }
}
