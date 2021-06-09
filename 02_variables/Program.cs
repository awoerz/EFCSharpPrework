using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int luckyNumber = 7;
            Console.WriteLine("Lucky Number: " + luckyNumber);

            long hugeNumber;
            hugeNumber = 123123123123;
            Console.WriteLine("Huge Number: " + hugeNumber);

            float floatyDecimal = 7.123F;
            Console.WriteLine("Floaty Decimal Number: " + floatyDecimal);

            float bigDouble = 7.12345324234214324F;
            Console.WriteLine("Big Doubley Decimal: " + bigDouble);

            bool isTrueOrFalse = true;
            Console.WriteLine("Boolean Truthy: " + isTrueOrFalse);

            char lookALetter = 'A';
            Console.WriteLine("Just a letter: " + lookALetter);
            
            string firstName = "Adam";
            Console.WriteLine("First Name" + firstName);

            Console.ReadLine();            
        }
    }
}
