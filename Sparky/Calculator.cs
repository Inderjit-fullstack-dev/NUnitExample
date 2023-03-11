using System;
using System.Collections.Generic;

namespace Sparky
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double AddDouble(double a, double b)
        {
            return a + b;
        }

        public bool IsOddNumber(int number) 
        {
            return number % 2 != 0;
        }

        public List<int> GetEvenRange(int minRange, int maxRange)
        {
            List<int> evenNumbers = new();
            for (int i = minRange; i <= maxRange; i++)
            {
                if (i % 2 == 0) 
                {
                    evenNumbers.Add(i);
                }
            }

            return evenNumbers;
        }

    }
}
