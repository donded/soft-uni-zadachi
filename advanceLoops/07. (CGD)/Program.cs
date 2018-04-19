using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._CGD_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            while (b!=0)
            {
                int CGD = a % b;
                a = b;
                b = CGD;

            }
            Console.WriteLine(a);
        }
       
        
    }
}
