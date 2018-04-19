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

            while (true)
            {
                if (n <2)
                {
                    Console.WriteLine(1);
                    break;
                }
                else if (n == 2)
                {
                    Console.WriteLine(2);
                    break;
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
                break;

            }



        }
    }
}