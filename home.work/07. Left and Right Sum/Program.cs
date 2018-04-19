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
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("*");
                for (int c = 0; c < n-1 ; c++)
                {
                    Console.Write(" *");
                    
                }
                Console.WriteLine();
            }
            
        }
    }
}
