using System;

namespace myapp
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] a={1,2,3,4,5,6};
           int i=0;int count=0;
           try
           {
             while(a[i]!='a')
            {
               count++;
               i++;
            }
               
           }
           catch (Exception )
           {
            Console.WriteLine(count);
           }
          
        }
    }
}
