using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = Functions.Sum(5, 5);
            if (sum == 10)
            {
                Console.WriteLine("Works");
            }
            else
            {
                Console.WriteLine("Bug!!!");
            }
        }
    }
}
