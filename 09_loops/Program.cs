using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Example Code:
            int number = 0;
            while(number <= 100)
            {
                Console.WriteLine(number);
                number = number + 5;
            }

            number -= 5;
            Console.WriteLine("");

            for(int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            }
            */

            // Bronze Challenge:
            Console.WriteLine("Bronze Challenge");
            for(int i = 500; i < 526; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("");

            // Silver Challenge:
            Console.WriteLine("Silver Challenge");
            for(int i = 0; i < 101; i += 5)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("");

            // Gold Challenge:
            Console.WriteLine("Gold Challenge");
            for(int i = 1; i < 101; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if(i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if(i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }

            }

            Console.ReadLine();
        }
    }
}
