using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_conditionals_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            /*EFA Challenge
            Console.WriteLine("What's your name?");
            string inputName = Console.ReadLine().ToLower();
            switch(inputName)
            {
                case "fred": //Same as check if (inputName == "fred")
                    Console.WriteLine("Hey fred, let's go golfing.");
                    break;
                case "karl": //Same as checking: else if (inputName == "karl")
                    Console.WriteLine("Let's hang");
                    break;
                case "john": //Same as checking: else if (inputName == "john")
                    Console.WriteLine("Sorry, I'm busy right now.");
                    break;
                default: //same as else
                    Console.WriteLine("Hey " + inputName + ", can I call you back in a minute?");
                    break;
            }
            */

            Console.WriteLine("What is your friend's name?");
            string friend = Console.ReadLine().ToLower();

            switch(friend)
            {
                case "seth":
                    Console.WriteLine("Seth is my best friend. He would take a bullet for me.");
                    break;
                case "chris":
                    Console.WriteLine("Chris is my best long distance friend. I can guarantee I'll always get good advice from him when I need it.");
                    break;
                case "jason":
                    Console.WriteLine("Jason is my best friend at church. We share lots of interests and talk every day. He's like the big brother I never had.");
                    break;
                case "stephen":
                    Console.WriteLine("Stephen is the best friend I've ever had that would go out of his way to make sure you have something you want. He's seriously one of the nicest guys on the planet.");
                    break;
                default:
                    Console.WriteLine("Sorry that friend didn't make this list but I'm sure they are still awesome!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
