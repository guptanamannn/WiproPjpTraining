using System;
using System.Collections.Generic;

namespace Generics2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            List<char> Alphalist = new List<char>();
            List<char> Digitlist = new List<char>();
            for(int i=0;i<str.Length;i++)
            {
                if(str[i]>=48&&str[i]<=57)
                {
                    Digitlist.Add((str[i]));
                }
                else
                {
                    Alphalist.Add((char)str[i]);
                }
            }
            Alphalist.Sort();
            Digitlist.Sort();
            foreach(int i in Digitlist)
            {
                Console.WriteLine((char)i);
            }
            foreach(char i in Alphalist)
            {
                Console.WriteLine((char)i);
            }
             
        }
    }
}
