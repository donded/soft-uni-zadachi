using System;

namespace Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=   ");
            var a = double.Parse(Console.ReadLine());
            Console.Write ("b=   ");
            var b = double.Parse(Console.ReadLine());
            var area = (a * b) ;
            if (area <= 0)
                Console.WriteLine("Area is not valid, please enter the correct values");
            else
            {
                Console.WriteLine("Area is {0}", area );
            }
        }
    }
}
