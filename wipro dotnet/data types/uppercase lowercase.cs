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
               if((int)(a[i])<97)
                {
              int b=(int)a[i];
               b=b+32;
              Console.WriteLine((char)b); 
                }
                else
                {
                    int b=(int)a[i];
               b=b-32;
              Console.WriteLine((char)b); 
                }
            }
            
        }
    }
}
