using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Number_in_Range__1._._._100_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter valid number in Range [1 to 100]");
            int num = int.Parse(Console.ReadLine());
            while (num < 1 || num > 100)
            {
                Console.Write("Invalid Number, try again!");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The Number is:{0}", num);
            
        }
    }
}
