using System;

namespace q1
{
    class Customers
    {
        String fname;
        String lname;
        int age;

        public Customers(String first, String Last, int Age)
        {
            this.fname = first;
            this.lname = Last;
            this.age = Age;
        }

        public void printcustomersdetails()
        {
            Console.WriteLine("Name = " + fname + " " + lname + "\nAge = " + age);
        }
    }
    class Programcars
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Customer details>>");
            Console.WriteLine("First Name:");
            String nam1 = Console.ReadLine();
            Console.WriteLine("Last Name:");
            String nam2 = Console.ReadLine(); 
            Console.WriteLine("Age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Customers c1 = new Customers(nam1, nam2, age);


            Console.WriteLine("Enter Car details>>");
            Console.WriteLine("Car Make:");
            String carname1 = Console.ReadLine();
            Console.WriteLine("Car Model:");
            String model = Console.ReadLine();
            Console.WriteLine("MFG Year:");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("City:");
            String city = Console.ReadLine();
            Cars car1 = new Cars(carname1, model, year, city);
            c1.printcustomersdetails();
            car1.DisplayCar();
            Console.ReadKey();
        }
    }
    class Cars
    {
        string carname1, model, city;
        int year;
        public Cars(String carmake, String CarModel, int MFGYear, String City)
        {
            this.carname1 = carmake;
            this.city = City;
            this.model = CarModel;
            this.year = MFGYear;
        }
        public void DisplayCar()
        {
            Console.WriteLine("Details are as follows>>");
            Console.WriteLine("Car Make: " + this.carname1 + "\nCar Model: " + this.model + "\nMFG Year: " + this.year + "\nCity: " + this.city);
        }
    }
}
