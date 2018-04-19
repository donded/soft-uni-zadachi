using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int formula = size * 2;
            string kant = new string('*', formula);
            string midKant = new string(' ', size);


            Console.WriteLine("{0}{1}{0}", kant, midKant);

            int targetrow = (size - 1) / 2 - 1;
            for (int row = 0; row < size-2; row++)

            {
                char symbol = ' ';
                if (row == targetrow)
                {
                    symbol = '|';
                }

                string slach = new string('/', formula - 2);
                string midPart = new string(symbol, size);
                Console.WriteLine("*{0}*{1}*{0}*",slach,midPart);
            }


            Console.WriteLine("{0}{1}{0}", kant, midKant);

        }
    }
}
