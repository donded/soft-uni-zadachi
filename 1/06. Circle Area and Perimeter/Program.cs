using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Circle_Area_and_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = Double.Parse (Console.ReadLine());
            Console.WriteLine($"Area is {Math.PI*r*r} ");
            Console.WriteLine($"Perimeter is {Math.PI * 2 * r} ");

        }
    }
}
