
using System;
namespace myapp
{
   class Fruit
   {
        public string name;
        public string taste;
        public string size;
        public void eat()
       {
             Console.WriteLine("in class Fruit");
       }

   } 
 class Apple:Fruit
   {
        public void eat()
       {
            name="Apple";
            taste="sweet";
             Console.WriteLine("in class Apple");
              Console.WriteLine(name+"\n"+taste);
       }
   }
   class Orange:Fruit
   {
        public void eat()
       {
            name="orange";
            taste="sour";
             Console.WriteLine("in class Orange");
              Console.WriteLine(name+"\n"+taste);
       }
   }
  
      class main
        {
        static void Main(string[] args)
        {
            Fruit f=new Fruit();
            Apple a=new Apple();
            Orange o=new Orange();
             f.eat();
            a.eat();
            o.eat();
           
        }
    }
}

