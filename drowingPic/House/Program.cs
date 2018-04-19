using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication31
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int a = 1; a <= number; a++)
            {
                for (int b = 1; b <= number; b++)
                {
                    for (int c = 1; c <= number; c++)
                    {
                        for (int d = 1; d <= number; d++)
                        {
                            for (int e = 1; e <= number; e++)
                            {
                                for (int f = 1; f <= number; f++)
                                {
                                    if (a * b * c * d * e * f == number)
                                    {
                                        Console.WriteLine("{0}{1}{2}{3}{4}{5} ", a, b, c, d, e, f);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}