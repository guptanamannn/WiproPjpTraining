using System;

namespace myapp
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int n1= Convert.ToInt32(Console.ReadLine());
            int n2= Convert.ToInt32(Console.ReadLine());

           /*********** pre increment************/


           int a=n1;
           int b=n2;

           b=++a;
           
            Console.WriteLine(a);
            Console.WriteLine(b);

        /************* post increment**************/

           a=n1;
           b=n2;
           b=a++;
          
           Console.WriteLine(a);
            Console.WriteLine(b);

            /************* swap****************/

            int temp=n1;
            n1=n2;
            n2=temp;
            
            Console.WriteLine(n1);
            Console.WriteLine(n2);

          
        }
    }
}
