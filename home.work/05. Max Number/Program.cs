using System;
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
            int max = int.MinValue;
            for (int i = 0; i < number; i++)
            {
                int number_read = int.Parse(Console.ReadLine());
                if (number_read > max)
                {
                    max = number_read;
                }
            }
            Console.WriteLine(max);
        }
    }
}
