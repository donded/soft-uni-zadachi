using System;

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
            
              int n = int.Parse(Console.ReadLine());
            int firstNum = 0;
            int secondNum = 1;
            int thirdNum = 1;
            int sum = thirdNum + secondNum;
            if (n<=2)
            {
                Console.WriteLine(secondNum);
                
            }
            else 
               
            for (int i = 2; i < n; i++)
            {
                thirdNum = secondNum;
                secondNum = firstNum + secondNum;
                firstNum = thirdNum;

                    sum = thirdNum + secondNum;
                    
                }


            Console.WriteLine(sum + secondNum);
        }
    }
}