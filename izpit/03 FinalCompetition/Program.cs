using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_FinalCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int dancer = int.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = Console.ReadLine();
            double monyBG = dancer * points;
            double monyAbroad = (dancer * points) + (0.50*points);
            double WinterMonyBG = monyBG - (0.08 * monyBG);
            double sommerMonyBG = monyBG - (0.05 * monyBG);
            double WinterMonyAbroad = monyAbroad - (0.15 * monyAbroad);
            double SommerMonyAbroad = monyAbroad - (0.10 * monyAbroad);
            
            
            if (season == "winter" && place =="Bulgaria")
            {
                double Charty = WinterMonyBG * 0.75;
                Console.WriteLine($"Charity - {Charty:F2}");
                double monyPerDancer = (WinterMonyBG - Charty)/dancer;
                Console.WriteLine($"Money per dancer - {monyPerDancer:F2}");
            }
            else if (season == "winter" && place == "Abroad")
            {
                double Charty = WinterMonyAbroad * 0.75;
                Console.WriteLine($"Charity - {Charty:F2}");
                double monyPerDancer = (WinterMonyAbroad - Charty) / dancer;
                Console.WriteLine($"Money per dancer - {monyPerDancer:F2}");

            }
            else if (season == "summer" && place == "Bulgaria")
            {
                double Charty = sommerMonyBG * 0.75;
                Console.WriteLine($"Charity - {Charty:F2}");
                double monyPerDancer = (sommerMonyBG - Charty) / dancer;
                Console.WriteLine($"Money per dancer - {monyPerDancer:F2}");
            }
            else if (season == "summer" && place == "Abroad")
            {
                double Charty = SommerMonyAbroad * 0.75;
                Console.WriteLine($"Charity - {Charty:F2}");
                double monyPerDancer = (SommerMonyAbroad - Charty) / dancer;
                Console.WriteLine($"Money per dancer - {monyPerDancer:F2}");
            }
        }
    }
}
