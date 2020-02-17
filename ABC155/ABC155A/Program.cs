using System;
using System.Linq;

namespace ABC155A
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int cnt = 0;
            if (a[0] == a[1]) cnt++;
            if (a[1] == a[2]) cnt++;
            if (a[0] == a[2]) cnt++;
            Console.WriteLine(cnt == 1 ? "Yes" : "No");
        }
    }
}
