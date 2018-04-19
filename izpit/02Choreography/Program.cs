using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Choreography
{
    class Program
    {
        static void Main(string[] args)
        {
            double steps = double.Parse(Console.ReadLine());
            double dancer = double.Parse(Console.ReadLine());
            double Deys = double.Parse(Console.ReadLine());

            double stepsPerDeys = Math.Ceiling( 100 / Deys);
            double stepsPerDancer =(stepsPerDeys / dancer);
            

            if (stepsPerDeys <= 13)
            {
                Console.WriteLine($"Yes, they will succeed in that goal! {stepsPerDancer:F2}%.");
            }
            else
            {
                Console.WriteLine($"No, They will not succeed in that goal! Required {stepsPerDancer:F2}% steps to be learned per day.");
            }
        }
    }
}
