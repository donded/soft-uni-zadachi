using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int emptySpaces = size;
            int rows = size + 1;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < emptySpaces; col++)
                {
                    Console.Write(' ');
                }

                for (int col = 0; col < row; col++)
                {
                    Console.Write('*');


                }

                Console.Write(" | ");

                for (int col = 0; col < row; col++)
                {
                    Console.Write('*');

                }

                emptySpaces--;
                Console.WriteLine();

                
            }

        }
    }
}
