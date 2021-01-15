using System;

namespace myapp
{
    class Program
    {
        static void Main(string[] args)
        {
           char a=Convert.ToChar(Console.ReadLine());
           if((int)a>65)
            {
                Console.WriteLine(" it is a alphabet");
            }
            else
            {
                Console.WriteLine(" it is a digit");
            }
           
           
          
        }
    }
}
