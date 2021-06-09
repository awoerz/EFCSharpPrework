using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_boolean_challenges
{
    class Program
    {
        static void Main(string[] args)
        {

            //Silver Challenge
            /*
            float value = 101 / 2f;
            if (value == 50)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            */

            //Gold Challenge with a random number between 1 and 10.
            //The program continues until the user guesses the correct answer.
            bool keepGoing = true;
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 10);
            while(keepGoing)
            {
                Console.WriteLine("Please guess a number between 1 and 10");
                string userResponse = Console.ReadLine();
                int intUserRepsonse = Int32.Parse(userResponse);
                if (intUserRepsonse == randomNumber)
                {
                    Console.WriteLine($"Congrats {intUserRepsonse} was the correct number!");
                    keepGoing = false;
                }
                else if (intUserRepsonse < 1 || intUserRepsonse > 10)
                {
                    Console.WriteLine("Seriously, you need to read the instrucitons. GUESS BETWEEN 1 and 10!");
                }
                else if (intUserRepsonse < randomNumber)
                {
                    Console.WriteLine("You need to guess higher!");
                }
                else if (intUserRepsonse > randomNumber)
                {
                    Console.WriteLine("You need to guess lower!");
                }
                else
                {
                    Console.WriteLine("You really messed something up!");
                }

            }
        }
    }
}
