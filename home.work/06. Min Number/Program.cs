﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            for (int i = 0; i < number; i++)
            {
                int number_read = int.Parse(Console.ReadLine());
                if (number_read < min)
                {
                    min = number_read;
                }
            }
            Console.WriteLine(min);
        }
    }
}
