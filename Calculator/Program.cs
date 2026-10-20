using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Optional: Console application entry point logic goes here
        }
    }

    public class Calculations
    {
        // Constructor
        public Calculations()
        {
        }

        // This method fixes the compilation error in your unit test
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        // FIXED: Implemented subtraction logic instead of throwing an exception
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
            // return median of x, y, z
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
