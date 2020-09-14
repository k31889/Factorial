using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int Fact;
            Console.WriteLine("Enter the number");
            x = Convert.ToInt32(Console.ReadLine());
            Fact = x;
            for (int i = 1; i < x; i++)
            {
                Fact = Fact * (x - i);
            }
            Console.WriteLine(Fact);
        }
    }
}
