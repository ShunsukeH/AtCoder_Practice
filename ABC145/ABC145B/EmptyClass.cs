using System;
namespace ABC145B
{
    public class EmptyClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();

            if (n%2==1)
            {
                Console.WriteLine("No");
            }
            else
            {
                string a = s.Substring(n / 2);
                string res = s == a + a ? "Yes" : "No";
                Console.WriteLine(res);
            }
        }
    }
}
