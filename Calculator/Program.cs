using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Calculator App ===");
            var calc = new Calculations();
            Console.WriteLine($"Test Add: 5 + 3 = {calc.Add(5, 3)}");
            Console.WriteLine($"Test Subtract: 10 - 4 = {calc.Subtract(10, 4)}");
            Console.WriteLine($"Test Mid: Median of 3, 9, 5 is {calc.Mid(3, 9, 5)}");
            Console.ReadLine();
        }
    }

    public class Calculations
    {
        public Calculations()
        {
        }

        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public double Subtract(int v1, int v2)
        {
            return v1 - v2;
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            return a / b;
        }

        public int Mid(int x, int y, int z)
        {
            int mid = z;
            if (y < z)
            {
                if (x < y)
                {
                    mid = y;
                }
                else if (x < z)
                {
                    mid = x;
                }
            }
            else
            {
                if (x > y)
                {
                    mid = y;
                }
                else if (x > z)
                {
                    mid = x;
                }
            }
            return mid;
        }
    }
}
