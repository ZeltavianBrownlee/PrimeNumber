using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNum
{
    class Program
    {
        static bool isPrime (int x)   
        {
           
            //increment through numbers to see if number is divisible by any other numbers
            for (int i = 2; i < x; i++)
            {
                //not prime
                if (x % i == 0)
                {
                    return false;
                }

            }//end for loop
            //prime number
            return true; 


        }
        static void Main(string[] args)
        {
            // declare and intialize variables
            int number = 0;

            //prompt for and get number
            Console.Write("Please enter number. ");
            number = Convert.ToInt32(Console.ReadLine());

            //Display the number is prime
            Console.WriteLine("{0} is prime = {1}", number, isPrime(number));

            Console.ReadKey();


        }
    }
}
