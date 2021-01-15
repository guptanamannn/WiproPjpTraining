using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collection1
{
    class Employee
    {
        public int Id;
        public string Name;
        public double Salary;
        public Employee(string n,int i,double s)
        {
            Name = n;
            Id = i;
            Salary = s;
        }
    }

    class EmployeeDAL
    {
        ArrayList Employees = new ArrayList();
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
            Employees.Add(e);
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
            return "Not found";

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
            Console.WriteLine(e.AddEmployee(new Employee("RAAMA",001,100000)));
            Console.WriteLine(e.AddEmployee(new Employee("SITA",002,80000)));
            Console.WriteLine(e.AddEmployee(new Employee("LAKSHMANA",003,75000)));
            Console.WriteLine(e.AddEmployee(new Employee("HANUMAN",004,150000)));
            Console.WriteLine(e.DeleteEmployee(001));
            Console.WriteLine(e.DeleteEmployee(005));
            Console.WriteLine(e.SearchEmpolyee(002));
            Console.WriteLine(e.SearchEmpolyee(001));
            Employee[] emp = e.GetAllEmployees();
            foreach (Employee a in emp)
            {
                Console.WriteLine(a.Id + " " + a.Name + " " + a.Salary);
            }
        }
    }
}
