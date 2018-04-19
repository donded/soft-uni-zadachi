using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberAsWords
{
    class NumberAsWords
    {
        static void Main(string[] args)


        {
            int number = int.Parse(Console.ReadLine());

            
            string [] zeroNine = new string[10] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] tenNineteen = new string[10] {"ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen",
                "seventeen", "eighteen", "nineteen"};
            string[] lastZero = new string[10] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            if (number < 0 || number > 100)
            {
                Console.WriteLine("invalid number");

            }

            else if (number == 100)
            {
                Console.WriteLine("one hundred");
            }
                else if (number < 10)
            {
                Console.WriteLine(zeroNine[number]);
            }
            else if (number > 9 && number < 20)
            {
                number = number % 10;
                Console.WriteLine(tenNineteen[number]);
            }
            else if (number > 19 && number < 100)
            {
                if (number % 10 == 0)
                {
                    Console.WriteLine(lastZero[number / 10]);
                }
                else
                {
                    Console.WriteLine(lastZero[number / 10] + " " + zeroNine[number % 10]);

                }
            }

        }
    }
}