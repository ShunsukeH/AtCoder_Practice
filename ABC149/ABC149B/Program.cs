using System;
namespace ABC149B
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            long[] inp = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
            string result;
            if (inp[0] + inp[1] <= inp[2])
            {
                result = "0 0";
            }
            else
            {
                if (inp[0] >= inp[2])
                {
                    inp[0] -= inp[2];
                }
                else
                {
                    inp[1] -= inp[2] - inp[0];
                    inp[0] = 0;
                }
                result = inp[0].ToString() + ' ' + inp[1].ToString();
            }

            Console.WriteLine(result);
        }

    }
}
