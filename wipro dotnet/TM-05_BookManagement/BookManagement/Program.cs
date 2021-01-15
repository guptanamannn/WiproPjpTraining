using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Management
{
    class Author
    {
        private string AuthorName, AuthorEmail;
        private char gender;
        public Author(string AuthorName, string AuthorEmail, char Gender)
        {
            this.AuthorName = AuthorName;
            this.AuthorEmail = AuthorEmail;
            this.gender = Gender;
        }
        public string Name
        {
            get { return AuthorName; }
            set { AuthorName = value; }
        }
        public string Email
        {
            get { return AuthorEmail; }
            set { AuthorEmail = value; }
        }
        public char Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public void DisplayAuthorDetails()
        {
            Console.WriteLine("Name of Author is {0}", AuthorName);
            Console.WriteLine("Gender of Author is {0}", Gender);
            Console.WriteLine("Email Address of Author is {0}", AuthorEmail);
        }
    }
    class Book
    {
        private string ISBN, AuthorName, AuthorEmail, BookName;
        private char Gender;
        private int YearPublished;
        private decimal Price;
        public Author AuthorDetails;
        public Book(string ISBN, string BookName, int YearPublished, decimal Price, string AuthorName, string AuthorEmail, char Gender)
        {
            this.ISBN = ISBN;
            this.BookName = BookName;
            this.YearPublished = YearPublished;
            this.Price = Price;
            this.AuthorName = AuthorName;
            this.AuthorEmail = AuthorEmail;
            this.Gender = Gender;
            this.AuthorDetails = new Author(AuthorName, AuthorEmail, Gender);
        }

        public string isbn
        {
            get { return ISBN; }
            set { ISBN = value; }
        }
        public string Bookname
        {
            get { return BookName; }
            set { BookName = value; }
        }
        public int year
        {
            get { return YearPublished; }
            set { YearPublished = value; }
        }
        public decimal price
        {
            get { return Price; }
            set { Price = value; }
        }

        public Author details
        {
            get { return AuthorDetails; }
            set { AuthorDetails = value; }
        }

        public void DisplayBookDetails()
        {
            Console.WriteLine("Book Name {0}", BookName);
            Console.WriteLine("Book Price {0}", Price);
            Console.WriteLine("Book Year published {0}", BookName);
            Console.WriteLine("Book ISBN{0} ", ISBN);
        }
    }
    class BookMangment
    {
        List<Book> Rack = new List<Book>();

        public void AddBook()
        {
            Console.WriteLine("Enter Book name");
            String BookName = Console.ReadLine();
            Console.WriteLine("Enter International Standard Book Number(ISBN)");
            string ISBN = Console.ReadLine();
            Console.WriteLine("Enter Year Published");
            int YearPublished = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Price of the Book");
            Decimal Price = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter name of Author");
            string AuthorName = Console.ReadLine();
            Console.WriteLine("Enter Gender of Author");
            char Gender = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter Email Address of Author");
            string AuthorEmail = Console.ReadLine();

            if (Rack.Count < 10)
            {
                Rack.Add(new Book(ISBN, BookName, YearPublished, Price, AuthorName, AuthorEmail, Gender));
            }
            else if (Rack.Count >= 10)
            {
                Console.WriteLine("Rack Array is Filled. Can't add more Books");
            }
        }
        public void SearchBoook()
        {
            Console.WriteLine("Enter ISBN Value");
            string search = Console.ReadLine();
            int flag = 0;
            foreach (var b in Rack)
            {
                int res = string.Compare(b.isbn, search);
                if (res == 0)
                {
                    flag = 1;
                    Console.WriteLine("True");
                    break;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("False");
            }
        }
        public void ViewBook()
        {
            foreach (var b in Rack)
            {
                b.DisplayBookDetails();
            }
        }
        public void ViewAuthors()
        {
            foreach (var b in Rack)
            {
                b.details.DisplayAuthorDetails();
            }
        }
        public void UpdateBook()
        {
            Console.WriteLine("Enter ISBN Number of Book ");
            string SearchISBN = Console.ReadLine();
            Console.WriteLine("What you want to update?");
            Console.WriteLine("1. Author Details");
            Console.WriteLine("2. Book Details");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 1)
            {
                Console.WriteLine("Which detail you want to update");
                Console.WriteLine("1. Author Name");
                Console.WriteLine("2. Author Email");
                Console.WriteLine("3. Author gender");
                int a1 = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < Rack.Count; i++)
                {
                    if (Rack[i].isbn == SearchISBN)
                    {
                        if (a1 == 1)
                        {
                            Console.WriteLine("Enter New Name");
                            string newname = Console.ReadLine();
                            Rack[i].AuthorDetails.Name = newname;
                        }
                        else if (a1 == 2)
                        {
                            Console.WriteLine("Enter New Email");
                            string newemail = Console.ReadLine();
                            Rack[i].AuthorDetails.Email = newemail;
                        }
                        else if (a1 == 3)
                        {
                            Console.WriteLine("Enter new Gender");
                            char newgender = Convert.ToChar(Console.ReadLine());
                            Rack[i].AuthorDetails.Gender = newgender;
                        }
                        else
                        {
                        }
                    }
                }
            }
            else if (num == 2)
            {
                Console.WriteLine("Which detail you want to update");
                Console.WriteLine("1. Book Name ");
                Console.WriteLine("2. Year Published ");
                Console.WriteLine("3. Price ");
                int a2 = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < Rack.Count; i++)
                {
                    if (Rack[i].isbn == SearchISBN)
                    {
                        if (a2 == 1)
                        {
                            Console.WriteLine("Enter New Book Name");
                            string newbookname = Console.ReadLine();
                            Rack[i].Bookname = newbookname;
                        }
                        else if (a2 == 2)
                        {
                            Console.WriteLine("Enter New Year Published");
                            int newyear = Convert.ToInt32(Console.ReadLine());
                            Rack[i].year = newyear;

                        }
                        else if (a2 == 3)
                        {
                            Console.WriteLine("Enter new Price");
                            decimal newprice = Convert.ToDecimal(Console.ReadLine());
                            Rack[i].price = newprice;
                        }
                        else
                        {
                        }
                    }
                }
            }
        }
        static void Main()
        {
            var book = new BookMangment();
            Console.WriteLine("\t\t\tBook Author Details\t\t\t");
            while (true)
            {
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Search Book");
                Console.WriteLine("3. Update Book");
                Console.WriteLine("4. View All Books");
                Console.WriteLine("5. View All Authors");
                Console.WriteLine("6. Exit");

                int x = Convert.ToInt32(Console.ReadLine());

                if (x == 6)
                {
                    break;
                }
                else
                {
                    switch (x)
                    {
                        case 1:
                            book.AddBook();
                            break;
                        case 2:
                            book.SearchBoook();
                            break;
                        case 3:
                            book.UpdateBook();
                            break;
                        case 4:
                            book.ViewBook();
                            break;
                        case 5:
                            book.ViewAuthors();
                            break;
                        default:
                            Console.WriteLine("Enter Correct Choice");
                            break;
                    }
                }
            }
        }
    }
}