using System;

namespace q12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an array: ")
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Given array ");
            foreach (int j in arr)
            {
                Console.Write(j + " ");
            }

            Console.WriteLine("\nReversed array ");
            int[] temp = arr;
            Array.Reverse(temp);
            foreach (int j in temp)
            {
                Console.Write(j + " ");
            }


            Console.ReadKey();
        }
    }
}
