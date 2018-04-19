using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            var p = int.Parse(Console.ReadLine());
            var h = int.Parse(Console.ReadLine());
            var insofia = 48 - h;
            var play_in_sofia = insofia * (3.0 / 4);
            var play_in_town = h;
            var play_in_holidey = p * (2.0 / 3);
            var total_play = play_in_holidey + play_in_sofia + play_in_town;

            if (year == "leap")
            {

                Console.WriteLine(Math.Truncate(total_play * 1.15));
            }
            else
                

            Console.WriteLine (Math.Truncate(total_play));


        }
    }
}
