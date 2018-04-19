using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine().ToLower();
            var town = Console.ReadLine().ToLower();
            var quantity = Double.Parse(Console.ReadLine());
            string cofee = "coffee";
            string water = "water";
            string beer = "beer";
            string sweets = "sweets";
            string peanuts = "peanuts";

            if (town == "sofia")
            {
                if (product == cofee)
                {
                    Console.WriteLine(quantity * 0.5);
                }
                if (product == water)
                {
                    Console.WriteLine(quantity * 0.8);
                }
                if (product == beer)
                {
                    Console.WriteLine(quantity * 1.2);
                }
                if (product == sweets)
                {
                    Console.WriteLine(quantity * 1.45);
                }
                if (product == peanuts)
                {
                    Console.WriteLine(quantity * 1.6);
                }

            }
            if (town == "plovdiv")
            {
                if (product == cofee)
                {
                    Console.WriteLine(quantity * 0.4);
                }
                if (product == water)
                {
                    Console.WriteLine(quantity * 0.7);
                }
                if (product == beer)
                {
                    Console.WriteLine(quantity * 1.15);
                }
                if (product == sweets)
                {
                    Console.WriteLine(quantity * 1.30);
                }
                if (product == peanuts)
                {
                    Console.WriteLine(quantity * 1.5);
                }

            }
            if (town == "varna")
            {
                if (product == cofee)
                {
                    Console.WriteLine(quantity * 0.45);
                }
                if (product == water)
                {
                    Console.WriteLine(quantity * 0.7);
                }
                if (product == beer)
                {
                    Console.WriteLine(quantity * 1.10);
                }
                if (product == sweets)
                {
                    Console.WriteLine(quantity * 1.35);
                }
                if (product == peanuts)
                {
                    Console.WriteLine(quantity * 1.55);
                }
            }

        }
    }
}

