using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace podgotowka
{
    class Program
    {
        static void Main(string[] args)
        {
            double processor = double.Parse(Console.ReadLine());
            double video = double.Parse(Console.ReadLine());
            double ram = double.Parse(Console.ReadLine());
            int ramCountity = int.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            
            double ProcessorLV = processor * 1.57;
            double videoLV = video * 1.57;
            double ramLV = ram * 1.57;

            double totalram = ramLV * ramCountity;
            double totalCPUPrice = ProcessorLV * (1.0 - discount);
            double totalvideoPrice = videoLV * (1.0 - discount);
            double sum = totalCPUPrice + totalvideoPrice + totalram;
            Console.WriteLine($"Money needed {sum:F2} leva.");

        }
    }
}
