using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inches_to_cm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("inches = " );
            var inches = double.Parse(Console.ReadLine());
            var cm = inches * 2.54;
            Console.Write("cm = ");
            Console.WriteLine(cm + " cm");
        }
    }
}
