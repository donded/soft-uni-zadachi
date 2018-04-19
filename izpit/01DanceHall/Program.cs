using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01DanceHall
{
    class Program
    {
        static void Main(string[] args)
        {
            double L = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double a = double.Parse(Console.ReadLine());
            double Hall = (L * 100) * (w * 100);
            double Walldrob = (a * 100) * (a * 100);
            double Pejka = Hall / 10;
            double EmptySpace = Hall - Walldrob - Pejka;
            double Dancer = EmptySpace / (40 + 7000);
            Console.WriteLine(Math.Floor(Dancer));



        }
    }
}
