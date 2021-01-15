using q2;
using System;
using System.Collections.Generic;
namespace Employee
{
    class q2
    {
        static void Main(string[] args)
        {
            permanent P1 = new permanent();
            P1.firstn = "Naman";
            P1.lastn = "Gupta";
            hourly h1 = new hourly();
            h1.firstn = "Gagan";
            h1.lastn = "Gupta";
            h1.HoursWorked = 50;
            h1.PayPerHour = 100;
            h1.Calculatepay();
        }
    }
}
