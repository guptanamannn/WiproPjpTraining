using System;

namespace myapp
{
    class Person
    {
        private string FirstName;
        private string LastName;
     
        public void check(string r)
            {
                for(int i=0;i<r.Length;i++)
                {
                    bool result= Char.IsLetter(r[i]); 
                    if(result==true)
                    {
                        
                    }
                  else
                  {
                      throw new FormatException();
                  }
                }
            }
            
        static void Main(string[] args) 
        {
             Console.WriteLine("enter the first name");
            string FirstName=Console.ReadLine();
       
             Console.WriteLine("enter the last name");
			string LastName=Console.ReadLine();
           
           Person p=new Person(); 
         
			  try
           {
            p.check(FirstName);
            p.check(LastName);
           }
           catch (FormatException E)
           {
                 Console.WriteLine("only alphabets are allowed");
              
           }
			if(FirstName.Length==0||LastName.Length==0)
            {
                Console.WriteLine("FirstName and LastName should not be empty");
            }
          
        }
       
        }
    }
