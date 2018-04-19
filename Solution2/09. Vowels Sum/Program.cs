using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int sum = 0;
            for (int currentIndex = 0; currentIndex <= text.Length-1; currentIndex++)
            {
                char symbol = text[currentIndex];

                switch (symbol)
                {
                    case 'a':
                        sum += 1;
                        break;

                    case 'e':
                        sum += 2;
                        break;
                    case 'i':

                        sum += 3;
                        break;
                    case 'o':
                        sum += 4;
                        break;
                    case 'u':

                        sum += 5;
                        break;
                }
                Console.WriteLine(sum);
            }
            
        }
    }
}
