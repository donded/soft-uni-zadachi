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
            var input = Console.ReadLine();
            string pass = "s3cr3t!P@ssw0rd";
            if (input == pass)
            {
                Console.WriteLine("welcome");
            }
                else
                Console.WriteLine("Wrong password!");

        }
    }
}
