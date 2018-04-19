using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());
        int minutesAfterMinutes = minutes + 15;

        if (hours >= 0 && hours <= 23 && minutesAfterMinutes >= 60)
        {
            hours++;
            if (hours == 24)
            {
                hours = 0;
            }
            minutes = (minutesAfterMinutes) % 60;
            Console.WriteLine("{0}:{1}", hours, minutes.ToString().PadLeft(2, '0'));
        }
        else
        {
            minutes = (minutesAfterMinutes) % 60;
            Console.WriteLine("{0}:{1}", hours, minutes.ToString().PadLeft(2, '0'));
        }
    }
}