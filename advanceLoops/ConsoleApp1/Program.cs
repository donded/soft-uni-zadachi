﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rinRange1to100;
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter valid number in Range [1 to 100]");
            int num = int.Parse(Console.ReadLine());
            while (num < 1 || num > 100)
            {
                Console.WriteLine("Invalid Number, try again!");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The Number is:");
            Console.Write(num);
        }
    }
}
