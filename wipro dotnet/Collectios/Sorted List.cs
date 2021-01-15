using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collection2
{
    class Employee
    {
        public int Id;
        public string Name;
        public double Salary;
        public Employee(string n,int i,Double s)
        {
            Name = n;
            Id = i;
            Salary = s;
        }
    }

    class EmployeeDAL
    {
        SortedList Employees = new SortedList();
        int ind = 0;
        public bool AddEmployee(Employee e)
        {
            for (int i = 0; i < Employees.Count; i++)
            {
                Employee emp = (Employee)Employees[i];

                if (emp.Id == e.Id)
                {
                    return false;
                }
            }
            Employees.Add(ind, e);
            ind++;
            return true;

        }
        public bool DeleteEmployee(int id)
        {
            for (int i = 0; i < Employees.Count; i++)
            {
                Employee e = (Employee)Employees[i];
                if (e.Id == id)
                {
                    Employees.Remove(e);
                    return true;
                }
            }
            return false;
        }
        public string SearchEmpolyee(int id)
        {
            for (int i = 0; i < Employees.Count; i++)
            {
                Employee e = (Employee)Employees[i];
                if (e.Id == id)
                {
                    return e.Name; ;
                }
            }
            return "Not such item Exist";

        }
        public Employee[] GetAllEmployees()
        {
            Employee[] e = new Employee[Employees.Count];
            for (int i = 0; i < Employees.Count; i++)
            {
                e[i] = (Employee)Employees[i];
            }
            return e;
        }
    }


class Program
    {
        static void Main(string[] args)
        {
            EmployeeDAL e = new EmployeeDAL();
            Console.WriteLine(e.AddEmployee(new Employee("NANI",001,48000)));
            Console.WriteLine(e.AddEmployee(new Employee("KOMMINENI",002,65000)));
            Console.WriteLine(e.AddEmployee(new Employee("CHANDRA",003,55413)));
            Console.WriteLine(e.AddEmployee(new Employee("NAAFIYAA",004,150000)));
            Console.WriteLine(e.DeleteEmployee(002));
            Console.WriteLine(e.DeleteEmployee(005));
            Console.WriteLine(e.SearchEmpolyee(002));
            Console.WriteLine(e.SearchEmpolyee(004));
            Employee[] emp = e.GetAllEmployees();
            foreach (Employee a in emp)
            {
                Console.WriteLine(a.Id + " " + a.Name + " " + a.Salary);
            }
        }
    }
}
