using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Car_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int n1 = start + 1 ; n1 <= end; n1++)
            {
                for (int n2 = start; n2 <= end; n2++)
                {
                    for (int n3 = start; n3 <= end; n3++)

                    {
                        
                            for (int n4 = start; n4 < end; n4++)
                            {
                            if ((n1%2==0 && n4%2 !=0) || (n1 % 2 != 0 && n4 % 2 == 0))
                            {
                                if ((n2+n3)%2==0 && n4<n1)
                                {
                                    Console.Write($"{n1}{n2}{n3}{n4} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
