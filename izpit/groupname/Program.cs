using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            char bigLetter = char.Parse(Console.ReadLine().ToUpper());
            char letter1 = char.Parse(Console.ReadLine().ToLower());
            char letter2 = char.Parse(Console.ReadLine().ToLower());
            char letter3 = char.Parse(Console.ReadLine().ToLower());
            int num = int.Parse(Console.ReadLine());

            int counter = 0;
            for (char i = 'A'; i <=bigLetter ; i++)
            {
                for (char j = 'a'; j <= letter1; j++)
                {
                    for (char b = 'a';  b<= letter2; b++)
                    {
                        for (char c = 'c'; c <= letter3; c++)
                        {
                          for (int d = 0; d <= num ; d++)
                          {
                                if (i == bigLetter && j == letter1 && k == letter2 && l == letter3 && m == num)
                                {
                                    break;
                                }
                                counter++;
                          }

                        }

                    }

                }
            }
                     
            Console.WriteLine(counter);
        }
    }
}