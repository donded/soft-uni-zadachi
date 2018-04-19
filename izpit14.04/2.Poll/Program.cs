using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Poll
{
    class Program
    {
        static void Main(string[] args)
        {
            double people = int.Parse(Console.ReadLine());
            double FirstVote = int.Parse(Console.ReadLine());
            double secondVote = FirstVote - (FirstVote * 0.2);
            double thirdVote = secondVote - (secondVote * 0.1);
            double halfVote = people / 2;
            double TotalVote = FirstVote + secondVote + thirdVote;
            double dif = Math.Abs (halfVote - TotalVote);
            dif = Math.Round(dif);
            if (TotalVote >= halfVote)
            {
                Console.WriteLine($"First three languages have {dif} votes more ");
            }
            else
            {
                Console.WriteLine($"First three languages have {dif} votes less of half votes");
            }

        }
    }
}
