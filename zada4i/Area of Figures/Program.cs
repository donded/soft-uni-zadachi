using System;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();
           

            if (figure == "square")
            {
                var a1 = double.Parse(Console.ReadLine());
                Double s = a1 * a1; Math.Round(s, 3);
                Console.WriteLine(s);
            }
            else if (figure == "rectangle")
            {
                var a1 = double.Parse(Console.ReadLine());
                var b1 = double.Parse(Console.ReadLine());

                Double s = a1 * b1; Math.Round(s, 3);
                Console.WriteLine(s);
            }
            else if (figure == "circle")

            {
                var a1 = double.Parse(Console.ReadLine());
                double S = Math.PI * a1 * a1 ;Math.Round(S, 3);
                Console.WriteLine(S);
            }
            else if (figure == "triangle")
            {
                var a1 = double.Parse(Console.ReadLine());
                var b1 = double.Parse(Console.ReadLine());
                double S = (a1 * b1) / 2; Math.Round(S, 3);
                Console.WriteLine(S);
            }
        } 
        

    

    }
}
