using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int emptySpace = n - 1;
            for (int row = 0; row < n; row++)

            {
                for (int col = 0; col < emptySpace; col++)
                {
                    Console.Write(' ');
                }

                Console.Write('*');
                for (int col = 0; col < row; col++)
                {
                    Console.Write(" *");

                }

                emptySpace -= 1;
                
                Console.WriteLine();
            }
            int numOfStars = n - 1;
            int Space = 1;
            int botrow = n - 1;
            for (int row = 0; row < botrow; row++)
            {
                
                for (int stars = 0; stars < Space; stars++)
                {
                    Console.Write(' ');
                }
                
                Console.Write("*");
                for (int col = 0; col < numOfStars - 1; col++)
                {
                    Console.Write(" *");
                }
                Space++;
                numOfStars--;
               
                

                Console.WriteLine();
            }
            
        }
    }
}
