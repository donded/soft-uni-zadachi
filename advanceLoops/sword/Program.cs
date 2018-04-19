using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sword
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = (2 * n) + 1;
            int LeftRight = n - 1;
            Console.Write(new string('#',LeftRight));
            Console.Write("/*\\");
            Console.Write(new string('#', LeftRight));

            for (int i = 0; i < n/2; LeftRight -=1)
            {

            }



        }
    }
}
