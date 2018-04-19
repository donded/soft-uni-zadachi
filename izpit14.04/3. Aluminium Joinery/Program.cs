using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Aluminium_Joinery
{
    class Program
    {
        static void Main(string[] args)
        {
            int countDograma = int.Parse(Console.ReadLine());
            string type =  Console.ReadLine();
            string dilivery = Console.ReadLine();
            int s90X130 = 110;
            int s100X150 = 140;
            int s130X180 = 190;
            int s200X300 = 250;
            double total = 0;

            if (countDograma <10)
            {
                Console.WriteLine("Invalid order");
                return;
            }


            if (type.Equals ("90X130"))
            {
                total = countDograma*110 ;
                if (countDograma >=30 && countDograma <= 60 )
                {
                   
                    total =total-(total * 0.05);
                }
                else if (countDograma >= 60)
                {
                    total = total -( total * 0.08);
                }

            }
            if (type.Equals("100X150"))
            {
                total = countDograma * 140 ;
                if (countDograma >= 40 && countDograma <= 80)
                {

                    total = total -( total * 0.06);
                }
                else if (countDograma >= 80)
                {
                    total = total- (total * 0.10);
                }

            }
            if (type.Equals("130X180"))
            {
                total = countDograma * 190;
                if (countDograma >= 20 && countDograma <= 50)
                {

                    total =total -  (total * 0.07);
                }
                else if (countDograma >= 50)
                {
                    total = total- (total * 0.12);
                }

            }
            if (type.Equals("200X300"))
            {
                total = countDograma * 250;
                if (countDograma >= 25 && countDograma <= 50)
                {

                    total = total -  (total * 0.09);
                }
                else if (countDograma >= 50)
                {
                    total = total - (total * 0.14);
                }

            }
            if (dilivery.Equals("With delivery"))
            {
                total = total + 60;
            }
            if (countDograma >99)
            {
                total = total - (total * 0.04);
            }
            Console.WriteLine($"{total:F2} BGN" );
        }
    }
}
