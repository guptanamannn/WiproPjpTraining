using System;

namespace myapp
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] a=new int[5];
           
            for(int i=0;i<5;i++)
            {
               a[i]= Convert.ToInt32(Console.ReadLine());
            }
            int sum=0;
             for(int i=0;i<5;i++)
            {
            sum=sum+a[i];
            }
            Console.Write(sum);
           
          
        }
    }
}
