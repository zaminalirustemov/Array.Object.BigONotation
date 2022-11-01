using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int cem = 0;

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                if (arr[i]> 99)
                {
                    cem += arr[i];
                }
            }
            Console.Write($"Ededlerinin cemi:{cem} ");
        }
    }
}
