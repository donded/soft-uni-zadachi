namespace adva
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(System.Console.ReadLine());
            int num = 1;
            while (num <= n)
            {
                System.Console.WriteLine(num);
                num = num * 2 + 1;
            }
        }
    }
}
