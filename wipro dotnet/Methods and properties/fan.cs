using System;

namespace myapp
{
	interface fan
	{
		public string toString();
	}
    class home:fan
    {
        static  int SLOW=1;
		static int MEDIUM=2;
		static  int FAST=3;
        public void setSLOW(int a)
		{
			SLOW=a;
		}
		 public void setFAST(int b)
		{
			FAST=b;
		}
		 public void setMEDIUM(int c)
		{
			MEDIUM=c;
		}
		 public void setspeed(int d)
		{
			speed=d;
		}
		 public void seton(bool e)
		{
			on=e;
		}
		 public void setradius(double f)
		{
			radius=f;
		}
		 public void setcolor(string g)
		{
			color=g;
		}
		public int getSLOW()
		{
			return SLOW;
		}
		 public int getFAST()
		{
			return FAST;
		}
		 public int getMEDIUM()
		{
			return MEDIUM;
		}
		 public int getspeed()
		{
			return speed;
		}
		 public bool geton()
		{
			return on;
		}
		 public double getradius()
		{
			return radius;
		}
		 public string getcolor()
		{
			return color;
		}

		private int speed=SLOW;
		private bool on=false;
		private double radius=5;
		private string color="red";

		home()
		{
			

		}
		 public string toString()
		{
			string result="SLOW="+SLOW+"\n"+"MEDIUM="+MEDIUM+"\n"+"FAST="+FAST+"\n"+"speed="+speed+"\n"+"on="+on+"\n"+"radius="+radius+"\n"+"color="+color;
            return result;
		}

    
        static void Main(string[] args)
        {
            home h=new home();
			string r=h.toString();
            Console.WriteLine(r);
        }

    } 

    }
	

