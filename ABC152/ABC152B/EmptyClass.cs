using System;
using System.Text;

namespace ABC152
{
    public class EmptyClass
    {
        public static void Main(string[] args)
        {
            int[] inp = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            if (inp[1] > inp[0])
            {
                int tmp = inp[0];
                inp[0] = inp[1];
                inp[1] = tmp;
            }

            StringBuilder sb = new StringBuilder();
            while (inp[0]-- > 0)
            {
                sb.Append(inp[1]);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}