using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Concatenate_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNAME = Console.ReadLine();
            var lastNAME = Console.ReadLine();
            var age = Console.ReadLine();
            var town = Console.ReadLine();
            Console.WriteLine("You are {0}, {1} +'a' { 2} + years old, from {3}", firstNAME,lastNAME,age,town );
        }
    }
}
