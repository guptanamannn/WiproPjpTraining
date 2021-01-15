using System;

namespace myapp
{
    class Program
    {
        static void Main(string[] args)
        {
            int count=0;
            int big= Convert.ToInt32(Console.ReadLine());
            int small= Convert.ToInt32(Console.ReadLine());
             while(big!=0)
            {
                int rem=big%10;
                big=big/10;
                if(rem==small)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
          
        }
    }
}
