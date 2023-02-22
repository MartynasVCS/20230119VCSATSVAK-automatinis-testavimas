using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example of how a unit test could be done in a stupid way
            int sum = Functions.Sum_Int(5, 5);
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
