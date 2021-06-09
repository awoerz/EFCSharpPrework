using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            printModulusTwoIntegers(10, 3); //should return 1
            printModulusTwoIntegers(9, 2); //should return 1
            printModulusTwoIntegers(10, 22); //should return 12
            printModulusTwoIntegers(13, 12); //should return 1

            Console.ReadLine();
        }

        static void printModulusTwoIntegers(int firstNum, int secondNum)
        {
            Console.WriteLine("The return of " + firstNum + " % " + secondNum + ": " + firstNum % secondNum);
            Console.WriteLine("");
        }
    }
}
