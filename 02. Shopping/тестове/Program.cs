﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.X
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sidespaces;
            int midspaces = n - 2;

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}x{1}x", new string(' ', i), new string(' ', midspaces));
                midspaces -= 2;
            }
            Console.WriteLine("{0}x", new string(' ', n / 2));
            midspaces += 2;
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Console.WriteLine("{0}x{1}x", new string(' ', i), new string(' ', midspaces));
                midspaces += 2;
            }
        }
    }
}