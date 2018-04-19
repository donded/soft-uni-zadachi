using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var Projection = Console.ReadLine().ToLower();
            var red = int.Parse(Console.ReadLine());
            var colons = int.Parse(Console.ReadLine());
            var result = 0.0;

            if (Projection == "premiere")
            {
                result = red * colons * 12;

            }
            else if (Projection == "normal")
            {
                result = red * colons * 7.5;

               
            }
            else if (Projection == "discount")
            {
                result = red * colons * 5;

                
            }
           
            Console.WriteLine("{0:F2} leva", result);
        }
    }
}
