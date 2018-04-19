using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberToread = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < numberToread; i++)
            {
                int number = int.Parse(Console.ReadLine());

                sum += number;
            }
            Console.WriteLine(sum);
        }
    }
}
