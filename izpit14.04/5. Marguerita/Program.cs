using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Marguerita
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 8 * n + 2;
            Console.WriteLine(new string('\'', 1) + new string('&', 1) + new string('$', 1) + new string('\'', width - 3));
            for (int row = 1; row < n; row++)
            {
                Console.WriteLine(new string ('\'',row+1)+new string ('\\',1)+new string ('\'',(width-3-row)+1));
            }
            for (int row = 0; row < 4*n; row++)
            {
                Console.Write("^*");
                
            }
            Console.WriteLine("^\'");
            for (int row = 0 ; row < n-1; row++)
            {
                Console.WriteLine(new string('\'',row)+"\\\\"+new string (' ',n)+'\\'+new string (' ',width-6-n-(row*2))+"//"+new string('\'',row+1));
            }
            Console.WriteLine(new string('\'', n-1)+ "\\"+ new string ('~',width-(n*2)-1)+"/"+ new string('\'', n));
            for (int row = 0; row < n-2; row++)
            {
                Console.WriteLine(new string ('\'',n+row)+"\\"+new string(' ',n*6-1-(row*2))+"/"+new string('\'',n+1+row));
            }
            Console.WriteLine(new string('\'',(n*2)-2)+"\\"+new string('_',width-(n*2-1)-n*2)+"/"+ new string('\'', n * 2-1));
            Console.WriteLine(new string('\'', (n * 2) - 1) + "\\" + new string('.', width - (n * 2 - 1) - n * 2-2) + "/" + new string('\'', n * 2));
            for (int row = 0; row < n*2-2; row++)
            {
                Console.WriteLine(new string('\'',n*2+row)+"\\"+new string (' ', width - (4*n) - 3-row*2)+"/"+ new string('\'', n * 2+row+1));
                
            }
            Console.WriteLine(new string('\'',n*4-2)+"\\"+new string('_',3)+"/"+new string('\'',n*4-1));
            for (int row = 0; row <= n*2; row++)
            {
                Console.WriteLine(new string('\'', n * 4 - 2) + "\'" + new string('|', 3) + "\'" + new string('\'', n * 4 - 1));
            }
            Console.WriteLine(new string('_',width-1)+"\'");
            Console.WriteLine("\'"+new string ('-',width-3)+new string('\'',2));
        }

        

    }
}
