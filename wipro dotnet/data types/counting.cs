using System;

namespace myapp
{
    class Program
    {
        static void Main(string[] args)
        {
           string a;
           int count1=0,count2=0;
           a=Console.ReadLine();
           for(int i=0;i<a.Length;i++)
            {
           if((int)(a[i])>65)
                {
                    count1++;
                }
                else
                {
                    count2++;
                }
            }
            Console.WriteLine("number of characters=",count1);

            Console.WriteLine("number of numbers=",count2);
        }
    }
}
