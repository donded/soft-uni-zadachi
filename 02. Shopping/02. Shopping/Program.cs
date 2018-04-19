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
            double chocolateQty = double.Parse(Console.ReadLine());
            double milkQty = double.Parse(Console.ReadLine());
            double Mandarins = Math.Floor(chocolateQty - (chocolateQty * 0.35));
            double chocoPrice = chocolateQty * 0.65;
            double mandarinsPrice = Mandarins * 0.2;
            double milkPrice = milkQty * 2.70;
            double totalPrice = chocoPrice + mandarinsPrice + milkPrice;
            
            double enouf = budget - totalPrice;
            if (budget>=totalPrice)
            {
                double Bigger = budget - totalPrice;
                Console.WriteLine($"You got this, {Bigger:F2} money left!");
            }
            else
            {
                double Lower = totalPrice - budget;
                Console.WriteLine($"Not enough money, you need {Lower:F2} more!");
            }

        }
    }
}
