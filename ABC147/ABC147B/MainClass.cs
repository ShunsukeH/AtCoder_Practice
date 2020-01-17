using System;
using System.Linq;
namespace ABC147B
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            char[] a = s.ToCharArray();
            char[] b = s.Reverse().ToArray();

            int cnt = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (a[i] != b[i])
                {
                    b[i] = a[i];
                    a[s.Length - (i + 1)] = b[i];
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
        }
    }
}
