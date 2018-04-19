﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._2D_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse (Console.ReadLine());
            var y1 = double.Parse (Console.ReadLine());
            var x2 = double.Parse (Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            var Wight = Math.Abs(x1 - x2);
            var Hight = Math.Abs(y1 - y2);

            Console.WriteLine($"Area =  {Wight * Hight}");
            Console.WriteLine($"Perimeter = {(Wight+Hight)*2}");
        }
    }
}
