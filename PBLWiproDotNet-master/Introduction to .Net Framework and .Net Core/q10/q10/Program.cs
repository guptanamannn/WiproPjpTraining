using System;

namespace q10
{
    class Program
    {
        static int countOccurrances(int n,
                            int d)
        {
            int count = 0;

            // Loop to find the digits of N 
            while (n > 0)
            {

                // check if the digit is D 
                count = (n % 10 == d) ?
                            count + 1 : count;
                n = n / 10;
            }

            // return the count of the 
            // occurrences of D in N 
            return count;
        }

        // Driver code 
        public static void Main()
        {
            Console.WriteLine("Input1 from user: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input2 from user: ");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Occurance of {0} is {1}.",d,countOccurrances(n, d));
        }
    }
}
