using System;

namespace TriangleOf55Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var rad = double.Parse(Console.ReadLine());
            var deg = rad * 180.0 / Math.PI;

            
            Console.WriteLine( Math.Round (deg,0));
        }
    }
}
