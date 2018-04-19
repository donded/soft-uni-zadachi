using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var stars = 1;
            if (n % 2 == 0)
            {
                stars = 2;
            }
            for (int row = 0; row < (n + 1) / 2; row++)
            {
                var dashes = (n - stars) / 2;
                Console.Write(new string('-', dashes));
                Console.Write(new string('*', stars));
                Console.Write(new string('-', dashes));
                Console.WriteLine();
                stars = stars + 2;
            }
            var bodyrows = n - (n + 1) / 2;
            for (int row = 0; row < n / 2; row++)
            {
                Console.Write("|");
                Console.Write(new string('*', n - 2));
                Console.WriteLine("|");

            }
        }

    }
}