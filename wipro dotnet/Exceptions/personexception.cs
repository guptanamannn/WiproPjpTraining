/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;

namespace myapp
{

    class Person
    {
        private string FirstName;
        private string LastName;
        private string EmailAddress;
        static private DateTime DateofBirth;
       static int k;
        int age=0;int ag;
           DateTime now = DateTime.Now;   //changed
        Person(){}
        Person(string a,string b,string c,DateTime y)
        {
            FirstName=a;
             LastName=b;
            EmailAddress=c;
            DateofBirth=y;
        
                 TimeSpan age=now-DateofBirth;
              
        k=(int)Math.Floor(age.Days/365.255);
      
        }
        	public string ScreenName
		{
            get
			{
		string f=LastName[0].ToString();
	
		int m=(DateofBirth.Month);
	
		int d=(DateofBirth.Day);
	
		string finalname=f+FirstName+d+m;
		
				return finalname;
			}
		}
        
      
      
        public bool IsAdult
        {
            
            
                get
                {
                    
          if(k>18)
            {
                    return true;
            }
            else
            {
                    return false;
               
            }
        }
        }
       public string SunSign 
        {
             get
            {
            if((DateofBirth.Month==1)&&(DateofBirth.Day>=22)||(DateofBirth.Month==2)&&(DateofBirth.Day<=19))
			{
				string x="sunsign is Aquarius";
				return x;
            }
			
			else if((DateofBirth.Month==2)&&(DateofBirth.Day>=20)||(DateofBirth.Month==3)&&(DateofBirth.Day<=20))
			{
				string x="sunsign is Pisces";
				return x;
				}
			
			else if((DateofBirth.Month==3)&&(DateofBirth.Day>=21)||(DateofBirth.Month==4)&&(DateofBirth.Day<=20))
			{
					string x="sunsign is Aries";
					return x;
				}
			
			else if((DateofBirth.Month==4)&&(DateofBirth.Day>=21)||(DateofBirth.Month==5)&&(DateofBirth.Day<=20))
			{
					string x="sunsign is Taurus";
					return x;
				}
			
			else if((DateofBirth.Month==5)&&(DateofBirth.Day>=21)||(DateofBirth.Month==6)&&(DateofBirth.Day<=21))
			{
					string x="sunsign is Gemini";
					return x;
				}
			
			else if((DateofBirth.Month==6)&&(DateofBirth.Day>=22)||(DateofBirth.Month==7)&&(DateofBirth.Day<=22))
			{
					string x="sunsign is Cancer";
					return x;
				}
			
			else if((DateofBirth.Month==7)&&(DateofBirth.Day>=23)||(DateofBirth.Month==8)&&(DateofBirth.Day<=23))
			{
					string x="sunsign is Leo";
					return x;
				}
			
			else if((DateofBirth.Month==8)&&(DateofBirth.Day>=24)||(DateofBirth.Month==9)&&(DateofBirth.Day<=23))
			{
					string x="sunsign is Virgo";
					return x;
				}
			
			else if((DateofBirth.Month==9)&&(DateofBirth.Day>=24)||(DateofBirth.Month==10)&&(DateofBirth.Day<=23))
			{
					string x="sunsign is Libra";
					return x;
				}
			
			else if((DateofBirth.Month==10)&&(DateofBirth.Day>=24)||(DateofBirth.Month==11)&&(DateofBirth.Day<=22))
			{
					string x="sunsign is Scorpio";
					return x;
				}
			
			else if((DateofBirth.Month==11)&&(DateofBirth.Day>=23)||(DateofBirth.Month==12)&&(DateofBirth.Day<=21))
			{
					string x="sunsign is Sagittarius";
					return x;
				}
			
			else
			{
					string x="sunsign is Capricorn";
					return x;
				}
			}
        }
        
		public bool IsBirthDay
		{
            get
			{
		DateTime today=DateTime.Today;
		
		if((DateofBirth.Month==now.Month)&&(DateofBirth.Day==now.Day))
		{
			Console.WriteLine("Today is persons birthday");
		
			return true;
			}
		
		else
		{
			Console.WriteLine("Today is not  persons birthday");
			
			return false;
			}
		}
		}
	
	
	class Employee:Person
	{
     class NegativeNumberException : Exception
    {
        public NegativeNumberException()
        {
             Console.WriteLine("NegativeNumberException occured");
            Console.WriteLine("negative number entered please enter a positive integer");
        }

    }
    
    class FormatException :Exception
    {
        
        public FormatException()
        {}
            public FormatException(string message): base(message) 
            {
            }
            

        
    }
    
		double salary;int flag=0;
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
                      throw new FormatException(r);
                  }
                    
                
                }
            }
            public void checkdate()
        {
            if(DateofBirth.Year>0&&DateofBirth.Month>0&&DateofBirth.Day>0)
            {
            }
            else
            {
                throw new NegativeNumberException();
            }
               
        }

        static void Main(string[] args) 
        {string g;
        Employee e=new Employee();
            Console.WriteLine("enter the first name");
            e.FirstName=Console.ReadLine();
             Console.WriteLine("enter the last name");
			e.LastName=Console.ReadLine();
              Console.WriteLine("enter the email id");
			 e.EmailAddress=Console.ReadLine();
            Console.WriteLine("enter the date of birth");
            string date=Console.ReadLine();
            DateTime datetime=DateTime.Parse(date);
            

          Person p=new Person(e.FirstName,e.LastName,e.EmailAddress,datetime);
			
           try
           {
            e.check(e.FirstName);
            e.check(e.LastName);
            e.checkdate();
           }
           catch (FormatException E)
           {
                Console.WriteLine("Format Exception occured at"+E);
            Console.WriteLine("please enter a valid string");
           }
           catch(NegativeNumberException E)
            {
                
            }
            
            
           bool u= e.IsAdult;
           Console.WriteLine("Isadult : {0}",u);
		  string v= e.SunSign;
		  Console.WriteLine("Sunsign : {0}",v);
		  bool h= e.IsBirthDay;
		  Console.WriteLine("Isbirthday : {0}",h);
		   string sn=p.ScreenName;
		   Console.WriteLine("Screen name : {0}",sn);
          
        }
       
        }
    }
}