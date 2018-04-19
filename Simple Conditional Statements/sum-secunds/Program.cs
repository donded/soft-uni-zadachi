using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_secunds
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstCompetitor = int.Parse(Console.ReadLine());
            var secondCompetitor = int.Parse(Console.ReadLine());
            var thirdCompetitor = int.Parse(Console.ReadLine());

            int seconds = firstCompetitor + secondCompetitor + thirdCompetitor;
            int minutes = 0;

            if (seconds < 60);
            {
                Console.WriteLine("0:" + seconds);
            }

        }
    }
}
