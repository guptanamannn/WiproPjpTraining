using System;

namespace MiniMovie
{
    class Program
    {
        static void Main(string[] args)
        {
            MovieTicketing m = new MovieTicketing("sindhu", "123", "agent");
            string type=m.Login();
            if(type=="Admin"||type=="admin")
            {
                m.AdminMenu();
            }
            else if(type=="agent"||type=="Agent")
            {
                m.AgentMenu();
            }
            else
            {
                Console.WriteLine("Incorrect username or password.Please try again later");
            }
        }
    }
}
