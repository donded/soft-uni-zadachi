using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int numToRead = int.Parse(Console.ReadLine());
            int maxNum = int.MinValue;
            int sumAllNum = 0;

            for (int i = 0; i < numToRead; i++)
            {
                int ReadNum = int.Parse(Console.ReadLine());

                sumAllNum += ReadNum;
                
                if (ReadNum > maxNum)
                {
                    maxNum = ReadNum;
                }
                

                
            }
            int sumOtherNum = sumAllNum - maxNum;
            if (sumOtherNum == maxNum) 

            {
                Console.WriteLine("Yes");
                Console.WriteLine($"sum = + {maxNum}");
            }

           else
            {
                int diff = Math.Abs(maxNum - sumOtherNum);
                Console.WriteLine("No");
                Console.WriteLine($"diff = {diff}");
            }
        }
    }
}