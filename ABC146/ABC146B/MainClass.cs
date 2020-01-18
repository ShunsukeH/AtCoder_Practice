using System;using System.Text;

namespace ABC146B
{
    public class MainClass
    {
        public static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            char[] s = Console.ReadLine().ToCharArray();
            StringBuilder res = new StringBuilder();
            foreach (var c in s)
            {
                int x = (int)c + n;
                if (x> (int)'Z')
                {
                    x = (int)'A' + (x - (int)'Z')-1;
                }
                res.Append((char)x);
            }
            Console.WriteLine(res.ToString());

        }
    }
}
