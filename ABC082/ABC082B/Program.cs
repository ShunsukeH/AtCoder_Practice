using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string t = Console.ReadLine();
            int[] sInt = s.ToCharArray().Select(e => (int)e).OrderBy(e => e).ToArray();
            int[] tInt = t.ToCharArray().Select(e => (int)e).OrderByDescending(e => e).ToArray();
            string res = string.Empty;
            int length = s.Length > t.Length ? t.Length : s.Length;
            for (int i = 0; i < length; i++)
            {
                if (sInt[i] == tInt[i])
                {
                    continue;
                }
                else if (sInt[i] > tInt[i])
                {
                    res = "No";
                    break;
                }
                else if (sInt[i] < tInt[i])
                {
                    res = "Yes";
                    break;
                }
            }

            if (string.IsNullOrEmpty(res))
            {
                res = s.Length >= t.Length ? "No" : "Yes";
            }

            Console.WriteLine(res);
        }
    }
}