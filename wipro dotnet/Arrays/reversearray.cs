using System;

namespace myapp
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] a=new int[10];
           
            for(int i=0;i<10;i++)
            {
               a[i]= Convert.ToInt32(Console.ReadLine());
            }
             for(int i=9;i>=0;i--)
            {
            Console.Write(a[i]+" ");
            }
           
          
        }
    }
}
