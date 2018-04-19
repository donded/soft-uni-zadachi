using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int dancer = int.Parse(Console.ReadLine());
            int energy = (100 * days * dancer);
            double totalEnergyLeft = 0;
            
            
            
            
            for (int day = 1; day <= days; day++)
            {
                int hour = int.Parse(Console.ReadLine());

                if (day % 2==0 && hour %2 == 0 )
                {
                   totalEnergyLeft = totalEnergyLeft + (68 * dancer);

                }
                else if (day % 2 != 0 && hour % 2 == 0)
                {
                    totalEnergyLeft = totalEnergyLeft+(49 * dancer);

                }
                else if (day % 2 == 0 && hour % 2 != 0)
                {
                    totalEnergyLeft = totalEnergyLeft+(65 * dancer);
                }
                else
                {
                    totalEnergyLeft = totalEnergyLeft+( 30 * dancer);
                }
                
            }
            
            double dancerEnergyLeft = (energy- totalEnergyLeft) / dancer / days;
            if (dancerEnergyLeft>=50)
            {
                Console.WriteLine($"They feel good! Energy left: {dancerEnergyLeft:F2}");
            }
            else
            {
                Console.WriteLine($"They are wasted! Energy left: {dancerEnergyLeft:F2}");
            }
        }
    }
}
