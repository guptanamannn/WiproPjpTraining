using Person;
using System;

namespace q1

{
     static void Main(string[] args)
        {
        Employee emp1 = new Employee();
            emp1.person("Naman", "Gupta", "ngstudies.tk@gmail.com", Convert.ToDateTime("2001/01/01"));
            emp1.Salary = 20000;
            Console.WriteLine(emp1.isAdult);
            Console.WriteLine(emp1.sunsign);
            Console.WriteLine(emp1.isbirthday);
            Console.WriteLine(emp1.screenname);
        }
}
