using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            bool anotherBoolean = false;
            Console.WriteLine("Just practicing variable declaration. Here's a boolean : " + anotherBoolean );

            decimal aDecimal = 7.773m;
            Console.WriteLine("I'm not sure decimal is a default data type of C# if you're not working in .NET. This is a question for later. " +
                "Anyway, here is a decimal declaration: " + aDecimal);

            Console.WriteLine("Just real quick, a reminder to myself ... \"f\" follows a floating point number and \"m\" follows a decimal.");

            Console.ReadLine();
        }
    }
}
