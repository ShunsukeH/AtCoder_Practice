using System;

namespace ABC142A
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int cnt = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    cnt++;
                }
            }
            Console.WriteLine((decimal)cnt / n);
        }
    }
}
