using System;

namespace _3_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = Double.Parse(Console.ReadLine());
           
            bool isinrange = (num1 >= 100 && num1 <= 200) || num1 == 0;
            
               if (!isinrange)
                {
                    Console.WriteLine("invalid");
                }        
        }
    }
}
