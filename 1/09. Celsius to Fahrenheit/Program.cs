using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Celsius = ");
            var C = double.Parse(Console.ReadLine());
            var F = Math.Round ( (C * 1.8 + 32), 2) ;
            Console.WriteLine("Fahrenheit = " + F);
        }
    }
}
