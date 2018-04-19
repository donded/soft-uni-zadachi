using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine();
            string banana = "banana";
            string apple = "apple";
            string kiwi = "kiwi";
            string cherry = "cherry";
            string lemon = "lemon";
            string grapes = "grapes";
            string tomato = "tomato";
            string pepper = "pepper";
            string carrot = "carrot";
            string cucumber = "cucumber";

            if (product == banana || product == apple || product == kiwi 
                ||product == cherry || product == grapes || product == lemon)
            {
                Console.WriteLine("fruit");
            }
            else if (product == tomato || product==pepper 
                || product == carrot || product == cucumber)
            {
                Console.WriteLine("vegetable");

            }
            else
                Console.WriteLine("unknown");
        }
        
    }
}
