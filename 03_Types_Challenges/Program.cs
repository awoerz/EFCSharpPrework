using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Types_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //Int Section
            int declaredInt;
            declaredInt = 3;
            int declaredAndInitInt = 7;
            printTheThings("Int", declaredInt.ToString(), declaredAndInitInt.ToString());

            //String Section
            string declaredString;
            declaredString = "This is a declared string and is assigned later.";
            string declaredAndInitString = "This string is both declared inistialized on the same line: ";
            printTheThings("String", declaredString.ToString(), declaredAndInitString.ToString());

            //Bool Section
            bool declaredFalse;
            declaredFalse = false;
            bool declaredAndInitTrue = true;
            printTheThings("Bool", declaredFalse.ToString(), declaredAndInitTrue.ToString());

            //Float Section
            float declaredFloat;
            declaredFloat = 1.654984f;
            float declaredAndInitFloat = 1654.321f;
            printTheThings("Float", declaredFloat.ToString(), declaredAndInitFloat.ToString());

            //Double Section
            double declaredDouble;
            declaredDouble = 1.506548654654d;
            double declaredAndInitDouble = 2.5987349875347534d;
            printTheThings("Double", declaredDouble.ToString(), declaredAndInitDouble.ToString());

            //Decimal Section
            decimal declaredDecimal;
            declaredDecimal = 2.43543346345345m;
            decimal declaredAndInitDecimal = 23.2349872394873m;
            printTheThings("Decimal", declaredDecimal.ToString(), declaredAndInitDecimal.ToString());

            //Silver Challenge
            string concatinatedStrings = declaredString + " " + declaredAndInitString;
            Console.WriteLine("This is me concatinating two strings: \n" + concatinatedStrings);
            Console.WriteLine("");

            //Gold Challenge
            int myBirthYear = Int32.Parse("1990");
            Console.WriteLine("My birth year: " + myBirthYear);
            Console.WriteLine("");

            Console.ReadLine();
        }

        //Function or Method (whatever you want to call it) to make my life easier when printing all the things I made.
        static void printTheThings(string thingToPrint, string declaredThing, string declaredAndInitThing)
        {
            Console.WriteLine("The declared \"" + thingToPrint + "\" and then assigned later: " + declaredThing);
            Console.WriteLine("The declared and initialized \"" + thingToPrint + "\" : " + declaredAndInitThing);
            Console.WriteLine("");
        }
    }
}
