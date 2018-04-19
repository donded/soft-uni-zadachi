using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Point_on_Rectangle_Border
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            bool rightside = (x == x2) && (y <= y2 && y >= y1);
            bool leftside = (x == x1) && (y <= y2 && y >= y1);
            bool topside = (y == y1) && (x <= x2 && x >= x1);
            bool bottomside = (y == y2) && (x <= x2 && x >= x1);

            if (rightside||leftside||topside||bottomside)
            {
                Console.WriteLine("Border");
            }
            else
                Console.WriteLine("Inside / Outside");
                        
        }
    }
}
