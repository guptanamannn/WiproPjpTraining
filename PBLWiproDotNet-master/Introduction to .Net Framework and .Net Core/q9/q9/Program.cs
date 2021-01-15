using System;

namespace q9
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a alphabet or number: ");
                char c = Console.ReadLine()[0];
                if (char.IsDigit(c))
                {
                    Console.WriteLine("Its a number");
                    break;
                }
                else if (char.IsLetter(c))
                {
                    Console.WriteLine("Its a alphabet");
                    break;
                }
                else
                {
                    Console.WriteLine("Undefined Character");
                    break;
                }

            }
        }
    }
}
