using System;

namespace Square_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            if (n > 2)
            {
                Console.WriteLine(new string('*', n));
                for (int i = 1; i < n - 2; i++) ;
                Console.WriteLine('*' + new string(' ', n - 2) + '*');
                for (int j = 1; j < n - 2; j++)

                    Console.WriteLine('*' + new string(' ', n - 2) + '*');

                Console.WriteLine(new string('*', n));
            }
            else
                Console.WriteLine("**");
        }
    }
}
