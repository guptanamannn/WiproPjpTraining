using System;

namespace myapp
{
    class car
    {
        string carmake;
        int MfgYear;
        int carmodel;
        string city;

        car(string carmake, int MfgYear, int carmodel, string city)
        {
            this.carmake=carmake;
            this.MfgYear=MfgYear;
            this.carmodel=carmodel;
            this.city=city;
        }
        public void DisplayCar()
        {
            Console.WriteLine("carmake="+carmake);
             Console.WriteLine("manufactured date="+MfgYear);
              Console.WriteLine("carmodel="+carmodel);
               Console.WriteLine("city="+city);
        }
        static void Main(string[] args)
        {
           car a=new car("maruti",2010,2012,"hyd");
          a.DisplayCar();
        }
    }
}
