using System;
using System.Linq;

namespace Hitachi2020A
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string res = "Yes";
            if (s.Length%2 == 1)
            {
                Console.WriteLine("No");
                return;
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (s.Substring(i,2) == "hi")
                {
                    i++;
                    continue;
                }
                else
                {
                    res = "No";
                    break;
                }
            }
            Console.WriteLine(res);
        }
    }
}
