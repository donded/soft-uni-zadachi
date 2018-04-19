using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Bus
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPasager = int.Parse(Console.ReadLine());
            int countStops = int.Parse(Console.ReadLine());
            for (int stops = 1; stops <= countStops; stops++)
            {
                int exitPasager = int.Parse(Console.ReadLine());
                int enterPasager = int.Parse(Console.ReadLine());
                countPasager = countPasager - exitPasager + enterPasager;
                if (stops % 2 ==0)
                {
                    countPasager -= 2;
                }
                else
                {
                    countPasager += 2;
                }
            }
            Console.WriteLine($"The final number of passengers is : {countPasager}");
        }
    }
}
