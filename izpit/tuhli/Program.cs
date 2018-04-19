using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuhli
{
    class Program
    {
        static void Main(string[] args)
        {
            int briks = int.Parse(Console.ReadLine());
            int worker = int.Parse(Console.ReadLine());
            int car = int.Parse(Console.ReadLine());
            int totalPerCourse = worker * car;
            int course = briks / totalPerCourse;
            Console.WriteLine(course+1);

        }
    }
}
