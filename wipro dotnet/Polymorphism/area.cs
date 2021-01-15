
using System;
namespace myapp
{
    class Area
    {
        public void area(double radius)
        {
           
           double AREA=3.14*radius*radius;
           Console.WriteLine(AREA);
        }
 
         public void area(int  length,int breadth)
        {
           
            int AREA=length*breadth;
             Console.WriteLine(AREA);
        }
  
        public void area(float Base ,float height)
        {
           
            float trArea=(Base*height)/2;
             Console.WriteLine(trArea);
        }
    }
class main
{

          static void Main(string[] args)
        {
              

            Area a=new Area();
            a.area(5.5);
            a.area(1,2);
            a.area(1.1f,1.1f);
           
        }
    }
}

