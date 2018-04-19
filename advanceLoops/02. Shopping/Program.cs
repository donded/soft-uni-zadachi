using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int chocolateCuant = int.Parse(Console.ReadLine());
            int milkqty = int.Parse(Console.ReadLine());

            double chocoPrice = 0.65 * chocolateCuant;
            double milkPrice = 2.7 * milkqty;
            double mandarins = Math.Floor(chocolateCuant -(chocolateCuant * 0.35));
            double mandarinsPrice = 0.2 * mandarins;

            double total = mandarinsPrice + chocoPrice + milkPrice;
            if (total <= budget)

            {
                double budgetisBigger = budget - total;
                Console.WriteLine($"You got this, {budgetisBigger:F2} money left!");

            }
            else
            {
                Double budgetisLower = budget - total;
                Console.WriteLine($"Not enough money, you need {budgetisLower:F2}  more!");
            }


        }
    }
}
