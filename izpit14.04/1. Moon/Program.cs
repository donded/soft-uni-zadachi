using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Moon
{
    class Program
    {
        static void Main(string[] args)
        {
            double speed = int.Parse(Console.ReadLine());
            double gas = int.Parse(Console.ReadLine());
            double totalKm = 384400 * 2;
            Double time =Math.Ceiling (totalKm / speed);
            double totalTime = time + 3;
            double litri = (gas * totalKm) / 100;
            Console.WriteLine(totalTime);
            Console.WriteLine(litri);

        }
    }
}
