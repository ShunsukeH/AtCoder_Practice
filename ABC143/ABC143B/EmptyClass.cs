using System;
namespace ABC143B
{
    public class EmptyClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            long sum = 0;
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    sum += arr[i] * arr[j];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
