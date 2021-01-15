using System;
namespace myapp
{    
    class NegativeNumberException : Exception
    {
        public NegativeNumberException()
        {
             Console.WriteLine("NegativeNumberException occured");
            Console.WriteLine("negative number entered please enter a positive integer");
        }

    }

    
    class student
    {
         static void Main(string[] args)
        {
           int[] a =new int[3];int m=0;
           for(int i=0;i<3;i++)
            {
               Console.WriteLine("Enter the student name");
               string s=Console.ReadLine();
               Console.WriteLine("Enter the student marks");
            for(int j=0;j<3;j++)
            {
                try
                {
                     m=Convert.ToInt32(Console.ReadLine()); 
                    if(m<0)
                    {
                         throw new NegativeNumberException();
                    }
                }
                catch (FormatException e)
                {
                    j=j-1;
                     Console.WriteLine("FormatException occured");
                        Console.WriteLine("Please enter a valid Integer");
                }
                
                catch(NegativeNumberException e)
                {
                    
                    j=j-1;
                    
                }
                
            }
            }
        }
   }
}