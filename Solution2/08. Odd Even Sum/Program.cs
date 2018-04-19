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

            int ODDsum = 0;
            int EVENSum = 0;

            


            for (int i = 0; i < numberToRead ; i++)
            {
                int readnumber = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    EVENSum += readnumber;
                }
                else
                {
                    
                     ODDsum  += readnumber;
                }
               
            }

            if (ODDsum == EVENSum)
            {
                Console.WriteLine($"YES, sum =   {ODDsum}");
            }
            else
            {
                int diff = Math.Abs(ODDsum - EVENSum);
                Console.WriteLine($"NO, diff =  {diff}");
            }
            

           
         


        }
    }
}
