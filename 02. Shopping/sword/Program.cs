using System;


namespace sword
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int LeftRight = n - 1;

            Console.WriteLine(new string('#', LeftRight)+ "/^\\"+ new string('#', LeftRight));
            char empty = ' ';
            int spaces = 3;
            int dif = LeftRight / 2;
            int full = (2*n) + 1;
            for (int row = LeftRight -1 ; row>=dif ; row--)
            {
                
               
                Console.WriteLine(new string ('#',row )+'.'+new string(empty,spaces)+'.'+new string ('#',row));
                spaces += 2;

            }
           
            Console.WriteLine(new string('#', dif)+'|'+ new string (empty,(n/2))+'S'+ new string(empty, (n / 2))+ '|'+ new string('#', dif));
            Console.WriteLine(new string('#', dif) + '|' + new string(empty, (n / 2)) + 'O' + new string(empty, (n / 2)) + '|' + new string('#', dif));
            Console.WriteLine(new string('#', dif) + '|' + new string(empty, (n / 2)) + 'F' + new string(empty, (n / 2)) + '|' + new string('#', dif));
            Console.WriteLine(new string('#', dif) + '|' + new string(empty, (n / 2)) + 'T' + new string(empty, (n / 2)) + '|' + new string('#', dif));
            if (n <= 4)

                Console.WriteLine(new string('#', dif) + '|' + new string(empty,n/2) + ' ' + new string(empty, (n / 2)) + '|' + new string('#', dif));

            else
                for (int row = 1; row <= n-4; row++)
                {
                    Console.WriteLine(new string('#', dif) + '|' + new string(empty,n/2) + ' ' + new string(empty, (n/2)) + '|' + new string('#', dif));
                }

                    Console.WriteLine(new string('#', dif) + '|' + new string(empty, (n / 2)) + 'U' + new string(empty, (n / 2)) + '|' + new string('#', dif));
            Console.WriteLine(new string('#', dif) + '|' + new string(empty, (n / 2)) + 'N' + new string(empty, (n / 2)) + '|' + new string('#', dif));
            Console.WriteLine(new string('#', dif) + '|' + new string(empty, (n / 2)) + 'I' + new string(empty, (n / 2)) + '|' + new string('#', dif));
            Console.WriteLine("@"+new string('=',full-2)+ "@");
            int handle = (n + 3) / 2;
            for (int row = 0; row <= n/2; row++)
            {
                Console.WriteLine(new string('#', handle) + '|' + new string(' ', (full - (handle + 1)*2)) + '|' + new string('#', handle));
            }
            Console.WriteLine(new string('#', handle) + '\\' + new string('.', (full - (handle + 1) * 2)) + '/' + new string('#', handle));
        }
    }
}
