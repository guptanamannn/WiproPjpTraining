using System;
using System.Linq;

namespace q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            String str = Console.ReadLine();
            
            char[] c1 = str.ToArray();
            for (int i = 0; i < str.Length; i++)
            {
                c1[i]++;
                Console.Write(c1[i]);
            }
            
        }
    }
}
