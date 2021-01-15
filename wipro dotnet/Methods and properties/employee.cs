using System;

namespace myapp
{
    class Employee
    {
        string Name;
        double Basic_salary,Net_salary,HRA,DA,TAX,Gross_Pay;
        Employee(string Name,double Basic_salary)
        {
            this.Name=Name;
            this.Basic_salary=Basic_salary;
        }
        public void CalculateNetPay()
        {
            HRA=(15*Basic_salary)/100;
            DA=(10*Basic_salary)/100;
            Gross_Pay=Basic_salary+HRA+DA;
            TAX=(8*Gross_Pay)/100;
            Net_salary=Gross_Pay-TAX;
        }
        public void Display()
        {
            Console.WriteLine("Name of the Employee : "+Name);
            Console.WriteLine("Basic Salary : "+Basic_salary);
            Console.WriteLine("House Rent Allowance(HRA) : "+HRA);
            Console.WriteLine("Dearness Allowance(DA) : "+DA);
            Console.WriteLine("Gross Pay : "+Gross_Pay);
            Console.WriteLine("Tax : "+TAX);
            Console.WriteLine("Net salary : "+Net_salary);
        }
        static void Main(string[] args)
        {
            string Name=Console.ReadLine();
            double Basic_salary=Convert.ToDouble(Console.ReadLine());
            Employee e=new Employee(Name,Basic_salary);
            e.CalculateNetPay();
            e.Display();
        }

        

    }
}
