using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_CUP
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int firstrow = n * 3;
            int calculate = n / 2;
            int midle = n * 2 - 2;
            int half = (5 * n - 10)/2;
            for (int row = 0; row <= calculate-1; row++)
            {
                Console.WriteLine(new string ('.',n+row)+new string ('#',firstrow-row)+ new string('.', n + row));
                firstrow-=1;
            }
            
            for (int row = 0; row <= calculate ; row++)
                
            {
                
                Console.WriteLine(new string('.', n+calculate + row) + new string('#',1) + new string('.', midle - row)+ new string('#', 1)+ new string('.', n + calculate + row));
                midle -= 1;
                firstrow -= 1;
            }
            Console.WriteLine(new string('.',n*2)+new string ('#',n)+ new string('.', n * 2));
            for (int row = 0; row < calculate; row++)
            {
                midle = n * 2 - 2;
                Console.WriteLine(new string('.',midle)+new string('#',n+4)+ new string('.', midle));
            }
            Console.WriteLine(new string('.', half) + new string('D', 1)+ new string('^', 1)+ new string('A', 1)+ new string('^', 1)+ new string('N', 1) + new string('^', 1)+ new string('C', 1)+ new string('^', 1) + new string('E', 1)+ new string('^', 1) + new string('.', half));
            for (int row = 0; row <=calculate; row++)
            {
                midle = n * 2 - 2;
                Console.WriteLine(new string('.', midle) + new string('#', n + 4) + new string('.', midle));
            }

        }
    }
}
