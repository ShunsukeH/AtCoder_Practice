using System;
namespace ABC149C
{
    public class EmptyClass
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            while (true)
            {
                if (isPrime(x))
                {
                    Console.WriteLine(x);
                    break;
                }
                x++;
            }
        }

        static bool isPrime(long n)
        {
            if (n < 2) return false;
            if (n % 2 == 0 && n != 2) return false;
            for (int i = 3; i < Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
}
