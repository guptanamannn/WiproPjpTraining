using System;

namespace myapp
{
    class Person
    {
        private string FirstName;
        private string LastName;
        private string EmailAddress;
        private DateTime DateofBirth;
        private int k;
        int age=0;
        Person(){}
        Person(string a,string b,string c,DateTime y)
        {
            FirstName=a;
             LastName=b;
            EmailAddress=c;
            DateofBirth=y;
                 TimeSpan age=DateTime.Today-DateofBirth;
        k=(int)Math.Floor(age.Days/365.255);
        }
        	public string ScreenName
		{
            get
			{
		string f=LastName[0].ToString();
	
		int m=(DateofBirth.Month);
	
		int d=(DateofBirth.Day);
	
		string k=f+FirstName+d+m;
		
				return k;
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
		
		if((DateofBirth.Month==today.Month)&&(DateofBirth.Day==today.Day))
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
		double salary;

        static void Main(string[] args) 
        {
            
           
            DateTime datetime=new DateTime(1998,2,15,3,15,0);
       Person p=new Person("Rafath","Mohammad","mdrafath02@gmail.com",datetime);
			Employee e=new Employee();
           
            
           bool u= e.IsAdult;
           Console.WriteLine("Isadult : {0}",u);
		  string v= e.SunSign;
		  Console.WriteLine("Sunsign : {0}",v);
		  bool h= e.IsBirthDay;
		  Console.WriteLine("Isbirthday : {0}",h);
		   string d=p.ScreenName;
		   Console.WriteLine("Screen name : {0}",d);
          
        }
       
        }
    }
}