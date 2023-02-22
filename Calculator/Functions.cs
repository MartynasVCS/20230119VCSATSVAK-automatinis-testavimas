using System;

namespace Calculator
{
    public class Functions
    {
        public static double Division_Double(int num1, int num2)
        {
            return (double) num1 / num2;
        }

        public static double Division_Double_Rounded(int num1, int num2)
        {
            return Math.Round((double)num1 / num2, 6);
        }

        public static decimal Division_Decimal(int num1, int num2)
        {
            return (decimal) num1 / num2;
        }

        public static int Product(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Difference(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Sum_Int(int num1, int num2)
        {
            return num1 + num2;
        }

        public static double Sum_Double(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double Sum_Double_3(double num1, double num2, double num3)
        {
            return num1 + num2 + num3;
        }

        public static decimal Sum_Decimal_3(decimal num1, decimal num2, decimal num3)
        {
            return num1 + num2 + num3;
        }
    }
}
