﻿using System;

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
    }
}
