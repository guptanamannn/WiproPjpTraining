using System;

namespace q11
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            int[] arr = new int[100];
            for (int i = 0; i < 10; i++)
            {
                arr[i] = i + 100;
            }
            for (int i = 0; arr[i] != '\0'; i++)
            {
                c++;
            }
            Console.WriteLine(c);
            Console.ReadKey();

        }
    }
}
