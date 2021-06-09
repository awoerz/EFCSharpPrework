using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_classes_and_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Donut dougDonut = new Donut();
            Donut chrisDonut = new Donut();
            Donut nickDonut = new Donut();

            dougDonut.Filling = "cherry";
            dougDonut.Price = 3m;
            dougDonut.Type = "normal";
            dougDonut.IsSpecial = true;
            dougDonut.calories = 250;

            chrisDonut.Filling = "none";
            chrisDonut.Price = 2m;
            chrisDonut.Type = "small";
            chrisDonut.IsSpecial = false;
            chrisDonut.calories = 250;

            nickDonut.Filling = "chocolate";
            nickDonut.Price = 3m;
            nickDonut.Type = "normal";
            nickDonut.IsSpecial = true;
            nickDonut.calories = 350;

            Console.WriteLine(nickDonut.Filling);

            Console.ReadLine();
        }
    }
}
