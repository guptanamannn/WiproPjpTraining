using System;
using System.Linq;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Add");
            Console.WriteLine("2.Delete");
            Console.WriteLine("3.Update");
            int c = Convert.ToInt32(Console.ReadLine());
            if (c == 1)
            {
                using (var context = new SchoolContext())
                {
                    var std = new Student()
                    {
                        Name = "Adil",



                    };
                    context.Students.Add(std);
                    context.SaveChanges();
                }
            }
            else if (c == 2)
            {
                using (var context = new SchoolContext())
                {
                    var std = context.Students.First<Student>();
                context.Students.Remove(std);

                

                context.SaveChanges();
            }
        }
            else if (c == 3)
            {
                using (var context = new SchoolContext())
                {
                    var std = context.Students.First<Student>();
                    context.Students.Remove(std);

                 

                    context.SaveChanges();
                }
                using (var context = new SchoolContext())
                {
                    var std = context.Students.First<Student>();
                    std.Name = "Akshay";
                    context.SaveChanges();
                }
            }
        }
    }
}
