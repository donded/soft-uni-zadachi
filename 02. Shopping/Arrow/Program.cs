using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = n + 5;
            int leftRight = (width - 1) / 2; 
            Console.WriteLine(new string('_',leftRight)+'^'+ new string('_', leftRight));

            int line = 1;

            for (int row = 1; row <= 2; row++)
            {
                
                Console.WriteLine(new string('_', leftRight -row) + '/' + new string('|',line) + '\\' + new string('_', leftRight- row));
                line = line + 2;
            }
            int dots = (n - 2) / 2;
            for (int row = 1; row <=dots ; row++)
            {
                Console.WriteLine(new string('_', leftRight - (row + 2)) + '/' + new string('.', row) +"|||"+ new string('.', row)+'\\' + new string('_', leftRight - (row + 2)));
                    
            }
            for (int row = 0; row < 2; row++)
            {
                
                Console.WriteLine(new string('_', (width - 9)/2+row) + '/' + new string('.', 2-row) + "|||" + new string('.', 2-row) + '\\' + new string('_', (width-9)/2+row));
            }
            for (int row = 1; row <= n; row++)
            {
                Console.WriteLine(new string('_',(width-3)/2)+"|||"+ new string('_', (width - 3) / 2));
            }
            Console.WriteLine(new string('_', (width - 3) / 2) + "~~~" + new string('_', (width - 3) / 2));

            for (int i = 0; i <= n/2-1 ; i++)
            {
                Console.WriteLine(new string('_', n/2-i)+"//"+new string('.',i)+'!'+ new string('.', i)+ "\\\\"+ new string('_', n / 2 - i));
            }


        }
    }
}
