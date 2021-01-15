using System;

namespace myapp
{
    class Program
    {
        static void Main(string[] args)
        {
           string a;
           string rev="";
           a=Console.ReadLine();
         for(int i=a.Length;i>=0;i--)
            {
                rev=rev+a[i];
            }
           int r=string.Compare(a,rev);
               
             if(r==0)
               Console.WriteLine(" palindrome");
            else
                Console.WriteLine("not palindrome");

          
            
        }
    }
}
