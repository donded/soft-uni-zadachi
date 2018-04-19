using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            var text1 = Console.ReadLine().ToLower();
            var text2 = Console.ReadLine().ToLower();


            if (text1 == text2)
            {
                Console.WriteLine("yes");
            }
            else
                Console.WriteLine("no");

        }
    }
}