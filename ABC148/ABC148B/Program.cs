using System;
namespace ABC148B
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] st = Console.ReadLine().Split();
            char[] s = st[0].ToCharArray();
            char[] t = st[1].ToCharArray();

            string res = string.Empty;
            for (int i = 0; i < n; i++)
            {
                res += s[i].ToString() + t[i].ToString();
            }
            Console.WriteLine(res);

        }
    }
}
