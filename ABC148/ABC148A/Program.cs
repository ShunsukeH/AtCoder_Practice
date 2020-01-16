using System;
namespace ABC148A
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int[] ans = { 1, 2, 3 };
            foreach (var i in ans)
            {
                if (i != a && i != b)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}
