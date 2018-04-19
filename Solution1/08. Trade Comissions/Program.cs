using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var city = Console.ReadLine().ToLower();
            var sales = double.Parse(Console.ReadLine());
            var bonus = 0.0;

            if (sales < 0)
            {
                Console.WriteLine("error");
            } 
            else if (city == "sofia" || city == "varna" || city == "plovdiv")
            {
                if (city == "sofia" && sales >= 0 && sales <= 500)
                {
                    bonus = sales * 0.05;
                }
                else if (city == "sofia" && sales >= 500 && sales <= 1000)
                {
                    bonus = sales * 0.07;
                }
                else if (city == "sofia" && sales >= 1000 && sales <= 10000)
                {
                    bonus = sales * 0.08;
                }
                else if (city == "sofia" && sales >= 10000)
                {
                    bonus = sales * 0.12;
                }
                else if (city == "varna" && sales >= 0 && sales <= 500)
                {
                    bonus = sales * 0.045;
                }
                else if (city == "varna" && sales >= 500 && sales <= 1000)
                {
                    bonus = sales * 0.075;
                }
                else if (city == "varna" && sales >= 1000 && sales <= 10000)
                {
                    bonus = sales * 0.10;
                }
                else if (city == "varna" && sales >= 10000)
                {
                    bonus = sales * 0.13;
                }
                else if (city == "plovdiv" && sales >= 0 && sales <= 500)
                {
                    bonus = sales * 0.055;
                }
                else if (city == "plovdiv" && sales >= 500 && sales <= 1000)
                {
                    bonus = sales * 0.08;
                }
                else if (city == "plovdiv" && sales >= 1000 && sales <= 10000)
                {
                    bonus = sales * 0.120;
                }
                else if (city == "plovdiv" && sales >= 10000)
                {
                    bonus = sales * 0.145;
                }

                Console.WriteLine("{0:F2}", bonus);
            }
            else
                Console.WriteLine("error");


            

        }

        
    }
}