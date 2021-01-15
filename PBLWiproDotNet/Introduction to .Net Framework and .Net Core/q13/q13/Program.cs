using System;

namespace q13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Array: ");
            int sum = 0;
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum += arr[i];
            }
            Console.WriteLine("Sum Of Array Is: {0}",sum);
            
            Console.ReadKey();
        }
    }
}
