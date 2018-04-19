using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int size = n - 2;
            string TopAndBottomRow = "+";

            for (int r = 0; r < size ; r++)

            {
             TopAndBottomRow = TopAndBottomRow + " -";
            }
            TopAndBottomRow = TopAndBottomRow + " +";
            Console.WriteLine(TopAndBottomRow);
            string midRow = "|";

            for (int r = 0; r < size; r++)

            {
             midRow = midRow+ " -";
            }
            midRow = midRow + " |";

            for (int c = 0; c < size; c++)
            {
                Console.WriteLine(midRow);
            }
            Console.WriteLine(TopAndBottomRow);


        }
    }
}
