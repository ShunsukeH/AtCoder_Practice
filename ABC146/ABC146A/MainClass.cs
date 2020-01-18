using System;
namespace ABC146A
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] arr = {"SUN", "MON", "TUE", "WED", "THU", "FRI", "SAT"};
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == s)
                {
                    Console.WriteLine(Math.Abs(7 - i));
                }
            }
        }
    }
}
