using System;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int[] arr = { 3, 1, 5, 2, 5, 1, 3, 1, 8, 7, 1 };
            int[] count = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < arr.Length; i++)
            {
                count[arr[i]] ++;

      
            }
            for(int i = 0; i < count.Length; i++)
                Console.WriteLine("{0}="+ count[i] , i);
            
        }
    }
}
