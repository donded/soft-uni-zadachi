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

            var totalseconds = firstCompetitor + secondCompetitor + thirdCompetitor;
            var minutes = totalseconds / 60;
            var seconds = totalseconds % 60;

            if (seconds < 10) 

                   Console.WriteLine(minutes + ":0" + seconds);
            else
                   Console.WriteLine(minutes + ":" +seconds);
        }
    }
}
