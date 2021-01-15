using System;

namespace myapp
{
    class RandomHelper
    {
       

        public static int randint(int a,int b)
        {
       
            int c=a+1;
             int d=b+1;
         
                Random random=new Random();
                return random.Next(c,d);
           
        }
        public static double randdouble(int a,int b)
        {
           
     
                Random random=new Random();
             
              return random.NextDouble() * (b - a) + a;
           
        }
    }
    class Caller
    {

        static void Main(string[] args)
        {
         int a=Convert.ToInt32(Console.ReadLine());
         int  b=Convert.ToInt32(Console.ReadLine());
            Console.Write(RandomHelper.randint(a,b));
            Console.Write("\n");
            Console.Write(RandomHelper.randdouble(a,b));
        }

    }

    }