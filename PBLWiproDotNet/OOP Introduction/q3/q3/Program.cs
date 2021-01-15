using System;
using System.Collections.Generic;
using System.Text;

namespace q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Stock Details>>");
            Console.WriteLine("Enter Stock Name:");
            String Name= Console.ReadLine();
            Console.WriteLine("Enter Stock Model:");
            String Model = Console.ReadLine();
            Console.WriteLine("Enter Stock Previous CLosing Price:");
            int PCP= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Stock Current Closing Price:");
            int CCP = Convert.ToInt32(Console.ReadLine());
            STOCK s1 = new STOCK(Name, Model,PCP,CCP);
            Console.WriteLine("Change Percentage {0}%", Math.Round(s1.getChangePercentage(), 2));
        }
    }
}
