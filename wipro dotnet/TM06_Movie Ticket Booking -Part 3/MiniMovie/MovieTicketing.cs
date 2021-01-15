using System;
using System.Collections.Generic;
using System.Text;

namespace MiniMovie
{
    class MovieTicketing
    {
        List<User> UserInformation = new List<User>();
        List<Theatre> Theatres = new List<Theatre>();
        List<Show> Shows = new List<Show>();
        List<Booking> Bookings = new List<Booking>();
        List<Movie> Movies = new List<Movie>();
        public MovieTicketing(string username,string password,string type)
        {
            //User u = new User(username,password,type);
            UserInformation.Add(new User(username, password, type));
        }
        public string Login()
        {
            Console.WriteLine("please enter username and password");
            string username = Console.ReadLine();
            string password = Console.ReadLine();
            if(UserInformation.Exists(u=>u.UserName==username&&u.Password==password))
            {
                User user = UserInformation.Find(u => u.UserName == username && u.Password == password);
                return user.UserType;
            }
            return "Null";
        }
        public void AdminMenu()
        {
            
            bool c = true;
            while(c)
            {
                Console.WriteLine("1.Add Theatre");
                Console.WriteLine("2.Update Theatre");
                Console.WriteLine("3.Add Movie");
                Console.WriteLine("4.Update Movie");
                Console.WriteLine("5.Add Show");
                Console.WriteLine("6.Update Show");
                Console.WriteLine("7.Delete Show");
                Console.WriteLine("8.Display Theatres");
                Console.WriteLine("9.Display Movies");
                Console.WriteLine("10.Display Shows");
                Console.WriteLine("11.Add Agent");
                Console.WriteLine("12.Book Ticket");
                Console.WriteLine("13.Print Ticket");
                Console.WriteLine("14.Exit");
                //Console.WriteLine("Enter your choice");
                int ch = GetChoice();
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter Theatre Name");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter Theatre Place");
                        string place = Console.ReadLine();
                        Theatres.Add(new Theatre(name, place));
                        Console.WriteLine("Theatre added successfully");
                        break;
                    case 2:
                        Console.WriteLine("Enter the old and new theatre name");
                        string old = Console.ReadLine();
                        string neww = Console.ReadLine();
                        Theatre t = Theatres.Find(thea => thea.TheatreName == old);
                        t.TheatreName = neww;
                        Console.WriteLine("Theatre name updated successfully");
                        break;
                    case 3:
                        Console.WriteLine("Enter movie name");
                        string movie = Console.ReadLine();
                        Movies.Add(new Movie(movie));
                        Console.WriteLine("Movie added successfully");
                        break;
                    case 4:
                        Console.WriteLine("Enter the old and new movie name");
                        string oldmovie = Console.ReadLine();
                        string newmovie = Console.ReadLine();
                        Movie m = Movies.Find(m => m.Moviename == oldmovie);
                        m.Moviename = newmovie;
                        Console.WriteLine("Movie updated successfully");
                        break;
                    case 5:
                        Console.WriteLine("Enter the show name");
                        Shows.Add(new Show(Console.ReadLine()));
                        Console.WriteLine("Show added sucessfully");
                        break;
                    case 6:
                        Console.WriteLine("Enter old and new shows");
                        string oldshow = Console.ReadLine();
                        string newshow = Console.ReadLine();
                        Show ss = Shows.Find(shh => shh.show == oldshow);
                        ss.show = newshow;
                        break;
                    case 7:
                        Console.WriteLine("Enter the show you want to delete");
                        string sho = Console.ReadLine();
                        Show showw = Shows.Find(ss => ss.show == sho);
                        Shows.Remove(showw);
                        Console.WriteLine("Show deleted successfully");
                        break;
                    case 8:
                        foreach(Theatre the in Theatres)
                        {
                            Console.WriteLine(the.TheatreName+" "+the.TheatrePlace);
                        }
                        break;
                    case 9:
                        foreach(Movie mo in Movies)
                        {
                            Console.WriteLine(mo.Moviename);
                        }
                        break;
                    case 10:
                        foreach(Show sss in Shows)
                        {
                            Console.WriteLine(sss.show);
                        }
                        break;
                    case 11:
                        Console.WriteLine("Added agent");
                        break;
                    case 12:
                        Console.WriteLine("Enter ticket number");
                        Bookings.Add(new Booking(int.Parse(Console.ReadLine())));
                        Console.WriteLine("Ticket Booked");
                        break;
                    case 13:
                        foreach(Booking b in Bookings)
                        {
                            Console.WriteLine(b.Ticket);
                        }
                        break;
                    case 14:
                        Console.WriteLine("Exiting");
                        c = false;
                        break;




                }
            }

        }
        public void AgentMenu()
        {
            bool d = true;
            while(d)
            {
                Console.WriteLine("1.View Shows");
                Console.WriteLine("2.new Ticket");
                Console.WriteLine("3.Print Ticket");
                Console.WriteLine("4.Exit");
                //Console.WriteLine("Enter your choice");
                int cho = GetChoice();
                switch(cho)
                {
                    case 1:
                        foreach(Show shoo in Shows)
                        {
                            Console.WriteLine(shoo.show);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter ticket number");
                        Bookings.Add(new Booking(int.Parse(Console.ReadLine())));
                        Console.WriteLine("Ticket booked");
                        break;
                    case 3:
                        foreach(Booking bb in Bookings)
                        {
                            Console.WriteLine(bb.Ticket);
                        }
                        break;
                    case 4:
                        Console.WriteLine("Exitng");
                        d = false;
                        break;
                }
            }
        }
        public int GetChoice()
        {
            Console.WriteLine("Enter your choice");
            return (int.Parse(Console.ReadLine()));
        }
    }
}
