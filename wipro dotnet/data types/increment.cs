using System;

namespace myapp
{
    class Program
    {
        static void Main(string[] args)
        {
           string a;
           a=Console.ReadLine();
           for(int i=0;i<a.Length;i++)
            {
               b=(int)a[i];
               b++;
              Console.WriteLine((char)b);  
            }
            
        }
    }
}
