using System;

namespace myapp
{
    class Program
    {
        static void Main(string[] args)
        {
           int count=0;int flag=0;
            int big= Convert.ToInt32(Console.ReadLine());
            int small= Convert.ToInt32(Console.ReadLine());
            while(big!=0)
            {
                int rem=big%10;
                big=big/10;
                if(rem==small)
                {
                   count++; flag=1; 
                }
                else
                {
                   count++; 
                }
                if(flag==1)
                {
                   break; 
                }
            }
            switch(count)
            {
                case 1:
                {
                    Console.WriteLine("unit's place");
                    break;
                }
                 case 2:
                {
                    Console.WriteLine("ten's place");
                    break;
                }
                 case 3:
                {
                    Console.WriteLine("hunderds place");
                    break;
                }
                 case 4:
                {
                    Console.WriteLine("thousands place");
                    break;
                }
               
                 default:
                {
                    Console.WriteLine("doesnot match");
                    break;
                }
            }
           
           
          
        }
    }
}
