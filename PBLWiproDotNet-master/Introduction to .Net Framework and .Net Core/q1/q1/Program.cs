﻿using System;

namespace q1
{
    class Program
    {
        static void Main(string[] args)
        {
            double side, area;
            Console.WriteLine("Enter the Length of Side : ");
            side = Convert.ToDouble(Console.ReadLine());
            area = side * side;
            Console.WriteLine("\nArea of Square: " + area);
            Console.ReadKey();
        }
    }
}
