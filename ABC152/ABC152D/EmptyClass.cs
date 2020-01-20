using System;

namespace ABC152D
{
    public class EmptyClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var table = new int[10, 10];
            for (int i = 1; i <= n; i++)
            {
                table[FirstDigit(i), i % 10]++;
            }

            long result = 0;
            for (int i = 1; i <= n; i++)
            {
                result += table[i % 10, FirstDigit(i)];
            }
            Console.WriteLine(result);
        }

        static int FirstDigit(int num)
        {
            while (num >= 10)
            {
                num /= 10;
            }
            return num;
        }
    }
}
