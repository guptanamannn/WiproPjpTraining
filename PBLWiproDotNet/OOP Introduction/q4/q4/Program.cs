using System;
using System.Collections.Generic;
using System.Text;

namespace q4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers");
            int min = Convert.ToInt32(Console.ReadLine());
            int max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Random Integer",RandomHelper.RandomHelper.randint(min, max));
            Console.WriteLine("Random Double",RandomHelper.RandomHelper.randdouble(min, max));
        }
    }
}
