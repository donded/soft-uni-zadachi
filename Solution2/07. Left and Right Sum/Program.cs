using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberToRead = int.Parse(Console.ReadLine());

            int leftSum = 0;
            for (int i = 0; i < numberToRead; i++)
            {
                int readnumber = int.Parse(Console.ReadLine());

                leftSum += readnumber;

            }

            int rightSum = 0;
            for (int i = 0; i < numberToRead; i++)
            {
                int readnumber = int.Parse(Console.ReadLine());

               rightSum  += readnumber;
            }

            if (leftSum==rightSum)
            {
                Console.WriteLine($"YES, sum =   {leftSum}");
            }
            int diff = Math.Abs(leftSum - rightSum);
            Console.WriteLine($"NO, diff =  {diff}");
            Console.WriteLine();
            
            
        }
    }
}
